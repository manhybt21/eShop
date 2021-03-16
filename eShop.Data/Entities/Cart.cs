using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    public class Cart
    {
        public int Id{get;set;}
    public int ProductId{get;set;}

    public string Quantity{get;set;}
    public decimal Price { get; set; }

    }
}
