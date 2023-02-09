using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReservation_Project.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReservation_Project.Server.Configurations.Entities
{
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
             new Staff
             {
                 Id = 1,
                 Name = "Ibrahim",
                 DateofBirth = new DateTime(2004, 3, 5),
                 Gender = "Male",
                 Email = "2102880H@student.tp.edu.sg",
                 NRIC = "T0405960Z",
                 Address = "Tampines Blk xxx #02-xxx S52xxx1",
                 Contact = 87523513,
             },
             new Staff
             {
                 Id = 2,
                 Name = "HeadStaff",
                 DateofBirth = new DateTime(2000, 1, 1),
                 Gender = "Male",
                 Email = "headstaff@gmail.com",
                 NRIC = "T0001234T",
                 Address = "Woodlands Blk xxx #14-xxx S73xxx1",
                 Contact = 22443355,
             }
           );
        }
    }
}