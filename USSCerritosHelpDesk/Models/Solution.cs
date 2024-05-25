using System;
using System.ComponentModel.DataAnnotations;
namespace USSCerritosHelpDesk.Models;

public class Solution
{
	public int Id { get; set; }
	[Required]
	public int TicketId { get; set; }
	public Ticket Tickets { get; set; }
	public DateTime SolveDate { get; set; }
}

