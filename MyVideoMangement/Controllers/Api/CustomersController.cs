﻿using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using MyVideoMangement.Dtos;
using MyVideoMangement.Models;

namespace MyVideoMangement.Controllers.Api
{
    public class CustomersController : BaseApiController
    {
        [HttpGet]
        // GET api/Customers
        public IHttpActionResult GetCustomers(string query = null)
        {
            var customersQuery = MyDbContext.Customers.Include(x => x.MembershipType);

            if (!string.IsNullOrWhiteSpace(query))
            {
                customersQuery = customersQuery.Where(x => x.Name.Contains(query));
            }

            var mapperProfile = new MappingProfile();
            var customersDto = customersQuery.ToList().Select(mapperProfile.Mapper.Map<Customer, CustomerDto>);

            return Ok(customersDto);
        }

        // GET api/Customers/id
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = MyDbContext.Customers.Single(x => x.Id == id);

            if (customer == null)
                return NotFound();

            var mapperProfile = new MappingProfile();
            var dest = mapperProfile.Mapper.Map<Customer, CustomerDto>(customer);

            return Ok(dest);
        }

        // POST api/Customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            var mapperProfile = new MappingProfile();
            var customer = mapperProfile.Mapper.Map<CustomerDto, Customer>(customerDto);
            MyDbContext.Customers.Add(customer);
            MyDbContext.SaveChanges();

            customerDto.Id = customer.Id;
            return Created(new Uri(Request.RequestUri + "/" + customerDto.Id), customerDto);
        }

        // PUT api/customers/1
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            var customerInDb = MyDbContext.Customers.SingleOrDefault(x => x.Id == id);

            if (customerInDb == null) NotFound();

            var mapperProfile = new MappingProfile();
            mapperProfile.Mapper.Map(customerDto, customerInDb);

            MyDbContext.SaveChanges();
            return Ok("Customer got updated");
        }

        // DELETE api/customers/1
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var customerInDb = MyDbContext.Customers.SingleOrDefault(x => x.Id == id);
            if (customerInDb == null) return NotFound();

            MyDbContext.Customers.Remove(customerInDb);
            MyDbContext.SaveChanges();
            return Ok("Customer got deleted");
        }
    }
}
