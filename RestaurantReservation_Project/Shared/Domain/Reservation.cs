using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation_Project.Shared.Domain
{
    public class Reservation
    {
        public int Id { get; set; }
        [Required]
        public int GroupSize { get; set; }
        [Required]
        [DataType(DataType.Date, ErrorMessage = "Date must be set")]
        public DateTime DateTime { get; set; }
        public virtual AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
        //to add foreign key after integration
        public int RestaurantId { get; set; }
        //to add foreign key after integration
        public int StaffId { get; set; }
    }
}
