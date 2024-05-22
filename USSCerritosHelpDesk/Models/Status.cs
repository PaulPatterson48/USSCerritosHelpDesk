using System;
using System.ComponentModel.DataAnnotations;
namespace USSCerritosHelpDesk.Models;

public class Status
{
	public int Id { get; set; }
	[Required]
	public string StatusName { get; set; }
}

