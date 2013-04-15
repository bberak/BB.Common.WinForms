using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace BB.Common.WinForms
{
    public static class Extensions
    {
        public delegate void GenericEventHandler<T>(T value);

        //-- Updating properties of controls using delegates and invocation (avoiding cross-thread call exception)
        public static void UpdateProperty<T>(this Control ctrlToUpdate, string propertyName, T newValue)
        {
            PropertyInfo pInfo = ctrlToUpdate.GetType().GetProperty(propertyName);

            if (pInfo == null)
                throw new NullReferenceException("The type (" + ctrlToUpdate.GetType().ToString() + ") does not contain the required property (" + propertyName + ").");

            if (pInfo.PropertyType != typeof(T))
                throw new InvalidOperationException("The property '" + propertyName + "' cannot be updated with this type (" + newValue.GetType().ToString() + ").");

            if (ctrlToUpdate.InvokeRequired)
                //-- Can also use Invoke here (calling thread will wait for return).
                ctrlToUpdate.BeginInvoke(new GenericEventHandler<T>(x => pInfo.SetValue(ctrlToUpdate, x, null)), new object[] { newValue });
            else
                pInfo.SetValue(ctrlToUpdate, newValue, null);
        }

        //-- Clear the controls/child controls of a particular control using delegates and invocation (avoiding cross-thread call exception)
        public static void ClearControls(this Control ctrlToClear)
        {
            if (ctrlToClear.InvokeRequired)
            {
                //-- Can also use Invoke here (calling thread will wait for return).
                ctrlToClear.BeginInvoke((Action)delegate()
                {
                    ctrlToClear.Controls.Clear();
                });
            }
            else
                ctrlToClear.Controls.Clear();
        }

        //-- Add a child control to a parent using delegates and invocation (avoiding cross-thread call exception)
        public static void AddToControls(this Control ctrlParent, Control child)
        {
            if (ctrlParent.InvokeRequired)
            {
                //-- Can also use Invoke here (calling thread will wait for return).
                ctrlParent.BeginInvoke((Action)delegate()
                {
                    ctrlParent.Controls.Add(child);
                });
            }
            else
                ctrlParent.Controls.Add(child);
        }

        //-- Extension methods for calling methods on control objects and avoiding the cross-thread call exception
        public static object Execute(this Control ctrlParent, Delegate method, params object[] args)
        {
            if (ctrlParent.InvokeRequired)
                return ctrlParent.Invoke(method, args);
            else
                return method.DynamicInvoke(args);

        }

        public static void Execute(this Control ctrlParent, Action method)
        {
            if (ctrlParent.InvokeRequired)
                ctrlParent.Invoke(method);
            else
                method();
        }

        public static object ExecuteMethod(this Control ctrlToUpdate, string methodName, Type[] types, object[] args)
        {
            MethodInfo mInfo = ctrlToUpdate.GetType().GetMethod(methodName, types);

            if (mInfo == null)
                throw new NullReferenceException("The type (" + ctrlToUpdate.GetType().ToString() + ") does not contain the required method (" + methodName + ").");

            if (ctrlToUpdate.InvokeRequired)
            {
                //-- Use Invoke here to wait for the return (calling thread will wait for return).
                //-- Use BeginInvoke to ignore the return.
                object result = null;

                ctrlToUpdate.Invoke((Action)delegate()
                {
                    result = mInfo.Invoke(ctrlToUpdate, args);
                });

                return result;
            }
            else
                return mInfo.Invoke(ctrlToUpdate, args);
        }

        //-- https://github.com/DomenicDenicola/extensions/blob/master/WindowsFormsInvokingExtensions.cs
        /// <summary>
        /// Executes the specified delegate on the thread that owns the control's underlying window handle.
        /// </summary>
        /// <param name="control">The control whose window handle the delegate should be invoked on.</param>
        /// <param name="method">A delegate that contains a method to be called in the control's thread context.</param>
        public static void Invoke(this Control control, Action method)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(method);
            }
            else
            {
                method();
            }
        }

        /// <summary>
        /// Executes the specified delegate on the thread that owns the control's underlying window handle, returning a value.
        /// </summary>
        /// <param name="control">The control whose window handle the delegate should be invoked on.</param>
        /// <param name="method">A delegate that contains a method to be called in the control's thread context and that returns a value.</param>
        /// <returns>The return value from the delegate being invoked.</returns>
        public static TResult Invoke<TResult>(this Control control, Func<TResult> method)
        {
            if (control.InvokeRequired)
            {
                return (TResult)control.Invoke(method);
            }
            else
            {
                return method();
            }
        }

        //-- http://stackoverflow.com/questions/711408/best-way-to-invoke-any-cross-threaded-code/711419#711419
        public static void InvokeEx<T>(this T @this, Action<T> action) where T : ISynchronizeInvoke
        {
            if (@this.InvokeRequired)
            {
                @this.Invoke(action, new object[] { @this });
            }
            else
            {
                action(@this);
            }
        }

        //-- Extensions for firing events..
        public static void Fire(this EventHandler me, object sender, EventArgs e)
        {
            var myEvent = me;

            if (myEvent != null)
                myEvent(sender, e);
        }

        public static void Fire<T>(this EventHandler<T> me, object sender, T eventArgs) where T : EventArgs
        {
            var myEvent = me;

            if (myEvent != null)
                myEvent(sender, eventArgs);
        }
    }
}
