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
			db.Users.Ad(newUser);
			db.SaveChanges();

            return Results.Created($"/api/createUser/{newUser}", newUser);
		});
	}
}

