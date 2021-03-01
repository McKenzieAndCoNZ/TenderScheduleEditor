using System.Collections.Generic;
using System.Xml.Linq;

namespace PaymentsScheduleTemplateCreator.Models
{
    public class SeparablePortion_Model
    {
        public SeparablePortion_Model(){ }
        public SeparablePortion_Model(XElement sep_el)
        {
            if (!string.IsNullOrEmpty(sep_el?.Attribute("id")?.Value ))
                Id = sep_el.Attribute("id").Value;

            if (!string.IsNullOrEmpty(sep_el?.Attribute("name").Value))
                Name = sep_el.Attribute("name").Value;

            if (int.TryParse(sep_el?.Attribute("startingRow")?.Value, out var startingRow))
                StartingRow = startingRow;

            if (sep_el.Element("sections")?.Elements("section")!= null)
                foreach (XElement section_el in sep_el.Element("sections"
                                                    )?.Elements("section"))
                {
                    var section = new Section_Model(section_el);
                    if (section != null)
                        Sections.Add(section);
                }
        }
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int StartingRow { get; set; } = -1;
        public List<Section_Model> Sections { get; set; } = new List<Section_Model>();
        public override string ToString() { return Name;} 
    }
}
