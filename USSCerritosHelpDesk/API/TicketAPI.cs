using System;
using Microsoft.EntityFrameworkCore;
using USSCerritosHelpDesk.Models;

namespace USSCerritosHelpDesk.API
{
	public static class TicketAPI
	{
		public static void Map(WebApplication app)			
		{
			//Get All Tickets
			app.MapGet("/api/getAllTickets", (USSCerritosHelpDeskDbContext db) =>
			{
				return db.Tickets.ToList();
			});

			//Create a Ticket
			app.MapPost("/api/createTicket", (USSCerritosHelpDeskDbContext db, Ticket newTicket) =>
			{
				db.Tickets.Add(newTicket);
				db.SaveChanges();
				return Results.Created($"/api/createTicket/{newTicket.Id}", newTicket);
			});

			//Get Single Ticket
			app.MapGet("/api/getSingleTicket/{id}", (USSCerritosHelpDeskDbContext db, int id) =>
			{
				var TicketId = db.Tickets.FirstOrDefault(t => t.Id == id);

				if (TicketId == null)
				{
					return Results.NotFound("No tickets match your criteria.");
				}
				return Results.Ok(TicketId);
			});

			//Update Ticket
			app.MapPatch("/api/updateTicket/{id}", (USSCerritosHelpDeskDbContext db, int id, Ticket updateTicket) =>
			{
				Ticket ticketToUpdate = db.Tickets.SingleOrDefault(Ticket => Ticket.Id == id);

				if (ticketToUpdate == null)
				{
					return Results.NotFound("The specified ticket is not found.");
				}

				ticketToUpdate.Title = updateTicket.Title;
				ticketToUpdate.Priority = updateTicket.Priority;
				ticketToUpdate.AssignedToUserId = updateTicket.AssignedToUserId;
				ticketToUpdate.Description = updateTicket.Description;
				ticketToUpdate.StatusId = updateTicket.StatusId;
				db.SaveChanges();
				return Results.NoContent();
			});
			//Delete a Ticket
			app.MapDelete("/api/deleteTicket/{id}", (USSCerritosHelpDeskDbContext db, int id) =>
			{
				var ticket = db.Tickets.Find(id);
				if (ticket == null)
				{
					return Results.NotFound("No ticket matches this criteria");
				}
				db.Tickets.Remove(ticket);
				db.SaveChanges();
                return Results.NoContent();
			});
		}
	}
}

