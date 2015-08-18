namespace _2.BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class MainClass
    {
        static void Main()
        {
            Console.WriteLine("Before using deposit and withdraw: ");

            Bank PostBank = new Bank("Post Bank");

            Deposit PSB = new Deposit(new Company("PSB"), 1200, 0.5M);
            PostBank.AddAccount(PSB);
            PostBank.AddAccount(new Deposit(new Individuals("Fouk Moralez"), 200, 0.7M));
            PSB.WithdrawMoney(500);

            Mortgage PacksIT = new Mortgage(new Company("PacksIT"), 50000, 0.7M);
            PostBank.AddAccount(PacksIT);
            PostBank.AddAccount(new Mortgage(new Individuals("Anjelica Jhones"), 5000, 0.2M));
            PacksIT.DepositMoney(120);

            PostBank.AddAccount(new Loan(new Company("underground"), 120000005, 0.1M));
            PostBank.AddAccount(new Loan(new Individuals("Frank Perez"), 125, 0.7M));

            Console.WriteLine(PostBank.ToString());
            Console.WriteLine("PSB Calculating Interest: " + PSB.CalculateInterest(24));

            Console.WriteLine("After using deposit and withdraw: ");
            Console.WriteLine();
            Console.WriteLine(PostBank.ToString());
        }
    }
}
