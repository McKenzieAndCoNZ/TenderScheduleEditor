using PaymentsScheduleTemplateCreator.ViewModels;
using System.Collections.Generic;
using System.Xml.Linq;

namespace PaymentsScheduleTemplateCreator.Models
{
    public class Item_Model 
    {
        public Item_Model() { }
        public Item_Model(XElement item_el)
        {
            if (!string.IsNullOrEmpty(item_el?.Attribute("id")?.Value))
                Id = item_el?.Attribute("id")?.Value.Trim(); 
            if (bool.TryParse((item_el?.Attribute("selected")?.Value), out var boolResult))
                Selected = boolResult;
            if (int.TryParse(item_el?.Element("item_number")?.Value, out var item_no))
                ItemNumber = item_no;
            if (!string.IsNullOrEmpty(item_el?.Element("subItem")?.Value))
                SubItem = item_el?.Element("subItem")?.Value.Trim();
            if (!string.IsNullOrEmpty(item_el?.Element("details")?.Value))
                Details = item_el?.Element("details")?.Value.Trim();
            if (!string.IsNullOrEmpty(item_el?.Element("unit")?.Value))
                Unit = item_el?.Element("unit")?.Value.Trim();
            if (!string.IsNullOrEmpty(item_el?.Element("qty")?.Value))
                Quantity = item_el?.Element("qty")?.Value.Trim();
            if (!string.IsNullOrEmpty(item_el?.Element("comment")?.Value))
                Comment = item_el?.Element("comment")?.Value.Trim();
        }

        public bool Selected { get; set; } = false;
        public string Id { get; set; } = string.Empty;
        public int ItemNumber { get; set; } = -1;
        public string SubItem { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;
        public string Unit { get; set; } = string.Empty; 
        public string Quantity { get; set; } = string.Empty; 
        public string Comment { get; set; } = string.Empty;
        public object Parent { get; set; }
        public int StartRow { get; internal set; }
        public int EndRow { get; internal set; }
        public List<Item_ViewModel> Children { get; set; } = new List<Item_ViewModel>();

    }
}
