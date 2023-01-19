using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation_Project.Shared.Domain
{
    public class Rating
    {
        public int Id { get; set; }
        public int RatingScore { get; set; }
        public string Description { get; set; }
        public virtual Reservation Reservation { get; set; }    
        public int ReservationId { get; set; }
    }
}
