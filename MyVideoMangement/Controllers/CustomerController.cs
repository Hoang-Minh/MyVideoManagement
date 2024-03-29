﻿using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web.Mvc;
using MyVideoMangement.Models;
using MyVideoMangement.ViewModels;

namespace MyVideoMangement.Controllers
{
    public class CustomerController : BaseController
    {
        // GET: Customer
        public ActionResult Index()
        {
            //var customers = MyDbContext.Customers
            //    .Include(x => x.MembershipType)
            //    .ToList();
            
            return View();
        }

        public ActionResult Details(int id)
        {
            var customer = MyDbContext.Customers.Include(x => x.MembershipType).SingleOrDefault(y => y.Id == id);
            

            if (customer == null) return HttpNotFound();
            var customerViewModel = new CustomerViewModel { Customer = customer };

            return View(customerViewModel);
        }

        public ActionResult New()
        {
            var membershipTypes = MyDbContext.MembershipTypes.ToList();
            var newCustomerViewModel = new CustomerFormViewModel{MembershipTypes = membershipTypes};

            return View("CustomerForm", newCustomerViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel(customer)
                {
                    MembershipTypes = MyDbContext.MembershipTypes.ToList()
                };
                return View("CustomerForm", viewModel);
            }

            if (customer.Id == 0)
            {
                MyDbContext.Customers.Add(customer);
            }
            else
            {
                var customerInDb = MyDbContext.Customers.Single(x => x.Id == customer.Id);

                if (customerInDb == null) return HttpNotFound("Customer not found");

                MyDbContext.Customers.AddOrUpdate(customer);
            }

            MyDbContext.SaveChanges();
            return RedirectToAction("Index", "Customer");
        }

        public ActionResult Edit(int id)
        {
            var customer = MyDbContext.Customers.Find(id);
            if (customer == null) return HttpNotFound("Customer not found");

            var viewModel = new CustomerFormViewModel(customer)
            {
                MembershipTypes = MyDbContext.MembershipTypes.ToList()
            };

            return View("CustomerForm", viewModel);
        }
    }
}