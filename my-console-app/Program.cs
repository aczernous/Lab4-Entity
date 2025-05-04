using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyConsoleApp;

namespace MyConsoleApp
{
    public class Engine 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Engine () {}
        public Engine (string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return $"Engine: {Name}";
        }
    }
    public class Car 
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Car () {}
        public Car (string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }
        public override string ToString()
        {
            return $"Car: {Model}, {Engine}";
        }
    }

    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Engine> Engines { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}