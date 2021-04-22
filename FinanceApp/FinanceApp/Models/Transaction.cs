using System;
using System.Collections.Generic;

#nullable disable

namespace FinanceApp.Models
{
    public partial class Transaction
    {
        public int TransactionSet { get; set; }
        public int? TransactionId { get; set; }
        public string Type { get; set; }
        public int? Amount { get; set; }
    }
}
