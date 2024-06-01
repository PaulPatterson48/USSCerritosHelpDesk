using System;
using Microsoft.EntityFrameworkCore;
using USSCerritosHelpDesk.Models;

namespace USSCerritosHelpDesk.API
{
	public class TicketItemAPI
	{
		public static void Map(WebApplication app)
		{
			app.MapGet("/api/getAllTicketItems", (USSCerritosHelpDeskDbContext db) =>
			{
				return db.TicketItems.ToList();
			});
            // Get all Tickets for Single User
           
            app.MapGet("/api/getAllTicketsForSingleUser/{userId}", (USSCerritosHelpDeskDbContext db, int userId) =>
            {
                // Retrieve the tickets for the specified user
                var userTickets = db.TicketItems
                    .Where(ti => ti.UserId == userId)
                    .Include(userId => userId.Item)
                    .ToList();

                // Check if there are no tickets for the user
                if (userTickets == null || !userTickets.Any())
                {
                    return Results.NotFound("No Tickets for this User.");
                }

                // Return the list of user tickets
                return Results.Ok(userTickets);
            });

            //Get All tickets assoicated with an Item            
            app.MapGet("/api/getAllItemsForSingleTicket/{ticketId}", (USSCerritosHelpDeskDbContext db, int ticketId) =>
            {
                // Retrieve the items for the specified ticket
                var ticketItems = db.TicketItems
                    .Where(ti => ti.TicketId == ticketId)
                    .Include(ticketId => ticketId.Item)
                    .ToList();


                // Check if there are no items for the ticket
                if (ticketItems == null || !ticketItems.Any())
                {
                    return Results.NotFound("No Items for this Ticket.");
                }

                // Return the list of items
                return Results.Ok(ticketItems);
            });

            // Add a new Ticket and assign it to a user
            app.MapPost("/api/addTicketToUser", async (USSCerritosHelpDeskDbContext db, Ticket request) =>
            {
                // Validate the incoming request
                if (request == null || request.AssignedToUserId == 0 || string.IsNullOrWhiteSpace(request.Title))
                {
                    return Results.BadRequest("Invalid ticket request data.");
                }

                // Create a new ticket
                var newTicket = new Ticket
                {
                    Title = request.Title,
                    Description = request.Description,
                    AssignedToUserId = request.AssignedToUserId,
                    DateCreated = DateTime.UtcNow,
                    StatusId = 1 // Assuming default status is "New"
                };

                // Add the new ticket to the database
                db.Tickets.Add(newTicket);
                await db.SaveChangesAsync();

                // Return the created ticket
                return Results.Created($"/api/getTicket/{newTicket.Id}", newTicket);
            });

            // Delete all Tickets for a User
            app.MapDelete("/api/deleteAllTicketsForUser/{userId}", async (USSCerritosHelpDeskDbContext db, int userId) =>
            {
                // Retrieve all tickets associated with the specified user
                var userTickets = db.Tickets
                    .Where(t => t.AssignedToUserId == userId)
                    .ToList();

                // Check if there are no tickets for the user
                if (userTickets == null || !userTickets.Any())
                {
                    return Results.NotFound("No tickets found for the specified user.");
                }

                // Delete all the tickets
                db.Tickets.RemoveRange(userTickets);
                await db.SaveChangesAsync();

                // Return a success message
                return Results.Ok("All tickets for the user have been deleted.");
            });
            // Update a Ticket for a Single User
            app.MapPut("/api/updateTicketForUser/{userId}/{ticketId}", async (USSCerritosHelpDeskDbContext db, int userId, int ticketId, Ticket request) =>
            {
                // Validate the incoming request
                if (request == null || string.IsNullOrWhiteSpace(request.Title))
                {
                    return Results.BadRequest("Invalid ticket update data.");
                }

                // Retrieve the ticket by ticketId
                var ticket = await db.Tickets.FirstOrDefaultAsync(t => t.Id == ticketId && t.AssignedToUserId == userId);

                // Check if the ticket exists and belongs to the specified user
                if (ticket == null)
                {
                    return Results.NotFound("Ticket not found for the specified user.");
                }

                // Update the ticket details
                ticket.Title = request.Title;
                ticket.Description = request.Description;
                ticket.StatusId = request.StatusId;

                // Save the changes to the database
                await db.SaveChangesAsync();

                // Return the updated ticket
                return Results.Ok(ticket);
            });

            // Add a new TicketItem
            app.MapPost("/api/createTicketItem", async (USSCerritosHelpDeskDbContext db, TicketItem request) =>
            {
                // Validate the incoming request
                if (request == null || request.TicketId == 0 || request.ItemId == 0 || request.UserId == 0)
                {
                    return Results.BadRequest("Invalid ticket item request data.");
                }

                // Create a new ticket item
                var newTicketItem = new TicketItem
                {
                    TicketId = request.TicketId,
                    ItemId = request.ItemId,
                    UserId = request.UserId,
                   
                    
                };

                // Add the new ticket item to the database
                db.TicketItems.Add(newTicketItem);
                await db.SaveChangesAsync();

                // Return the created ticket item
                return Results.Created($"/api/getTicketItem/{newTicketItem.Id}", newTicketItem);
            });

            app.MapDelete("/api/deleteTicketItem/{ticketItemId}", async (USSCerritosHelpDeskDbContext db, int ticketItemId) =>
            {
                // Find the ticket item by its ID
                var ticketItem = await db.TicketItems.FindAsync(ticketItemId);

                // Check if the ticket item exists
                if (ticketItem == null)
                {
                    return Results.NotFound("Ticket item not found.");
                }

                // Remove the ticket item from the database
                db.TicketItems.Remove(ticketItem);
                await db.SaveChangesAsync();

                // Return a success message
                return Results.Ok("Ticket item deleted successfully.");
            });
        }
    }
}

