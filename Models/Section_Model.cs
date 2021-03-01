using PaymentsScheduleTemplateCreator.Helper;
using PaymentsScheduleTemplateCreator.ViewModels;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace PaymentsScheduleTemplateCreator.Models
{
    public class Section_Model:ICloneable
    {
        public Section_Model() { }
        public Section_Model(XElement section_el)
        {
            if (!string.IsNullOrEmpty(section_el?.Attribute("id")?.Value))
                Id = section_el?.Attribute("id")?.Value;

            if (!string.IsNullOrEmpty(section_el?.Attribute("name")?.Value))
                Section_Name = section_el?.Attribute("name")?.Value;

            if (int.TryParse(section_el?.Attribute("number")?.Value, out var numb))
                Section_Number = numb;

            if (int.TryParse(section_el?.Attribute("startRow")?.Value,out var startRow))
                StartRow = startRow;

            if (int.TryParse(section_el?.Attribute("endRow")?.Value, out var endRow))
                EndRow = endRow;

            if (int.TryParse(section_el?.Attribute("subTotalRow")?.Value, out var subTotalRow))
                SubTotalRow = subTotalRow;

            if (section_el.Elements("item") != null)
                foreach (var item_el in section_el.Elements("item"))
                {
                    var item = new Item_ViewModel(item_el);
                    if (item != null)
                    {
                        if (item.ItemNumber == Section_Number)
                            item.Parent = this;
                        Items.Add(item);
                    }
                        
                }
            var subSections_el = section_el.Element("subSections");
            if (subSections_el != null)
            {
                Item_ViewModel parent_item = Items.Find(i => i.ItemNumber == this.Section_Number); 

                var subSection_els = subSections_el.Elements("subSection");
                foreach (XElement subSection_el in subSection_els)
                {
                    var sub_id = string.Empty;
                    if (!string.IsNullOrEmpty(subSection_el?.Attribute("id")?.Value))
                        sub_id = subSection_el?.Attribute("id")?.Value;

                    var sub_section_name = string.Empty;
                    if (!string.IsNullOrEmpty(subSection_el?.Attribute("name")?.Value))
                        sub_section_name = subSection_el?.Attribute("name")?.Value.Trim();
                    if (sub_section_name == "See Technical specification on Earthworks")
                    {
                        var st = string.Empty;
                    }
                    var sub_section = new Item_ViewModel
                    {
                        Id = sub_id,
                        Details = sub_section_name,
                        Parent = parent_item
                    };
                    Children.Add(sub_section);
                    if (parent_item?.Children != null)
                        if (!parent_item.Children.Exists(c => c == sub_section))
                            parent_item.Children.Add(sub_section);

                    if (subSection_el.Elements("item") != null)
                        foreach (var item_el in subSection_el.Elements("item"))
                        {
                            var item = new Item_ViewModel(item_el);
                            if (item != null)
                                sub_section.Children.Add(item);
                        } 
                }
            }
            WireParentsAndChildren();
        }

        public Section_Model(Section_Model ms_section)
        {
            try
            {
                this.Description = ms_section.Description;
                this.EndRow = ms_section.EndRow;
                this.Id = ms_section.Id;
                this.Section_Name = ms_section.Section_Name;
                this.Section_Number = ms_section.Section_Number;
                this.StartRow = ms_section.StartRow;
                this.SubTotalRow = ms_section.SubTotalRow;

                if (ms_section.Parent != null)
                    this.Parent = ms_section.Parent;

                if (ms_section.Items.Count>0)
                    foreach (var ms_item in ms_section.Items)
                    {
                        var item = ms_item.Clone() as Item_ViewModel;
                        item.Id = Guid.NewGuid().ToString("N");
                        this.Items.Add(item);
                         
                    }
                if(ms_section.Children.Count>0)
                    foreach (var ms_child in ms_section.Children)
                    {
                        var item = ms_child.Clone() as Item_ViewModel;
                        item.Id = Guid.NewGuid().ToString("N");
                        this.Children.Add(item);
                    }

                WireParentsAndChildren();
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex); 
            }
        }

        public string Id { get; set; } = string.Empty;
        public string Section_Name { get; set; } = string.Empty;
        public int Section_Number { get; set; } = -1;
        public string Description { get; set; } = string.Empty;
        public int StartRow { get; set; } = -1;
        public int EndRow { get; set; } = -1;
        public int SubTotalRow { get; set; } = -1;
        public object Parent { get; set; } = null;
        public List<Item_ViewModel> Children { get; set; } = new List<Item_ViewModel>(); 

        public List<Item_ViewModel> Items { get; set; } = new List<Item_ViewModel>();

        public int Total_Items 
        { 
            get
            {
                var total = Items.Count;

                if (Children.Count>0)
                    total += GetChildrenItems(Children);
                return total;
            } 
        }

        private int GetChildrenItems(List<Item_ViewModel> children)
        {
            try
            {
                var total = 0;
                foreach (var child in children)
                {
                    total += 1;
                    if (child.Children.Count>0)
                        total += GetChildrenItems(child.Children); 
                }
                return total;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return 0;
            }
        }

        private void WireParentsAndChildren()
        { 
            try
            {
                if (Section_Name == "EARTHWORKS")
                {
                    string st = string.Empty;
                }
                if (Items == null) return;
                WireSection(this);

                if (Children.Count > 0)
                    foreach (var item_group in Children)
                    {
                        item_group.Parent = null;
                        if (this.Items.Count > 0)
                        {
                            var section_item = this.Items.Find(i => i.ItemNumber == this.Section_Number);
                            if (section_item != null)
                                item_group.Parent = section_item;
                        }
                        if (item_group.Parent == null)
                            item_group.Parent = this;
                        var igrp = item_group;
                        WireItemGroups(ref igrp);
                        if (item_group.Children.Count > 0)
                            foreach (var sub_child in item_group.Children)
                            {
                                var s_chld = sub_child;
                                WireItemGroups(ref s_chld);
                            }
                    }
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex); 
            }
        }

        private void WireSection(Section_Model section)
        {
            try
            {
                var last_item = -1;
                foreach (var item in section.Items)
                {
                    object parent = section;
                    if (item.SubItem == string.Empty)
                    {
                        last_item = item.ItemNumber;
                    }
                    else
                    {
                        parent = section.Items.Find(i => i.ItemNumber == last_item && 
                                                         i.SubItem == string.Empty);
                    }

                    if (parent == null)
                    {
                        var st = string.Empty;
                    }
                    item.Parent = parent;

                    if (parent is Item_ViewModel)
                        ((Item_ViewModel)parent).Children.Add(item); 
                }
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex); 
            } 
        }

        private void WireItemGroups(ref Item_ViewModel group_item)
        {
            try
            {
                var last_item = group_item.ItemNumber;
                foreach (var item in group_item.Children)
                {
                    object parent = group_item;
                    if (item.SubItem == string.Empty)
                    {// this is not a subitem
                        last_item = item.ItemNumber;
                    }
                    else
                    {// the subitem's parent is the item with the same item number
                        if (group_item.ItemNumber!=last_item)
                            parent = group_item.Children.Find(i => i.ItemNumber == last_item && 
                                                                   i.SubItem == string.Empty);
                    }

                    if (parent == null)
                    {
                        var st = string.Empty;
                    }
                    if (item == parent)
                    {
                        var str = string.Empty;
                    }
                    item.Parent = parent;

                    if (parent is Item_ViewModel)
                    {
                        if (!((Item_ViewModel)parent).Children.Exists(itm=>itm == item))
                            ((Item_ViewModel)parent).Children.Add(item);
                    }
                       
                }
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
            }
        }

        public override string ToString()
        {
            return Section_Name;
        } 

        public object Clone()
        {
            var section = new Section_Model
            {
                Id = this.Id,
                Section_Name = this.Section_Name,
                Section_Number = this.Section_Number,
                StartRow = this.StartRow,
                SubTotalRow = this.SubTotalRow
            }; 

            foreach (var item in Items)
            {
                section.Items.Add(item.Clone() as Item_ViewModel);
            }
            return section;
        }
    }
}
