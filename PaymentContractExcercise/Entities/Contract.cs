namespace PaymentContractExcercise.Entities
{
    class Contract
    {
        public int ContractNumber { get; set; }
        public DateTime ContractDate { get; set; }
        public double ContractValue { get; set; }
        public List<Installment> Installments { get; set; } = new();

        public Contract(int contractNumber, DateTime contractDate, double contractValue)
        {
            ContractNumber = contractNumber;
            ContractDate = contractDate;
            ContractValue = contractValue;
        }

        public override string ToString()
        {
            return $"\nContract Number {ContractNumber}" +
                   $"\nContract Date: {ContractDate.ToString("dd/MM/yyyy")}" +
                   $"\nContract Value {ContractValue:F2}" +
                   $"\nInstallments Quantity {Installments.Count}";
        }
    }
}
