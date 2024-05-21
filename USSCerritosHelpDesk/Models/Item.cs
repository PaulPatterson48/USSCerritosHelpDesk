using System;
using System.ComponentModel.DataAnnotations;

namespace USSCerritosHelpDesk.Models;

public class Item
{
	public int Id { get; set; }
	[Required]
	public string ItemName { get; set; }
	public string ItemVersion { get; set; }
	public string ItemImageUrl { get; set; }
}

