using ReserveRoom.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ReserveRoom
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("New Hotel");

            hotel.MakeReservation(new Reservation(
             new RoomId(1, 3)
             , new DateTime(2000, 1, 1),
             new DateTime(2000, 1, 2),
             "John"));

            hotel.MakeReservation(new Reservation(
             new RoomId(1, 2)
             , new DateTime(2000, 1, 3),
             new DateTime(2000, 1, 4),
             "Ben"));

            IEnumerable<Reservation> reservations = hotel.GetAllReservations("John");
            base.OnStartup(e);
        }
    }
}
