using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReservation_Project.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReservation_Project.Server.Configurations.Entities
{
    public class RatingSeedConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.HasData(
                new Rating
                {
                    Id = 1,
                    RatingScore = 5,
                    Description = "amazing meal, would eat again",
                    ReservationId = 1,
                },
                new Rating
                {
                    Id = 2,
                    RatingScore = 2,
                    Description = "food had flies in it, boycotting this establishment.",
                    ReservationId = 2,
                }
            );
        }
    }
}
