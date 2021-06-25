using System;

namespace Acc
{
    public class Account
    {
        //private variable declared
        private string accName;
        private string acid;
        private int balance;

        //empty constructor
        public Account(){}
        
        //valued constructor
        public Account(string A, string B, int C)
        {
            accName = A;
            acid = B;
            balance = C;
        }

        //properties
        public string Name
        {
            get
            {
                return accName;
            } 
            set
            {
                accName = value;
            }
        }

        public string Id
        {
            get
            {
                return acid;
            } 
            set
            {
                acid = value;
            }
        }

        public int Balance
        {
            get
            {
                return balance;
            } 
            set
            {
                balance = value;
            }
        }

        //deposit function
        public void Deposit(int N)
        {
            //new amount add into balance
            Balance = Balance + N;
        }

        //withdraw function
        public void Withdraw(int N)
        {
            //new amount add into balance
            Balance = Balance - N;
        }

        //Transfer
        public void Transfer(int X, Account receiver)
        {
            if(receiver.Balance > 0)
            {
                if(receiver.Balance >= X)
                {
                    this.Balance = this.Balance + X;
                    receiver.Balance = receiver.Balance - X;

                    Console.WriteLine("Transfer Successfull.");
                    Console.WriteLine("New Balance of "+receiver.Id+" => {0}",receiver.Balance);
                }
                else
                {
                    Console.WriteLine("\nYou do not have enough money.\n");
                }
            }
            
            else
            {
                Console.WriteLine("\nInsufficient Balance.\n");
            }

            Console.WriteLine("\n======================End Program===================================\n");
        }
        
        
    }
}