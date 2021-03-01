using ComponentFactory.Krypton.Toolkit;
using PaymentsScheduleTemplateCreator.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentsScheduleTemplateCreator.Forms.FrmAddSectionItem
{
    public partial class FrmAddSectionItem : KryptonForm
    {
        public delegate void ItemAddedEventHandler(object source, ItemAddedEventArgs args);
        public event ItemAddedEventHandler ItemAdded;

        public FrmAddSectionItem()
        {
            InitializeComponent();
        }

        private void FrmAddSectionItem_Load(object sender, EventArgs e)
        {

        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            OnItemAdded();
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        protected virtual void OnItemAdded()
        {
            if (ItemAdded != null)
                ItemAdded(this, new ItemAddedEventArgs
                {
                    Item_No = TxtItemNo.Text,
                    SubItem_No = TxtSubItem.Text,
                    Description = TxtDescription.Text,
                    Units = TxtUnits.Text,
                    Qty = TxtQty.Text,
                    Comments = TxtComment.Text,
                    Parent_ListView = this.Tag as ListView
                }) ;
        }
    }
}
