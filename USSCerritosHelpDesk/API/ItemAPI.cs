using System;
using Microsoft.EntityFrameworkCore;
using USSCerritosHelpDesk.Models;


namespace USSCerritosHelpDesk.API
{
	public static class ItemAPI
	{
		public static void Map(WebApplication app)
		{
			//Get All Items
			app.MapGet("/api/getAllItems", (USSCerritosHelpDeskDbContext db) =>
			{
				return db.Items.ToList();
			});

			//Get a Single Item
			app.MapGet("/api/getSingleItem/{id}", (USSCerritosHelpDeskDbContext db, int id) =>
			{
				var itemId = db.Items.FirstOrDefault(i => i.Id == id);

				if (itemId == null)
				{
					return Results.NotFound("No item matches the criteria");
				}
				return Results.Ok(itemId);
			});

			//Create an Item
			app.MapPost("/api/createItem", (USSCerritosHelpDeskDbContext db, Item newItem) =>
			{
				db.Items.Add(newItem);
				db.SaveChanges();
				return Results.Created($"/api/createItem/{newItem.Id}", newItem);
			});

			//Update an Item
			app.MapPatch("/api/updateItem/{id}", (USSCerritosHelpDeskDbContext db, int id, Item updateItem) =>
			{
				Item itemToUpdate = db.Items.SingleOrDefault(Item => Item.Id == id);

				if (itemToUpdate == null)
				{
					return Results.NotFound("No item matches your criteria.");
				}
				itemToUpdate.ItemName = updateItem.ItemName;
				itemToUpdate.ItemVersion = updateItem.ItemVersion;
				itemToUpdate.ItemImageUrl = updateItem.ItemImageUrl;
				db.SaveChanges();
				return Results.NoContent();

			});

			//Delete an Item
			app.MapDelete("/api/deleteItem/{id}", (USSCerritosHelpDeskDbContext db, int id) =>
			{
				var item = db.Items.Find(id);
				if(item == null)
				{
					return Results.NotFound("No item matches this criteria.");
				}
				db.Items.Remove(item);
				db.SaveChanges();
				return Results.NoContent();
			});

		}
	}
}

