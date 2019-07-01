using RESTapi.Data.Entities.Base;
using RESTapi.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RESTapi.Data.Entities
{
    public class Data : EntityBase<int>
    {
        public string Branch { get; set; }
        public PhaseOfContract PhaseOfContract { get; set; }
        public ContractStatus ContractStatus { get; set; }
        public string TypeOfContract { get; set; }
        public string ContractSubtype { get; set; }
        public OwnershipType OwnershipType { get; set; }
        public string PurposeOfFinancing { get; set; }
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
        public int TotalAmountId { get; set; }
        public TotalAmount TotalAmount { get; set; }
        public DateTime NextPaymentDate { get; set; }
        public int TotalMontlyPaymentId { get; set; }
        public TotalMontlyPayment TotalMontlyPayment { get; set; }
        public int? PaymentPeriodicity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime RestructuringDate { get; set; }
        public DateTime ExpectedEndDate { get; set; }
        public DateTime? RealEndDate { get; set; }
        public int? NegativeStatusOfContract { get; set; }
        public int? ProloginationAmountId { get; set; }
        public ProlongationAmount ProlongationAmount { get; set; }
        public DateTime ProlongationDate { get; set; }
    }
}
