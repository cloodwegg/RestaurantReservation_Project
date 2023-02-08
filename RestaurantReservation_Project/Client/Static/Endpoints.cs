using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReservation_Project.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string AppUsersEndpoint = $"{Prefix}/appusers";
        public static readonly string RatingsEndpoint = $"{Prefix}/ratings";
        public static readonly string ReservationsEndpoint = $"{Prefix}/reservations";

    }
}
