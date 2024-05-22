using System;
using System.ComponentModel.DataAnnotations;

namespace USSCerritosHelpDesk.Models;

public class User
{
	public int Id { get; set; }
	[Required]
    public int DepartmentId { get; set; }
	[Required]
    public string FirstName { get; set; }
	public string LastName { get; set; }
	public string CommBageId { get; set; }
	public string Role { get; set; }
		
}


