namespace WpfAppBla.Data
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class Model1 : DbContext
	{
		public Model1()
			: base("name=Model1")
		{
		}

		public virtual DbSet<Autore> Autores { get; set; }
		public virtual DbSet<Editora> Editoras { get; set; }
		public virtual DbSet<Genero> Generos { get; set; }
		public virtual DbSet<Livro> Livros { get; set; }
		public virtual DbSet<Usuario> Usuarios { get; set; }
		public virtual DbSet<LivrosAutore> LivrosAutores { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Autore>()
				.Property(e => e.Nome)
				.IsUnicode(false);

			modelBuilder.Entity<Autore>()
				.Property(e => e.Descricao)
				.IsUnicode(false);

			modelBuilder.Entity<Autore>()
				.HasMany(e => e.LivrosAutores)
				.WithRequired(e => e.Autore)
				.HasForeignKey(e => e.Autor)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Editora>()
				.Property(e => e.Nome)
				.IsUnicode(false);

			modelBuilder.Entity<Editora>()
				.Property(e => e.Descricao)
				.IsUnicode(false);

			modelBuilder.Entity<Editora>()
				.HasMany(e => e.Livros)
				.WithRequired(e => e.Editora1)
				.HasForeignKey(e => e.Editora)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Genero>()
				.Property(e => e.Nome)
				.IsUnicode(false);

			modelBuilder.Entity<Genero>()
				.Property(e => e.Descricao)
				.IsUnicode(false);

			modelBuilder.Entity<Genero>()
				.HasMany(e => e.Livros)
				.WithRequired(e => e.Genero1)
				.HasForeignKey(e => e.Genero)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Livro>()
				.Property(e => e.Nome)
				.IsUnicode(false);

			modelBuilder.Entity<Livro>()
				.Property(e => e.Descricao)
				.IsUnicode(false);

			modelBuilder.Entity<Livro>()
				.Property(e => e.Isbn)
				.IsUnicode(false);

			modelBuilder.Entity<Livro>()
				.HasMany(e => e.LivrosAutores)
				.WithRequired(e => e.Livro1)
				.HasForeignKey(e => e.Livro)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Usuario>()
				.Property(e => e.Nome)
				.IsUnicode(false);

			modelBuilder.Entity<Usuario>()
				.Property(e => e.Login)
				.IsUnicode(false);

			modelBuilder.Entity<Usuario>()
				.Property(e => e.Senha)
				.IsUnicode(false);

			modelBuilder.Entity<Usuario>()
				.HasMany(e => e.Autores)
				.WithOptional(e => e.Usuario)
				.HasForeignKey(e => e.IdAlteracao);

			modelBuilder.Entity<Usuario>()
				.HasMany(e => e.Autores1)
				.WithRequired(e => e.Usuario1)
				.HasForeignKey(e => e.IdCriacao)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Usuario>()
				.HasMany(e => e.Editoras)
				.WithOptional(e => e.Usuario)
				.HasForeignKey(e => e.IdAlteracao);

			modelBuilder.Entity<Usuario>()
				.HasMany(e => e.Editoras1)
				.WithRequired(e => e.Usuario1)
				.HasForeignKey(e => e.IdCriacao)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Usuario>()
				.HasMany(e => e.Generos)
				.WithOptional(e => e.Usuario)
				.HasForeignKey(e => e.IdAlteracao);

			modelBuilder.Entity<Usuario>()
				.HasMany(e => e.Generos1)
				.WithRequired(e => e.Usuario1)
				.HasForeignKey(e => e.IdCriacao)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Usuario>()
				.HasMany(e => e.Livros)
				.WithOptional(e => e.Usuario)
				.HasForeignKey(e => e.IdAlteracao);

			modelBuilder.Entity<Usuario>()
				.HasMany(e => e.Livros1)
				.WithRequired(e => e.Usuario1)
				.HasForeignKey(e => e.IdCriacao)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Usuario>()
				.HasMany(e => e.LivrosAutores)
				.WithOptional(e => e.Usuario)
				.HasForeignKey(e => e.IdAlteracao);

			modelBuilder.Entity<Usuario>()
				.HasMany(e => e.LivrosAutores1)
				.WithRequired(e => e.Usuario1)
				.HasForeignKey(e => e.IdCriacao)
				.WillCascadeOnDelete(false);
		}
	}
}
