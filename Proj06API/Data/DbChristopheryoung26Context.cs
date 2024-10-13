using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Proj06API.Data;

public partial class DbChristopheryoung26Context : DbContext
{
    public DbChristopheryoung26Context()
    {
    }

    public DbChristopheryoung26Context(DbContextOptions<DbChristopheryoung26Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Audience> Audiences { get; set; }

    public virtual DbSet<Audiencecategory> Audiencecategories { get; set; }

    public virtual DbSet<Categorizedaudience> Categorizedaudiences { get; set; }

    public virtual DbSet<Categorizedjoke> Categorizedjokes { get; set; }

    public virtual DbSet<Deliveredjoke> Deliveredjokes { get; set; }

    public virtual DbSet<Joke> Jokes { get; set; }

    public virtual DbSet<Jokecategory> Jokecategories { get; set; }

    public virtual DbSet<Jokereactioncategory> Jokereactioncategories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Name=DB_CONN");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Audience>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("audience_pkey");

            entity.ToTable("audience", "dadabase");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Audiencename)
                .HasMaxLength(255)
                .HasColumnName("audiencename");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
        });

        modelBuilder.Entity<Audiencecategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("audiencecategory_pkey");

            entity.ToTable("audiencecategory", "dadabase");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Categoryname)
                .HasMaxLength(255)
                .HasColumnName("categoryname");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
        });

        modelBuilder.Entity<Categorizedaudience>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("categorizedaudience_pkey");

            entity.ToTable("categorizedaudience", "dadabase");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Audiencecategoryid).HasColumnName("audiencecategoryid");
            entity.Property(e => e.Audienceid).HasColumnName("audienceid");

            entity.HasOne(d => d.Audiencecategory).WithMany(p => p.Categorizedaudiences)
                .HasForeignKey(d => d.Audiencecategoryid)
                .HasConstraintName("audiencecategoryid");

            entity.HasOne(d => d.Audience).WithMany(p => p.Categorizedaudiences)
                .HasForeignKey(d => d.Audienceid)
                .HasConstraintName("audienceid");
        });

        modelBuilder.Entity<Categorizedjoke>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("categorizedjoke_pkey");

            entity.ToTable("categorizedjoke", "dadabase");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Jokecategoryid).HasColumnName("jokecategoryid");
            entity.Property(e => e.Jokeid).HasColumnName("jokeid");

            entity.HasOne(d => d.Jokecategory).WithMany(p => p.Categorizedjokes)
                .HasForeignKey(d => d.Jokecategoryid)
                .HasConstraintName("jokecategoryid");

            entity.HasOne(d => d.Joke).WithMany(p => p.Categorizedjokes)
                .HasForeignKey(d => d.Jokeid)
                .HasConstraintName("jokeid");
        });

        modelBuilder.Entity<Deliveredjoke>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("deliveredjoke_pkey");

            entity.ToTable("deliveredjoke", "dadabase");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Audienceid).HasColumnName("audienceid");
            entity.Property(e => e.Delivereddate).HasColumnName("delivereddate");
            entity.Property(e => e.Jokeid).HasColumnName("jokeid");
            entity.Property(e => e.Jokereactionid).HasColumnName("jokereactionid");
            entity.Property(e => e.Notes)
                .HasMaxLength(255)
                .HasColumnName("notes");

            entity.HasOne(d => d.Audience).WithMany(p => p.Deliveredjokes)
                .HasForeignKey(d => d.Audienceid)
                .HasConstraintName("audienceid");

            entity.HasOne(d => d.Joke).WithMany(p => p.Deliveredjokes)
                .HasForeignKey(d => d.Jokeid)
                .HasConstraintName("jokeid");

            entity.HasOne(d => d.Jokereaction).WithMany(p => p.Deliveredjokes)
                .HasForeignKey(d => d.Jokereactionid)
                .HasConstraintName("jokereactionid");
        });

        modelBuilder.Entity<Joke>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("joke_pkey");

            entity.ToTable("joke", "dadabase");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Jokename)
                .HasMaxLength(255)
                .HasColumnName("jokename");
            entity.Property(e => e.Joketext)
                .HasMaxLength(255)
                .HasColumnName("joketext");
        });

        modelBuilder.Entity<Jokecategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("jokecategory_pkey");

            entity.ToTable("jokecategory", "dadabase");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Categoryname)
                .HasMaxLength(255)
                .HasColumnName("categoryname");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
        });

        modelBuilder.Entity<Jokereactioncategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("jokereactioncategory_pkey");

            entity.ToTable("jokereactioncategory", "dadabase");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Reactionlevel)
                .HasMaxLength(255)
                .HasColumnName("reactionlevel");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
