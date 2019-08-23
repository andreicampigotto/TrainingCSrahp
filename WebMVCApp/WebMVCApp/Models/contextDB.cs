using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebMVCApp.Models
{
	public class ContextDB : DbContext
	{
		public DbSet<Pessoa> pessoas { get; set; }
	}
}