using System;
using USSCerritosHelpDesk.Models;

namespace USSCerritosHelpDesk.Data;

public class StatusData
{
    public static List<Status> Statuses = new List<Status>
    {
        new Status {Id = 1, StatusName = "Open"},
        new Status {Id = 2, StatusName = "In Progress"},
        new Status {Id = 3, StatusName = "Awaiting Customer Review"},
        new Status {Id = 4, StatusName = "Resolved"},
        new Status {Id = 5, StatusName = "ReOpened"},
        new Status {Id = 6, StatusName = "Cancelled"},
        new Status {Id = 7, StatusName = "Escalated"}
    };
}

