using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.Shard
{
    public class BankAccount
    {
        public string AccountName; // instance member, each one has own value
        public decimal Balance; // instatnce member, each one has own value
        public static decimal InterestRate; // shared memeber, everyone has the same value
    }
}
