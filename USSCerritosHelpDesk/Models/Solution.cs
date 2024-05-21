using System;
using System.ComponentModel.DataAnnotations;
namespace USSCerritosHelpDesk.Models;

public class Solution
{
	public int Id { get; set; }
	[Required]
	public string SolutionText { get; set; }
	public DateTime SolveDate { get; set; }
}

