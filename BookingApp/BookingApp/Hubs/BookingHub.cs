using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace BookingApp.Hubs
{
    [HubName("bookingHub")]
    public class BookingHub : Hub
    {
        public static void RefreshBookings()
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<BookingHub>();
            context.Clients.All.refreshBookingData();
        }
    }
}