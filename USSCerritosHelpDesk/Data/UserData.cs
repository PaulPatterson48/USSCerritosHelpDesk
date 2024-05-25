using System;
using USSCerritosHelpDesk.Models;

namespace USSCerritosHelpDesk.Data;

public class UserData
{
	public static List<User> Users = new List<User>
	{
		new User {Id = 1, FirstName = "Paul", LastName = "Patterson", DepartmentId = 1, CommBageId = "Dilligent444444", Role = "Engineer"},
		new User {Id = 2, FirstName = "Andy", LastName = "Billups", DepartmentId = 2, CommBageId = "AB1234456USSC", Role = "Lieutenant Commander"},
		new User {Id = 3, FirstName = "Bingston", LastName = "Winger, Jr", DepartmentId = 3, CommBageId = "BW123456USSC", Role = "Lieutenant Junior Grade"},
		new User {Id = 4, FirstName = "Brad", LastName = "Boimler", DepartmentId = 1, CommBageId = "BB123456USSC", Role = "Lieutenant Junior grade"},
		new User {Id = 5, FirstName = "Carol", LastName= "Freeman", DepartmentId = 1, CommBageId = "CF111111USSC", Role = "Captain" },
		new User {Id = 6, FirstName = "Beckett", LastName = "Mariner", DepartmentId = 1,CommBageId = "BM123456USSC", Role = "Ensign"},
		new User {Id = 7, FirstName = "Sam", LastName = "Rutherford", DepartmentId = 1, CommBageId = "SR123456USSC", Role = "Ensign"},
		new User {Id = 8, FirstName = "Tendi", LastName = "D'Vana", DepartmentId = 3, CommBageId = "TDV123456USSC", Role = "Lieutenant Junior grade"}

	};
}

