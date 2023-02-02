using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation_Project.Shared.Domain
{
    public class Reservation
    {
        public int Id { get; set; }
        public int GroupSize { get; set; }
        public DateTime DateTime { get; set; }
        public virtual AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
        public int RestaurantId { get; set; }
        public int StaffId { get; set; }
    }
}
