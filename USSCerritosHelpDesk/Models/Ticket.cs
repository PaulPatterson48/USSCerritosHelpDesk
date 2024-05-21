using System;
using System.ComponentModel.DataAnnotations;

namespace USSCerritosHelpDesk.Models;

public class Ticket
{
	public int Id { get; set; }
	[Required]
	public string CommentText { get; set; }
	public DateTime CommentDate { get; set; }
	public string StatusType { get; set; }
	public int UserId { get; set; }
	public int DepartmentId { get; set; }
	public string CategoryName { get; set; }
	public string Priority { get; set; }
}

