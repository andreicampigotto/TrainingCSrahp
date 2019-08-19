namespace WEBAPIRESTFULL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LivrosAutores
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Livro { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Autor { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCriacao { get; set; }

        public int? IdAlteracao { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime DataCriacao { get; set; }

        public DateTime? DataAlteracao { get; set; }

        public virtual Autores Autores { get; set; }

        public virtual Livros Livros { get; set; }

        public virtual Usuarios Usuarios { get; set; }

        public virtual Usuarios Usuarios1 { get; set; }
    }
}
