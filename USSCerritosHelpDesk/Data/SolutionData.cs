using System;
using USSCerritosHelpDesk.Models;

namespace USSCerritosHelpDesk.Data;


public class SolutionData
{
	public static List<Solution> Solutions = new List<Solution>
	{
		new Solution {Id = 1, TicketId = 1, SolveDate = new DateTime( 2024, 1, 4)},
		new Solution {Id = 2, TicketId = 2, SolveDate = new DateTime( 2024, 1, 5)},
		new Solution {Id = 3, TicketId = 3, SolveDate = new DateTime( 2024, 1, 6)}
	};
}

