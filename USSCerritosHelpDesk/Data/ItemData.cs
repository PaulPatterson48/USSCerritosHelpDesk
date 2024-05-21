using System;
using USSCerritosHelpDesk.Models;


namespace USSCerritosHelpDesk.Data;

public class ItemData
{
	public static List<Item> Items = new List<Item>
	{
		new Item {Id = 1, ItemName = "Crystal Reports 2020", ItemVersion = "version 14.3", ItemImageUrl = "https://m.media-amazon.com/images/I/51tlGzJRQlL._AC_UF1000,1000_QL80_.jpg"},
		new Item {Id = 2, ItemName = "Windows 11 Pro", ItemVersion = "version 1321", ItemImageUrl= "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6498/6498483_sd.jpg;maxHeight=640;maxWidth=550"},

	};
}

