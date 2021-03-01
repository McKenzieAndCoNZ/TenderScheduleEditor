using PaymentsScheduleTemplateCreator.Models;
using System;
using System.Xml.Linq;

namespace PaymentsScheduleTemplateCreator.ViewModels
{
    public class Item_ViewModel: Item_Model, ICloneable
    { 
        public Item_ViewModel() { }

        public Item_ViewModel(XElement item_el) : base(item_el)
        {
            if (! string.IsNullOrEmpty(item_el.Attribute("masterScheduleId")?.Value))
                MasterSchedule_Id = item_el.Attribute("masterScheduleId").Value;
        }

        public string MasterSchedule_Id { get; set; } = string.Empty;
          
        public object Clone()
        { 
            var item = new Item_ViewModel
            {
                Id = this.Id,
                MasterSchedule_Id = this.MasterSchedule_Id,
                ItemNumber = this.ItemNumber,
                SubItem = this.SubItem,
                Details = this.Details,
                Unit = this.Unit,
                Quantity = this.Quantity,
                Comment = this.Comment,
                Selected = this.Selected,
                Parent = this.Parent
            }; 
            if (this.Children.Count > 0)
                foreach (var child in this.Children)
                {
                    item.Children.Add(child.Clone() as Item_ViewModel);
                }
            return item;
        }

    }
}
