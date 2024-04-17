using AutoMapper;
using MeetingOrganizer.BussinesLayer.Abstract;
using MeetingOrganizer.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MeetingOrganizer.WebApiLayer.Controllers
{
    [Authorize(Roles = "Üye")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(IProductManager ProductManager, IMapper mapper) : ControllerBase
    {
        private readonly IProductManager productManager = ProductManager;
        private readonly IMapper mapper = mapper;

        [HttpGet("[action]")]
        public async Task<IActionResult> Get()
        {
            ICollection<Product> products = await productManager.GetAll();
            return Ok(products);
        }

    }
}
