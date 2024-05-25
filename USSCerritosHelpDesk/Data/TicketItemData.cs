using System;
using USSCerritosHelpDesk.Models;

namespace USSCerritosHelpDesk.Data;

public class TicketItemData
{
	public static List<TicketItem> TicketItems = new List<TicketItem>
	{
		new TicketItem {Id = 1, TicketId = 1, ItemId = 1},
		new TicketItem {Id = 2, TicketId = 2, ItemId = 2},
	};
}

