using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_Assessment_2_Sean_Coster_5068788
{
    public class WithdrawalException : Exception
    {
        public WithdrawalException(string accountType, double amount, double balance)
            : base(BuildMessage(accountType, amount, balance))
        { }

        private static string BuildMessage(string accountType, double amount, double balance)
        {
            string baseMessage = $"{accountType} account: Failed to withdraw ${amount}. Insufficient funds. Current balance: ${balance}";

            switch (accountType)
            {
                case "Everyday":
                    return baseMessage + " Please ensure you have enough balance in your Everyday account.";
                case "Investment":
                    return baseMessage + " A failed transaction fee was applied to your account.";
                case "Omni":
                    return baseMessage + " A failed transaction fee was applied to your account.";
                default:
                    return baseMessage;
            }
        }
    }
}
