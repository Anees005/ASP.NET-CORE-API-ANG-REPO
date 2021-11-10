using Demo_Angular_Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
//using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;


namespace Demo_Angular_Core.Data
{
    public class FootballDbContext : DbContext
    {
        public FootballDbContext(DbContextOptions<FootballDbContext> options)
            : base(options)
        {

        }

        public DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>().HasData(
                new Player() { Id = 1, Name = "C. Ronaldo", ShirtNo = 7, Appearances = 500, Goals = 54, Position = PlayerPosition.Forward },
                new Player() { Id = 2, Name = "Paul Pogba", ShirtNo = 6, Appearances = 285, Goals = 28, Position = PlayerPosition.Midfielder },
                new Player() { Id = 3, Name = "David de Gea", ShirtNo = 2, Appearances = 335, Goals = 33, Position = PlayerPosition.Goalkeeper },
                new Player() { Id = 4, Name = "Phil Jones", ShirtNo = 5, Appearances = 200, Goals = 25, Position = PlayerPosition.Defender },
                new Player() { Id = 5, Name = "Lionel Messi", ShirtNo = 8, Appearances = 430, Goals = 50, Position = PlayerPosition.Striker }
            );
        }
    }
}