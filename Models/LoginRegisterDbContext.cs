using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FurntureWebAPP_ASP_NET_CORE_MVC.Models;

public partial class LoginRegisterDbContext : DbContext
{
    public LoginRegisterDbContext()
    {
    }

    public LoginRegisterDbContext(DbContextOptions<LoginRegisterDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<UserTbl> UserTbls { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { 
        if(!optionsBuilder.IsConfigured)
        {
                                                                                                                                                                                                                                                                                                                                                                                                                            
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserTbl>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("User_tbl");

            entity.Property(e => e.ConfirmPassword)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}


