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
                    .Join(db.Tickets,
                          ti => ti.TicketId, 
                          t => t.Id,
                          (ti, t) => new
                          {
                              TicketItem = ti,
                              Ticket = t
                          }).ToList();

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
                    .Join(db.Items,
                          ti => ti.ItemId,
                          i => i.Id,
                          (ti, i) => i)
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

        }
    }
}

