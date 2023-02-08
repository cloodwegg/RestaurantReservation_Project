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
        //to add foreign key after integration
        public int RestaurantId { get; set; }
        //to add foreign key after integration
        public int StaffId { get; set; }
    }
}
