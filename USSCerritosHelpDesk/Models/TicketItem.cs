using System;
using System.ComponentModel.DataAnnotations;

namespace USSCerritosHelpDesk.Models;

public class TicketItem
{
	public int Id { get; set; }
	[Required]
	public int TicketId { get; set; }
	public int UserId { get; set; }
    public int ItemId { get; set; }
}

