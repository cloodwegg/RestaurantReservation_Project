using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation_Project.Shared.Domain
{
    public class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string NRIC { get; set; }
        public string Address { get; set; }
        public int Contact { get; set; }
    }
}
