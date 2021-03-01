using BrightIdeasSoftware;
using PaymentsScheduleTemplateCreator.Helper;
using PaymentsScheduleTemplateCreator.ViewModels;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace PaymentsScheduleTemplateCreator.Forms.FrmOpenProject
{
    public partial class FrmOpenProject
    { 
        private void SetUpColumns()
        {
            // ===========HotItemTracking==========================================
            // // Make the decoration
            RowBorderDecoration rbd = new RowBorderDecoration()
            {
                BorderPen = new Pen(Color.FromArgb(128, Color.LightSeaGreen), 2),
                BoundsPadding = new Size(1, 1),
                CornerRounding = 4.0F
            };

            // // Put the decoration onto the hot item
            this.LstRecentProjects.HotItemStyle = new HotItemStyle()
            {
                Decoration = rbd
            }; 


            // =======ProjectName=================================================================================
            OLVColumn olvColName = new OLVColumn()
            {
                Name = "olvColName",
                AspectName = "ProjectName",
                Text = "Project Name",
                Width = 502,
                MinimumWidth = 150,
                FillsFreeSpace = true
            };

            this.LstRecentProjects.AllColumns.Add(olvColName);
            this.LstRecentProjects.Columns.Add(olvColName);

            olvColName.Renderer = new DescribedTaskRenderer()
            {
                DescriptionAspectName = "ProjectFullPath",
                ImageTextSpace = 10,
                Aspect = "Name",
                TitleFont = new Font("Axiforma Book", 10, FontStyle.Bold)
            };


            // ===========LastUpdateDate=============================================================================
            OLVColumn olvColDate = new OLVColumn()
            {
                Name = "olvColDate",
                AspectName = "LastEdited",
                AspectToStringFormat = "{0:g}",
                Text = "Last Update Date",
                Width = 200
            }; 

            olvColDate.GroupKeyGetter = row =>
            {
                ProjectFile_ViewModel recentData = (ProjectFile_ViewModel)row;

                return new DateTime(recentData.LastEdited.Year, recentData.LastEdited.Month, 1);
            };
             
            olvColDate.HeaderFont = new Font("Axiforma Book", 12);

            this.LstRecentProjects.AllColumns.Add(olvColDate);
            this.LstRecentProjects.Columns.Add(olvColDate);
             
            //// ===========Sorting==============================
            //this.LstRecentProjects.CustomSorter = (OLVColumn column, SortOrder order) =>
            //{
            //    this.LstRecentProjects.ListViewItemSorter = new ColumnComparer(olvColDate, SortOrder.Descending, column, order);
            //};
        }

        private void AdjustListViewHieght(int height)
        {
            try
            {
                ImageList imgList = new ImageList
                {
                    ImageSize = new Size(1, height)
                };
                LstRecentProjects.SmallImageList = imgList;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
            }
        }


        private string FindDataGroup(ProjectFile_ViewModel projData)
        {
            try
            {
                DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
                int currentWeekOfyear = dfi.Calendar.GetWeekOfYear(DateTime.Now, dfi.CalendarWeekRule, DayOfWeek.Monday);
                int proj_week_integer = dfi.Calendar.GetWeekOfYear(projData.LastEdited, dfi.CalendarWeekRule, DayOfWeek.Monday);

                TimeSpan ts = DateTime.Today.Subtract(projData.LastEdited);
                if (ts.TotalDays == 1)
                    return "Today";

                if (ts.TotalDays == 2)
                    return "Yesterday";

                if (currentWeekOfyear < proj_week_integer)
                    return "This Week";

                if (currentWeekOfyear - proj_week_integer == 1)
                    return "Last Week";

                if (DateTime.Now.Month == projData.LastEdited.Month)
                    return "This Month";

                if (DateTime.Now.Year == projData.LastEdited.Year)
                    return "This Year";

                return "Older";
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);

                return "Unknown";
            }
        }
    }

}
