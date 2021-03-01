using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PaymentsScheduleTemplateCreator.Helper
{
    public class StaticProperties_Helper
    {
        public enum Status
        {
            Design,
            Review,
            Approved
        }

        public static class ProjectAttributes
        {
            public static string ShowInRecentList { get; } = "showInRecentList";
            public static string LastEditedBy { get; } = "lastEditedBy";
            public static string CreatedBy { get; } = "createdBy";
            public static string DateCreated { get; } = "dateCreated";
            public static string Tag { get; } = "tag";
            public static string Status { get; } = "status";
            public static string Comments { get; } = "comments";
            public static int NoOfLots { get; set; } = 0;
        }
    }
}
