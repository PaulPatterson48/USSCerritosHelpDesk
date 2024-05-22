using System;
using USSCerritosHelpDesk.Models;

namespace USSCerritosHelpDesk.Data;

public class UserData
{
    public static List<User> Users = new List<User>
	{
		new User {Id = 1, FirstName = "Paul", LastName = "Patterson", DepartmentId = 1, CommBageId = "Dilligent444444", Role = "Engineer"},

	}
}

