using Levva.newbie.coins.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Levva.newbie.coins.Data
{
    public class Context : DbContext
    {
        public DbSet<User> User {get; set;}
        public DbSet<Transaction> Transaction {get; set;}
        public DbSet<Category> Category {get; set;}

        public Context(DbContextOptions<Context> options) : base(options){

        }
    }
}