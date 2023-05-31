using Domain.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Casino.Api.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private IRepository<Customer> customerRepo;
        public CustomerController(IRepository<Customer> customerRepo)
        {
            this.customerRepo = customerRepo;
        }
        //get all customers 
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> Get()
        {
            return await Task.FromResult(customerRepo.GetAll().ToList());
        }
        //get customer by id 
        [HttpGet("{Id}")]
        public async Task<ActionResult<Customer>> Get(int Id)
        {
            var customer = await Task.FromResult(customerRepo.Get(Id));
            if (customer == null)
                return BadRequest("customerRepo not found!");
            return customer;
        }

        //add customer
        [HttpPost]
        public async Task<ActionResult<Customer>> Post(Customer  customer)
        {
          
            if (customer == null)
                return BadRequest("customer can not be empty!");
            try
            {
                customer.DateCreated = DateTime.Now;
                customerRepo.Insert(customer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return await Task.FromResult(customer);
        }

    }
}
