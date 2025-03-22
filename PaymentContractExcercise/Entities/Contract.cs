namespace PaymentContractExcercise.Entities
{
    class Contract
    {
        public int ContractNumber { get; set; }
        public DateTime ContractDate { get; set; }
        public double ContractValue { get; set; }
        public List<Installment> Installments { get; set; } = new();

        public Contract(int contractNumber, DateTime contractDate, double contractValue, int installments)
        {
            ContractNumber = contractNumber;
            ContractDate = contractDate;
            ContractValue = contractValue;

            for (int i = 0; i < installments; i++)
            {
                DateTime dueDate = ContractDate.AddDays(30);
                double amount = contractValue / installments;

                Installments.Add(new Installment(dueDate, amount));
            }
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
