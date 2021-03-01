using PaymentsScheduleTemplateCreator.Helper;
using PaymentsScheduleTemplateCreator.Models;
using System;
using System.Collections.Generic;

namespace PaymentsScheduleTemplateCreator.ViewModels
{
    public class ProjectFile_ViewModel: TenderProject_Model
    {
        public string Id { get; set; } = string.Empty;
        public string ProjectName { get; set; } = string.Empty;
        public string OutputDirectory { get; set; } = string.Empty;
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime LastEdited { get; set; }
        public string LastEditedBy { get; set; } = string.Empty;
        public string Project_FullPath { get; set; } = string.Empty;
        public bool DisplayInRecentList { get; set; }
        public MasterSchedule_Workbook_Model MasterSchedule { get; set; }
        public string Status { get; set; } = string.Empty;
        public List<string> Tags { get; set; } = new List<string>();
        public string Comments { get; set; } = string.Empty; 
        public int No_of_Lots { get; set; } = 0;

        public void WriteToFile(IWriter writer)
        { 
            try
            { 
                writer.SaveToFile(); 
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return;
            }
        }
    }
}
