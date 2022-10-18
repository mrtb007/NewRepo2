using System;
using System.Collections.Generic;

#nullable disable

namespace HTTPDEMO.ModelEf
{
    public partial class Order
    {
        public string Id { get; set; }
        public string CodeOrder { get; set; }
        public string CodeProduct { get; set; }
        public int Amount { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime DateTimeCreat { get; set; }
    }
}
