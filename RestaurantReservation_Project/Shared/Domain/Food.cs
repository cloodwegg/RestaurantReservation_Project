using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation_Project.Shared.Domain
{
    public class Food
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int RestaurantID { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
