using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReservation_Project.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReservation_Project.Server.Configurations.Entities
{
    public class AppUserSeedConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasData (
                new AppUser {
                    Id = 1,
                    Name = "Jason",
                    DateOfBirth = new DateTime(2002, 9, 11),
                    Gender = "Male",
                    Email = "2105200F@student.tp.edu.sg",
                    Contact = 83824895,
                    Address = "Compassvale Drive Blk xxx #10-xxx S54xxx7"
                },
                new AppUser {
                    Id = 2,
                    Name = "John",
                    DateOfBirth = new DateTime(2003, 2, 5),
                    Gender = "Male",
                    Email = "john2003@gmail.com",
                    Contact = 45329540,
                    Address = "Hougang Ave 9 Blk xxx #5-xxx S5xxxx2"
                }
            );
        }
    }
}
