using System.Reflection;
using System.Windows.Forms;

namespace Langton_s_Ant.Core
{
    public static class Extension
    {
        public static void DoubleBuffered(this Control control, bool enabled)
        {
            var prop = control.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            prop.SetValue(control, enabled, null);
        }
    }
}
