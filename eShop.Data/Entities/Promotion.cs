using eShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    public class Promotion
    {
		public int Id { get; set; }
	public DateTime FromDate{get;set;}
	public DateTime ToDate{get;set;}
	public bool ApplyForALL{get;set;}
	public int DiscountPercent{get;set;}
	public int DiscountAmount{get;set;}
	public int Productisds{get;set;}
	public int ProductCategoryIds{get;set;}
	public Status Status{get;set;}
	public string Name{get;set;}


	}
}
