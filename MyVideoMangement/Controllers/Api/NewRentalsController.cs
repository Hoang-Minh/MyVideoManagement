using System;
using System.Linq;
using System.Web.Http;
using MyVideoMangement.Dtos;
using MyVideoMangement.Models;

namespace MyVideoMangement.Controllers.Api
{
    public class NewRentalsController : BaseApiController
    {
        [HttpPost]
        public IHttpActionResult CreateNewRental(NewRentalDto rentalDto)
        {
            var customer = MyDbContext.Customers.Single(x => x.Id == rentalDto.CustomerId);

            var movies = MyDbContext.Movies.Where(x => rentalDto.MovieIds.Contains(x.Id));

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                {
                    return BadRequest("Movie is not available");
                }

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                MyDbContext.Rentals.Add(rental);
            }

            MyDbContext.SaveChanges();
            return Ok();
        }
    }
}
