using System;
using System.Security.Cryptography.X509Certificates;

namespace UnitTesting
{ 
    class Program
    {
        static public decimal Balance = 100.00M;
        static void Main(string[] args)
        {
            Options();
          
                }
         public static decimal ViewBalance()
            {
                Console.WriteLine("This is Your Current Balance:" + Balance);
                return Balance;
            }

            public static decimal Withdraw(decimal withdrawAmount, decimal inputBalance)
            {
                inputBalance = Balance;
                decimal newBalance = Balance - withdrawAmount;
                Balance = newBalance;
                return Balance;
            }

        public static decimal Deposit(decimal depositAmount, decimal inputBalance)
            {
                inputBalance = Balance;
                decimal bigBalance = Balance + depositAmount;
                Balance = bigBalance;
                return Balance;
            }


