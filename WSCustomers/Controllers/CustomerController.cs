using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DL;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WSCustomers.Models;

namespace WSCustomers.Controllers
{
    [Route("api/customer")]
    public class CustomerController : Controller
    {        
        [Produces("application/json")]
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var customers = BL.CustomersManagement.GetCustomers();
               
                return Ok(customers);
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }

        [Produces("application/json")]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCustomerOrders(int id)
        {
            try
            {
                var customers = BL.CustomersManagement.GetCustomerOrders(id);

                return Ok(customers);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [Produces("application/json")]
        [HttpGet]
        [Route("getriskcustomers/{x}")]
        public async Task<IActionResult> GetRiskCustomers(decimal x)
        {
            try
            {
                var customers = BL.CustomersManagement.GetRiskCustomerts(x);

                return Ok(customers);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [Produces("application/json")]
        [HttpPut]
        public async Task<IActionResult> UpdateCustomer([FromBody] DtoCustomer customer)
        {
            try
            {
                var result = BL.CustomersManagement.Update(customer);

                switch (result)
                {
                    case BL.Responses.Unknown:                                           
                    case BL.Responses.Failed:                        
                    default:
                        return BadRequest();
                    case BL.Responses.NoFound:
                        return NotFound();
                    case BL.Responses.NoChanges:
                        return StatusCode(StatusCodes.Status304NotModified);
                    case BL.Responses.Success:
                        return Ok(true);                       
                }               
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}