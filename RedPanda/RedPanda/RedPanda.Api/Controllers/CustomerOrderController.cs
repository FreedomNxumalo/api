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
    [Route("api/order")]
    [ApiController]
    public class CustomerOrderController : ControllerBase
    {
        private IRepository<Customer> customerRepo;
        private IRepository<Stock> stockRepo;
        private IRepository<Order> orderRepo;
        public CustomerOrderController(IRepository<Customer> customerRepo, IRepository<Stock> stockRepo, IRepository<Order> orderRepo)
        {
            this.customerRepo = customerRepo;
            this.stockRepo = stockRepo;
            this.orderRepo = orderRepo;
        }
        //get all orders  
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> Get()
        {
            return await Task.FromResult(orderRepo.GetAll().ToList());
        }
        //get order by id 
        [HttpGet("{Id}")]
        public async Task<ActionResult<Order>> Get(int Id)
        {
            var transaction = await Task.FromResult(orderRepo.Get(Id));
            if (transaction == null)
            {
                return BadRequest("order not found!");
            }
            return transaction;
        }
        //get Transaction by players username 
        [HttpPost]
        public async Task<ActionResult<Order>> Post(Order order)
        {
            if (order == null)
                return BadRequest("order can not be empty!");
            try
            {
                order.DateCreated = DateTime.Now;
                orderRepo.Insert(order);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return await Task.FromResult(order);
        }
    }
}
