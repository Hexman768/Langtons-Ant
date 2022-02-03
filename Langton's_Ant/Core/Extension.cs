using System.Reflection;
using System.Windows.Forms;

namespace Langton_s_Ant.Core
{
    /// <summary>
    /// This class is used to call the static method below to stop screen flickering.
    /// </summary>
    public static class Extension
    {
        /// <summary>
        /// This method enables double buffering which prevents the Control from flickering.
        /// </summary>
        /// <param name="control">Control to modify</param>
        /// <param name="enabled">Boolean value</param>
        public static void DoubleBuffered(this Control control, bool enabled)
        {
            var prop = control.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            prop.SetValue(control, enabled, null);
        }
    }
}
