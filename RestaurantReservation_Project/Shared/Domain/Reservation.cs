using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation_Project.Shared.Domain
{
    class Reservation
    {
        public int Id { get; set; }
        public int GroupSize { get; set; }
        public DateTime DateTime { get; set; }
    }
}
