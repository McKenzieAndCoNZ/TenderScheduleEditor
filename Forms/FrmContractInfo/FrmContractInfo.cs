using ComponentFactory.Krypton.Toolkit;
using PaymentsScheduleTemplateCreator.Helper;
using PaymentsScheduleTemplateCreator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentsScheduleTemplateCreator.Forms.FrmContractInfo
{
    public partial class FrmContractInfo : KryptonForm
    {
        public FrmContractInfo()
        {
            InitializeComponent();
        }

        private void FrmContractInfo_Load(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var payment_no = 0;
                var claim_no = 0;

                if (int.TryParse(TxtPaymentNo.Text, out var pay_no))
                    payment_no = pay_no;

                if (int.TryParse(TxtPaymentNo.Text, out var claim))
                    claim_no = claim;

                var contract_info = new Contract_Model
                {
                    Client = TxtClient.Text,
                    ContractorAddress = TxtContractorsAddress.Text,
                    ContractTitle = TxtContractTitle.Text,
                    JobNumber = TxtJobNumber.Text,
                    PaymentNo = payment_no,
                    Principal = TxtPrinciple.Text,
                    PrincipalAddress = TxtPrincipalsAddress.Text,
                    ProgressClaimNo = claim_no,
                    TypeOfWork = TxtTypeOfWork.Text
                };

                // save to project file

            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                throw;
            }
           
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
