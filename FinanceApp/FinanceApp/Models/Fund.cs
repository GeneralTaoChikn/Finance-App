using System;
using System.Collections.Generic;

#nullable disable

namespace FinanceApp.Models
{
    public partial class Fund
    {
        public int IdFunds { get; set; }
        public int? Cash { get; set; }
        public int? Checking { get; set; }
        public int? Savings { get; set; }
        public int? Credit { get; set; }
    }
}
