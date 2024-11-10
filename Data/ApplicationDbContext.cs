using Microsoft.EntityFrameworkCore;
using DynamicQuestionApp.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Collections.Generic;
using System.Text.Json;
using System.Reflection.Emit;

namespace DynamicQuestionApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Question> Questions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Question>().HasData(
                new Question
                {
                    Id = 1,
                    Text = "What is the capital of France?",
                    Options = new List<string> { "Paris", "London", "Berlin", "Rome" },
                    Answer = "Paris" 
                },
                new Question
                {
                    Id = 2,
                    Text = "What is the currency of China?",
                    Options = new List<string> { "Yuan", "Yen", "Dollar", "Taka" },
                    Answer = "Yuan"
                },
                new Question
                {
                    Id = 3,
                    Text = "What is the largest rainforest in the world?",
                    Options = new List<string> { "Amazon", "Sundarbans", "Black Forest", "Africa" },
                    Answer = "Amazon"
                },
                new Question
                {
                    Id = 4,
                    Text = "What is the capital of Saudi Arabia?",
                    Options = new List<string> { "Zedda", "Riyadh", "Mecca", "Medina" },
                    Answer = "Riyadh"
                },
                new Question
                {
                    Id = 5,
                    Text = "What is the capital of UK?",
                    Options = new List<string> { "Delhi", "London", "Berlin", "Rome" },
                    Answer = "London"
                },

                new Question
                {
                    Id = 6,
                    Text = "Which planet is known as the Red Planet?",
                    Options = new List<string> { "Earth", "Mars", "Jupiter", "Saturn" },
                    Answer = "Mars"
                }
            );
        
    }

    }
}
