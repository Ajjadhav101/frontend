
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BuggyApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetInvoice()
        {

            List<Item> items = new List<Item>();
{
    new Item { Name = "Laptop", Price = 999.99 },
    new Item { Name = "Mouse", Price = 25.50 },
    new Item { Name = "Keyboard", Price = 45.00 }
};

            if (items.Count == 0)
            {
                return Ok(new { items });
            }

            return NotFound("No invoice found");
        }

        public class Item
        {
            public string Name { get; set; }
            public double Price { get; set; }
        }
    }
}
}
