using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WEBAPIRESTFULL.Models;
using WEBAPIRESTFULL.Utils;

namespace WEBAPIRESTFULL.Controllers
{
	public class MathFile : Single<MathFile>
	{
		contextDB bibliotecacontextDB = new contextDB();
		public int QuantidadeUsuarios()
		{
			return bibliotecacontextDB
				.Usuarios.Count();
		}
	}
}