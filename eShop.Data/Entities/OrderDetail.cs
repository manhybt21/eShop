using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProdductID{get;set;}

        public string Quantity{get;set;}
        public decimal Price{get;set;}

    }
}
