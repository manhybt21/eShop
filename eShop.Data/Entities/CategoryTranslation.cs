using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    public class CategoryTranslation
    {
		public int Id {get;set;}
	public int CategoryID {get;set;}
	public string Name {get;set;}
	public string SeoDesciption {get;set;}
	public string Seotitle {get;set;}
	public string SeoAlias {get;set;}
	public int LangueId { get; set; }

	}
}
