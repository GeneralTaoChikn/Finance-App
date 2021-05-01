using System;
using System.Collections.Generic;

#nullable disable

namespace FinanceApp.Models
{
    public partial class Fund
    {
        public string FundsId { get; set; }
        public string UserId { get; set; }
        public int? Cash { get; set; }
        public int? Checking { get; set; }
        public int? Savings { get; set; }
        public int? Credit { get; set; }
    }
}
