namespace WEBAPIRESTFULL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Livros : userControls
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Livros()
        {
            LivrosAutores = new HashSet<LivrosAutores>();
            Locacoes = new HashSet<Locacoes>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string Nome { get; set; }

        [Required]
        [StringLength(1024)]
        public string Descricao { get; set; }

        [Required]
        [StringLength(17)]
        public string Isbn { get; set; }

        public int Genero { get; set; }

        public int Editora { get; set; }

        public virtual Editoras Editoras { get; set; }

        public virtual Generos Generos { get; set; }

        public virtual Usuarios Usuarios { get; set; }

        public virtual Usuarios Usuarios1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LivrosAutores> LivrosAutores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Locacoes> Locacoes { get; set; }
    }
}
