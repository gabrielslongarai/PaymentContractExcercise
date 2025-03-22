using PaymentContractExcercise.Entities;
using System.Diagnostics.Metrics;
using System.Globalization;

namespace PaymentContractExcercise
{
    class Program
    {
        static void Main()
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter contract data: ");

            Console.Write("Contract Number: ");
            int contractNumber = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine());

            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            Contract contract = new(contractNumber, contractDate, contractValue);

            for (int i = 1; i <= installments; i++)
            {
                DateTime dueDate = contract.ContractDate.AddDays(30 * i);
                double amount = contract.ContractValue / installments;

                contract.Installments.Add(new Installment(dueDate, amount));
            }

            Console.WriteLine(contract);

            foreach(var installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }


        }
    }
}