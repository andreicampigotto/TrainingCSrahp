namespace WEBAPIRESTFULL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Locacoes : userControls
    {
        public int Id { get; set; }

        public int Livro { get; set; }

        public int Usuario { get; set; }

        public int Tipo { get; set; }

        public DateTime Devolucao { get; set; }

        public virtual Livros Livros { get; set; }

        public virtual Usuarios Usuarios { get; set; }

        public virtual Usuarios Usuarios1 { get; set; }

        public virtual Usuarios Usuarios2 { get; set; }
    }
}
