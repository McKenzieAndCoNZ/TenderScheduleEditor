using System;
using System.Collections.Generic;

namespace PaymentsScheduleTemplateCreator.Models
{
    public class MasterSchedule_Workbook_Model
    {
        public string Version { get; set; }
        public List<Section_Model> Sections { get; set; } = new List<Section_Model>(); 
    }
}
