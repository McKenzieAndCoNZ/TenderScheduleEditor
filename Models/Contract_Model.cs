using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PaymentsScheduleTemplateCreator.Models
{
    public class Contract_Model
    {
        public Contract_Model()
        {

        }
        public Contract_Model(XElement contract_el)
        { 
            if (!string.IsNullOrEmpty(contract_el?.Element("jobNumber")?.Value))
                JobNumber = contract_el.Element("jobNumber").Value;
            if (!string.IsNullOrEmpty(contract_el?.Element("contractTitle")?.Value))
                ContractTitle = contract_el.Element("contractTitle").Value;
            if (!string.IsNullOrEmpty(contract_el?.Element("typeOfWork")?.Value))
                TypeOfWork = contract_el.Element("typeOfWork").Value;
            if (!string.IsNullOrEmpty(contract_el?.Element("client")?.Value))
                Client = contract_el.Element("client").Value;
            if (!string.IsNullOrEmpty(contract_el?.Element("contractor")?.Value))
                Contractor = contract_el.Element("contractor").Value;
            if (!string.IsNullOrEmpty(contract_el?.Element("contractorAddress")?.Value))
                ContractorAddress = contract_el.Element("contractorAddress").Value;
            if (!string.IsNullOrEmpty(contract_el?.Element("contractSite")?.Value))
                ContractorSite = contract_el.Element("contractSite").Value;
            if (!string.IsNullOrEmpty(contract_el?.Element("principal")?.Value))
                Principal = contract_el.Element("principal").Value;
            if (!string.IsNullOrEmpty(contract_el?.Element("principalAddress")?.Value))
                PrincipalAddress = contract_el.Element("principalAddress").Value; 
            if (int.TryParse(contract_el?.Element("progressClaimNo")?.Value, out var progressClaimNo))
                ProgressClaimNo = progressClaimNo; 
            if (int.TryParse(contract_el?.Element("paymentNo")?.Value, out var paymentNo))
                PaymentNo = paymentNo;
        }
        public string JobNumber { get; set; } = string.Empty;
        public string ContractTitle { get; set; } = string.Empty;
        public string TypeOfWork { get; set; } = string.Empty;
        public string Client { get; set; } = string.Empty;
        public string Contractor{ get; set; } = string.Empty;
        public string ContractorAddress { get; set; } = string.Empty;
        public string ContractorSite{ get; set; } = string.Empty;
        public string Principal { get; set; } = string.Empty;
        public string PrincipalAddress { get; set; } = string.Empty;
        public int ProgressClaimNo { get; set; } = 0;
        public int PaymentNo { get; set; } = 0;
    }
}
