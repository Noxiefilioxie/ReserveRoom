using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserveRoom.Models
{
    public class ReservationBook
    {
        private readonly List<Reservation> _reservations;

        public ReservationBook()
        {
            _reservations = new List<Reservation>();
        }

        /// <summary>
        /// Get all reservations
        /// </summary>
        /// <returns></returns>

        public IEnumerable<Reservation> GetAllReservations()
        {
            return _reservations;
        }

        /// <summary>
        /// Add a reservation to the reservation book.
        /// </summary>
        /// <param name="reservation"></param>
        /// <exception cref="ReservationConflictException"></exception>
        public void AddReservation(Reservation reservation)
        {
            foreach (Reservation existingReservation in _reservations)
            {

                if (existingReservation.Conflicts(reservation))
                {
                    throw new ReservationConflictException(existingReservation, reservation);
                }
            }
            _reservations.Add(reservation);
        }
    }
}
