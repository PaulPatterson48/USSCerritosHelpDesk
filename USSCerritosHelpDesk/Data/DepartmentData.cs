using System;
using USSCerritosHelpDesk.Models;

namespace USSCerritosHelpDesk.Data;

public class DepartmentData
{
	public static List<Department> Departments = new List<Department>
	{
		new Department { Id = 1, DepartmentName = "Command"},
		new Department { Id = 2, DepartmentName = "Operations"},
		new Department { Id = 3, DepartmentName = "Sciences"}

	};
}

