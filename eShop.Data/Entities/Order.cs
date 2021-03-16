using eShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    public class Order
    {
		public int ID { get; set; }
	public DateTime OrderDate{get;set;}
	public int UsersId{get;set;}
	public string ShipName{get;set;}
	public string ShipAddress{get;set;}
	public string ShipEmail{get;set;}
	public int ShipPhoneNumber{get;set;}
	public Status Status{get;set;}


	}
}
