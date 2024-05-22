using System;
using USSCerritosHelpDesk.Models;
namespace USSCerritosHelpDesk.Data;

public  class CategoryData
{
	public static List<Category> Categories = new List<Category>
	{
		new Category {Id = 1, CategoryName = "Technical Support"},
		new Category {Id = 2, CategoryName = "Software Issue"},
		new Category {Id = 3, CategoryName = "Hardware Issue"},
		new Category {Id = 4, CategoryName = "Network Issue"},
		new Category {Id = 5, CategoryName = "Communications"},
		new Category {Id = 6, CategoryName = "Security Incident"},
		new Category {Id = 7, CategoryName = "Purchase and Procurement"},
		new Category {Id = 8, CategoryName = "User Training"}
	};
}

