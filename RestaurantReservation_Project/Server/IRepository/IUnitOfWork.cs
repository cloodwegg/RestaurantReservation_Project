using RestaurantReservation_Project.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReservation_Project.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<AppUser> AppUsers { get; }
        IGenericRepository<Rating> Ratings { get; }
        IGenericRepository<Reservation> Reservations { get; }
    }
}