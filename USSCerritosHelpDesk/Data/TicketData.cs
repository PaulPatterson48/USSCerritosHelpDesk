using System;
using USSCerritosHelpDesk.Models;


namespace USSCerritosHelpDesk.Data;

public class TicketData
{
	public static List<Ticket> Tickets = new List<Ticket>
	{
		new Ticket
		    {
                Id = 1,
		        Title ="Add Captain Freeman to the Command Console",
		        Description ="Captain Freeman is the new commander of this starship please add her to all command functions",
		        CommentDate = new DateTime (2024, 1,2),
		        UpdateDate = new DateTime (2024, 1, 3),
                StatusId = 1,
		        UserId = 5,
		        AssignedToUserId = 1,
                Priority = "High"
            },

        new Ticket
            {
                Id = 2,
                Title = "Printer not working",
                Description = "The printer in the main office is not printing documents.",
                CommentDate = new DateTime(2024, 5, 2, 10, 0, 0),
                UpdateDate = new DateTime(2024, 5, 2, 10, 30, 0),
                StatusId = 2,
                UserId = 3,
                DepartmentId = 2,
                CategoryId = 2,
                Priority = "Medium",
                AssignedToUserId = 1,
                
            },
        new Ticket
            {
                Id = 3,
                Title = "Cannot connect to VPN",
                Description = "Remote users are unable to connect to the VPN.",
                CommentDate = new DateTime(2024, 5, 3, 11, 0, 0),
                UpdateDate = new DateTime(2024, 5, 3, 11, 30, 0),
                StatusId = 3,
                UserId = 103,
                DepartmentId = 3,
                CategoryId = 3,
                Priority = "High",
                AssignedToUserId = 1
            },
        new Ticket
            {
                Id = 4,
                Title = "Software installation request",
                Description = "Request to install new software on all department computers.",
                CommentDate = new DateTime(2024, 5, 4, 14, 0, 0),
                UpdateDate = new DateTime(2024, 5, 4, 14, 30, 0),
                StatusId = 3,
                UserId = 104,
                DepartmentId = 4,
                CategoryId = 4,
                Priority = "Low",
                AssignedToUserId = 2
            },
        new Ticket
            {
                Id = 5,
                Title = "Network outage",
                Description = "The entire office is experiencing a network outage.",
                CommentDate = new DateTime(2024, 5, 5, 16, 0, 0),
                UpdateDate = new DateTime(2024, 5, 5, 16, 30, 0),
                StatusId = 4,
                UserId = 105,
                DepartmentId = 5,
                CategoryId = 5,
                Priority = "Critical",
                AssignedToUserId = 2
            }
    };
}

