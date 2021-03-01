using System;
using System.Collections.Generic;
using System.Linq; 
using System.Windows.Forms;

namespace PaymentsScheduleTemplateCreator
{
    public static class ListViewExtensions
    {
        public static void AutoSizeControlHeight(this ListView lv, int maxItemsToShow, bool adjustForHorizontalScrollBar)
        {
            int positionBefore = 0;
            int positionAfter = 0;

            if (lv.Items.Count == 0)
                return;

            if (maxItemsToShow > lv.Items.Count)
                maxItemsToShow = lv.Items.Count;

            lv.Height = 50; 

            while (positionBefore != positionAfter && (lv.MaximumSize.Height == 0 || lv.Height < lv.MaximumSize.Height))
            {
                lv.Height += 1;

                lv.Items[0].EnsureVisible();
                positionBefore = lv.Items[maxItemsToShow - 1].Position.Y;

                lv.Items[maxItemsToShow - 1].EnsureVisible();
                positionAfter = lv.Items[maxItemsToShow - 1].Position.Y;
            }

            if (adjustForHorizontalScrollBar)
                lv.Height += SystemInformation.HorizontalScrollBarHeight;
        }

        public static void AutoSizeControlWidth(this ListView lv, bool adjustForVerticalScrollBar)
        {
            lv.Width = 0;
            for (int i = 0; i < lv.Columns.Count; i++)
                lv.Width += lv.Columns[i].Width;

            if (adjustForVerticalScrollBar)
                lv.Width += SystemInformation.VerticalScrollBarWidth;
        }

        public static void AutoSizeControlColumnWidth(this ListView lv, bool adjustForVerticalScrollBar)
        {
            int resizeByContent = 0;
            int resizeByHeader = 0;

            for (int i = 0; i < lv.Columns.Count; i++)
            {
                lv.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                resizeByContent = lv.Columns[i].Width;

                lv.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
                resizeByHeader = lv.Columns[i].Width;

                lv.Columns[i].Width = (resizeByHeader > resizeByContent) ? resizeByHeader : resizeByContent;
            }
        }

        public static void AutoSizeControl(this ListView lv, int maxItemsToShow, bool adjustForHorizontalScrollBar, bool adjustForVerticalScrollBar)
        {
            lv.AutoSizeControlColumnWidth(true);
            lv.AutoSizeControlWidth(adjustForVerticalScrollBar);
            lv.AutoSizeControlHeight(maxItemsToShow, adjustForHorizontalScrollBar);
        }
    }
}
