using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReservation_Project.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReservation_Project.Server.Configurations.Entities
{
    public class ReservationSeedConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasData(
                new Reservation
                {
                    Id = 1,
                    GroupSize = 5,
                    DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 15, 5, 0),
                    AppUserId = 1,
                    RestaurantId = 1,
                    StaffId = 1,
                },
                new Reservation
                {
                    Id = 2,
                    GroupSize = 2,
                    DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 0, 0),
                    AppUserId = 2,
                    RestaurantId = 2,
                    StaffId = 2,
                }
            );
        }
    }
}
