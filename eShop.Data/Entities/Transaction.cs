using eShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    public class Transaction
    {
		public int Id { get; set; }
	public DateTime TransactionDate {get;set;}
	public int ExtermalTransactionId {get;set;}
	public int Amount {get;set;}
	public bool Free {get;set;}
	public bool Result {get;set;}
	public string Message {get;set;}
	public Status Status {get;set;}
	public int Provider {get;set;}

	}
}
