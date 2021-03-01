using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsScheduleTemplateCreator.Models
{
    public class TenderProject_Model
    {
        public List<KeyValuePair<string, string>> Attributes = 
                            new List<KeyValuePair<string, string>>();
        public List<SeparablePortion_Model> SeparablePortions { get; set; } = 
            new List<SeparablePortion_Model>();
        public Contract_Model Contract_Information { get; set; } = null;
    }
}
