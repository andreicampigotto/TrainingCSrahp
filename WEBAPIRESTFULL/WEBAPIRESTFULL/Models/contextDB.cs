namespace WEBAPIRESTFULL.Models
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class contextDB : DbContext 
	{
		public contextDB()
			: base("name=contextDB")
		{
		}

		public virtual DbSet<Autores> Autores { get; set; }
		public virtual DbSet<Editoras> Editoras { get; set; }
		public virtual DbSet<Generos> Generos { get; set; }
		public virtual DbSet<Livros> Livros { get; set; }
		public virtual DbSet<Locacoes> Locacoes { get; set; }
		public virtual DbSet<Usuarios> Usuarios { get; set; }
		public virtual DbSet<LivrosAutores> LivrosAutores { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Autores>()
				.Property(e => e.Nome)
				.IsUnicode(false);

			modelBuilder.Entity<Autores>()
				.Property(e => e.Descricao)
				.IsUnicode(false);

			modelBuilder.Entity<Autores>()
				.HasMany(e => e.LivrosAutores)
				.WithRequired(e => e.Autores)
				.HasForeignKey(e => e.Autor)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Editoras>()
				.Property(e => e.Nome)
				.IsUnicode(false);

			modelBuilder.Entity<Editoras>()
				.Property(e => e.Descricao)
				.IsUnicode(false);

			modelBuilder.Entity<Editoras>()
				.HasMany(e => e.Livros)
				.WithRequired(e => e.Editoras)
				.HasForeignKey(e => e.Editora)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Generos>()
				.Property(e => e.Nome)
				.IsUnicode(false);

			modelBuilder.Entity<Generos>()
				.Property(e => e.Descricao)
				.IsUnicode(false);

			modelBuilder.Entity<Generos>()
				.HasMany(e => e.Livros)
				.WithRequired(e => e.Generos)
				.HasForeignKey(e => e.Genero)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Livros>()
				.Property(e => e.Nome)
				.IsUnicode(false);

			modelBuilder.Entity<Livros>()
				.Property(e => e.Descricao)
				.IsUnicode(false);

			modelBuilder.Entity<Livros>()
				.Property(e => e.Isbn)
				.IsUnicode(false);

			modelBuilder.Entity<Livros>()
				.HasMany(e => e.LivrosAutores)
				.WithRequired(e => e.Livros)
				.HasForeignKey(e => e.Livro)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Livros>()
				.HasMany(e => e.Locacoes)
				.WithRequired(e => e.Livros)
				.HasForeignKey(e => e.Livro)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Usuarios>()
				.Property(e => e.Nome)
				.IsUnicode(false);

			modelBuilder.Entity<Usuarios>()
				.Property(e => e.Login)
				.IsUnicode(false);

			modelBuilder.Entity<Usuarios>()
				.Property(e => e.Senha)
				.IsUnicode(false);

			modelBuilder.Entity<Usuarios>()
				.HasMany(e => e.Autores)
				.WithOptional(e => e.Usuarios)
				.HasForeignKey(e => e.IdAlteracao);

			modelBuilder.Entity<Usuarios>()
				.HasMany(e => e.Autores1)
				.WithRequired(e => e.Usuarios1)
				.HasForeignKey(e => e.IdCriacao)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Usuarios>()
				.HasMany(e => e.Editoras)
				.WithOptional(e => e.Usuarios)
				.HasForeignKey(e => e.IdAlteracao);

			modelBuilder.Entity<Usuarios>()
				.HasMany(e => e.Editoras1)
				.WithRequired(e => e.Usuarios1)
				.HasForeignKey(e => e.IdCriacao)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Usuarios>()
				.HasMany(e => e.Generos)
				.WithOptional(e => e.Usuarios)
				.HasForeignKey(e => e.IdAlteracao);

			modelBuilder.Entity<Usuarios>()
				.HasMany(e => e.Generos1)
				.WithRequired(e => e.Usuarios1)
				.HasForeignKey(e => e.IdCriacao)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Usuarios>()
				.HasMany(e => e.Livros)
				.WithOptional(e => e.Usuarios)
				.HasForeignKey(e => e.IdAlteracao);

			modelBuilder.Entity<Usuarios>()
				.HasMany(e => e.Livros1)
				.WithRequired(e => e.Usuarios1)
				.HasForeignKey(e => e.IdCriacao)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Usuarios>()
				.HasMany(e => e.Locacoes)
				.WithOptional(e => e.Usuarios)
				.HasForeignKey(e => e.IdAlteracao);

			modelBuilder.Entity<Usuarios>()
				.HasMany(e => e.Locacoes1)
				.WithRequired(e => e.Usuarios1)
				.HasForeignKey(e => e.IdCriacao)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Usuarios>()
				.HasMany(e => e.Locacoes2)
				.WithRequired(e => e.Usuarios2)
				.HasForeignKey(e => e.Usuario)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Usuarios>()
				.HasMany(e => e.LivrosAutores)
				.WithOptional(e => e.Usuarios)
				.HasForeignKey(e => e.IdAlteracao);

			modelBuilder.Entity<Usuarios>()
				.HasMany(e => e.LivrosAutores1)
				.WithRequired(e => e.Usuarios1)
				.HasForeignKey(e => e.IdCriacao)
				.WillCascadeOnDelete(false);
		}
	}
}
