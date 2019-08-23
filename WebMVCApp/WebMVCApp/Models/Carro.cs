using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMVCApp.Models
{
	public class Carro : UserControls
	{
		[Key]
		public int Id { get; set; }
		public string Plca { get; set; }
	}
}