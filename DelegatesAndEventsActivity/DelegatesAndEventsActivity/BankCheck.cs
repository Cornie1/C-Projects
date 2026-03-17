using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndEventsActivity
{
    public delegate void BalanceAlert(string message);
    internal class BankCheck
    {
        public event BalanceAlert OnLowBalance;
        public void CheckBalance(double CheckBalance)
        {
            Console.WriteLine($"Current Balance: {CheckBalance}");
            if (CheckBalance < 100)
            {
                OnLowBalance?.Invoke("Warning You ARE BROKE!");

            }
        }
    }
}
