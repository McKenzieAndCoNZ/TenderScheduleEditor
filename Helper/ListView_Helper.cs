using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentsScheduleTemplateCreator.Helper
{
    public class ListView_Helper
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern string SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);
         
        public static void EnableDoubleBuffer(Control control)
        {
            // set instance non-public property with name "DoubleBuffered" to true
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, control, new object[] { true });
        }

        public enum ListViewExtendedStyles
        {
            GridLines = 0x1,
            SubItemImages = 0x2,
            CheckBoxes = 0x4,
            TrackSelect = 0x8,
            HeaderDragDrop = 0x10,
            FullRowSelect = 0x20,
            OneClickActivate = 0x40,
            TwoClickActivate = 0x80,
            FlatsB = 0x100,
            Regional = 0x200,
            InfoTip = 0x400,
            UnderlineHot = 0x800,
            UnderlineCold = 0x1000,
            MultilWorkAreas = 0x2000,
            LabelTip = 0x4000,
            BorderSelect = 0x8000,
            DoubleBuffer = 0x10000,
            HideLabels = 0x20000,
            SingleRow = 0x40000,
            SnapToGrid = 0x80000,
            SimpleSelect = 0x100000
        }

        public enum ListViewMessages
        {
            First = 0x1000,
            SetExtendedStyle = (ListViewMessages.First + 54),
            GetExtendedStyle = (ListViewMessages.First + 55)
        }
    }
}
