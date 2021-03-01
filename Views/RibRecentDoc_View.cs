using ComponentFactory.Krypton.Ribbon;

namespace PaymentsScheduleTemplateCreator.Views
{
    public class RibRecentDoc_View
    { 
        public KryptonRibbonRecentDoc RibRecentDoc(string text, string extra_text, string full_path)
        {
            var recent_doc = new KryptonRibbonRecentDoc
            { 
                Text = text,
                ExtraText = extra_text,
                Tag = full_path
            };

            return recent_doc; 
        }
    }
}
