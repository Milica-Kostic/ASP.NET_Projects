using BookingApp.Models;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace BookingApp.Hubs
{
    [HubName("BookingHub")] 
    public class BookingHub : Hub
    {
        public static void RefreshBookings(Booking bookings)
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<BookingHub>();
            context.Clients.All.refreshBookingData(bookings);
        }
    }
}