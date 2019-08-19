namespace WEBAPIRESTFULL.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Autores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Autores()
        {
            LivrosAutores = new HashSet<LivrosAutores>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(64)]
        public string Nome { get; set; }

        [Required]
        [StringLength(512)]
        public string Descricao { get; set; }

        public bool Ativo { get; set; }

        public int IdCriacao { get; set; }

        public int? IdAlteracao { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime? DataAlteracao { get; set; }

        public virtual Usuarios Usuarios { get; set; }

        public virtual Usuarios Usuarios1 { get; set; }

		[JsonIgnore]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LivrosAutores> LivrosAutores { get; set; }
    }
}
