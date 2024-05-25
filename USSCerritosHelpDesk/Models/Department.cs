using System;
using System.ComponentModel.DataAnnotations;

namespace USSCerritosHelpDesk.Models;

public class Department
{
	public int Id { get; set; }
	[Required]
	public string DepartmentName { get; set; }
}

