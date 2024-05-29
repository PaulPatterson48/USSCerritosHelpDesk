using System;
using System.ComponentModel.DataAnnotations;

namespace USSCerritosHelpDesk.Models;

public class Ticket
{
	public int Id { get; set; }
	[Required]
	public string Title { get; set; }
	public string Description { get; set; }
	public DateTime DateCreated { get; set; }
	public DateTime CommentDate { get; set; }
	public DateTime UpdateDate { get; set; }
	public int StatusId { get; set; }
	public int UserId { get; set; }
	public int DepartmentId { get; set; }
	public int CategoryId { get; set; }
	public string Priority { get; set; }
	public int AssignedToUserId { get; set; }
}

