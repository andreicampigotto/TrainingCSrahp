using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVCApp.Models
{
	public class UserControls
	{
		public bool Ativo { get; set; } = true;
		public int UsuarioCriacao { get; set; } = 0;
		public int UsuarioEdicao { get; set; } = 0;
		public DateTime DataCriacao { get; set; } = DateTime.Now;
		public DateTime DataEdicao { get; set; } = DateTime.Now;


	}
}