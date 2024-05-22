using System;
using System.ComponentModel.DataAnnotations;
namespace USSCerritosHelpDesk.Models;

public class Category
{
	public int Id { get; set; }
	[Required]
	public string CategoryName { get; set; }
}

