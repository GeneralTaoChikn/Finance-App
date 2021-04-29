using System;
using System.Collections.Generic;

#nullable disable

namespace FinanceApp.Models
{
    public partial class Transaction
    {
        public string TransactionId { get; set; }
        public string UserId { get; set; }
        public string Type { get; set; }
        public int? Amount { get; set; }
    }
}
