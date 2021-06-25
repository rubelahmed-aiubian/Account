using System;

namespace Acc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n======== Account Management ========\n");
            string A;
            string B;
            int C;
            
            //user input info
            Console.WriteLine("Enter Account Holder Name: ");
            A = Console.ReadLine();

            Console.WriteLine("Enter Account Number: ");
            B = Console.ReadLine();

            Console.WriteLine("Enter Balance: ");
            C = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\n=========================================================\n");

            //object call

            Account ABC = new Account(A,B,C);
            Account BCD = new Account("Temporary Person", "12345", 10000);

            //show info
            Console.WriteLine("Account Holder Name: "+ABC.Name+ " => Account Number: "+ABC.Id+" => Account Balance: {0}",ABC.Balance);
            Console.WriteLine("\n=========================================================\n");

            Console.WriteLine("Account Holder Name: "+BCD.Name+ " => Account Number: "+BCD.Id+" => Account Balance: {0}",BCD.Balance);
            Console.WriteLine("\n=========================================================\n");

            //deposit

            Console.WriteLine("\n======== Deposit Balance ========\n");
            int D;
            Console.WriteLine("Enter amount you want to deposit: ");
            D = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("------- Account Number: "+ABC.Id+ ", Current Balance: {0}--------",ABC.Balance);
            Console.WriteLine("\nYou deposited: {0}\n",D);

            ABC.Deposit(D);

            Console.WriteLine("New Balance: {0}",ABC.Balance);
            Console.WriteLine("\n=========================================================\n");

            //withdraw

            Console.WriteLine("\n======== Withdraw Balance ========\n");
            int W;
            Console.WriteLine("Enter amount you want to withdraw: ");
            W = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("------- Account Number: "+ABC.Id+ ", Current Balance: {0}--------",ABC.Balance);
            Console.WriteLine("\nYou have withdrawn: {0}\n",W);

            ABC.Withdraw(W);

            Console.WriteLine("New Balance: {0}",ABC.Balance);
            Console.WriteLine("\n=========================================================\n");

            //Transfer

            Console.WriteLine("\n======== Balance Transfer ========\n");
            int T;
            Console.WriteLine("Enter amount you want to transfer: ");
            T = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n------- Targeted Account Number: "+ABC.Id+" Transfer From: "+BCD.Id+", Transfer Amount: {0}--------\n",T);

            //Transfer object 
            ABC.Transfer(T, BCD);
            
        }
    }
}
