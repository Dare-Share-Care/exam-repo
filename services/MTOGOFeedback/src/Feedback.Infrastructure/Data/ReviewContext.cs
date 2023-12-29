﻿using Feedback.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Feedback.Infrastructure.Data;

public class ReviewContext : DbContext
{
    public DbSet<ReviewEntity> Reviews { get; set; }
    
    
    
    public ReviewContext(DbContextOptions<ReviewContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Primary keys
        
        modelBuilder.Entity<ReviewEntity>().HasKey(x => x.Id);

        


    }
}