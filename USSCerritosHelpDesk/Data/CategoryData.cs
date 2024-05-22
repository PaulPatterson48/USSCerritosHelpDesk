using System;
using USSCerritosHelpDesk.Models;
namespace USSCerritosHelpDesk.Data;

public  class CategoryData
{
	public static List<Category> Categories = new List<Category>
	{
		new Category {Id = 1, CategoryName = "Open"},
		new Category {Id = 2, CategoryName = "In Progress"},
		new Category {Id = 3, CategoryName = "Awaiting Customer Review"},
		new Category {Id = 4, CategoryName = "Resolved"},
		new Category {Id = 5, CategoryName = }
	};
}

