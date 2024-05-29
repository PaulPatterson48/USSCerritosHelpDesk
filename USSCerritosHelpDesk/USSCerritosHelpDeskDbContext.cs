using System;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.Extensions.Hosting;
using USSCerritosHelpDesk.Data;
using USSCerritosHelpDesk.Models;

public class USSCerritosHelpDeskDbContext : DbContext
{
    public DbSet<Item> Items { get; set; }
    public DbSet<Solution> Solutions { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<TicketItem> TicketItems { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Status> Statuses { get; set; }
    public DbSet<Department> Departments { get; set; }
   

    public USSCerritosHelpDeskDbContext(DbContextOptions<USSCerritosHelpDeskDbContext> options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Item>().HasData(ItemData.Items);
        modelBuilder.Entity<Category>().HasData(CategoryData.Categories);
        modelBuilder.Entity<Status>().HasData(StatusData.Statuses);
        modelBuilder.Entity<Department>().HasData(DepartmentData.Departments);
        modelBuilder.Entity<Ticket>().HasData(TicketData.Tickets);
        modelBuilder.Entity<User>().HasData(UserData.Users);
        modelBuilder.Entity<Solution>().HasData(SolutionData.Solutions);
        modelBuilder.Entity<TicketItem>().HasData(TicketItemData.TicketItems);
    }
}

