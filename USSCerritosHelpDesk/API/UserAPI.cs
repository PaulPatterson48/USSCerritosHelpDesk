using System;
using USSCerritosHelpDesk.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace USSCerritosHelpDesk.API;

public static class UserAPI
{
	public static void Map(WebApplication app)
	{
		app.MapPost("/api/createUser", (USSCerritosHelpDeskDbContext db, User newUser) =>
		{
			db.Users.Add(newUser);
			db.SaveChanges();

            return Results.Created($"/api/createUser/{newUser}", newUser);
		});

		app.MapGet("/api/getAllUsers", (USSCerritosHelpDeskDbContext db) =>
		{
			return db.Users.ToList();
		});

		app.MapGet("/api/getSingleUser/{id}", (USSCerritosHelpDeskDbContext db, int id) =>
		{
			var UserId = db.Users.FirstOrDefault(u => u.Id == id);

			if (UserId == null)
			{
				return Results.NotFound("User Not Found.");
			}
			return Results.Ok(UserId);
		});

		app.MapPatch("/api/updateUser/{id}", (USSCerritosHelpDeskDbContext db, int id, User updateUser) =>
		{
			User userToUpdate = db.Users.SingleOrDefault(User => User.Id == id);
			if (userToUpdate == null)
			{
				return Results.NotFound("No Current User by that Name.");
			}
			userToUpdate.FirstName = updateUser.FirstName;
			userToUpdate.LastName = updateUser.LastName;
			userToUpdate.Role = updateUser.Role;
			userToUpdate.DepartmentId = updateUser.DepartmentId;
			db.SaveChanges();
			return Results.NoContent();

		});
		app.MapPost("/api/createUser", (USSCerritosHelpDeskDbContext db, User newUser) =>
		{
			db.Users.Add(newUser);
			db.SaveChanges();
			return Results.Created($"/api/createUser/{newUser.Id}", newUser);
		});
	}
}

