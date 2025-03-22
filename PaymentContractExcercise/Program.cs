using PaymentContractExcercise.Entities;
using System.Diagnostics.Metrics;
using System.Globalization;

namespace PaymentContractExcercise
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter contract data: ");

            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine());

            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            Contract contract = new(contractNumber, contractDate, contractValue);

        }
    }
}