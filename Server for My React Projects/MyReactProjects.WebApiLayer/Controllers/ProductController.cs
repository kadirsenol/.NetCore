using AutoMapper;
using MeetingOrganizer.BussinesLayer.Abstract;
using MeetingOrganizer.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyReactProjects.EntityLayer.Concrete.VMs.ProductVm;

namespace MeetingOrganizer.WebApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(IProductManager ProductManager, IMapper mapper) : ControllerBase
    {
        private readonly IProductManager productManager = ProductManager;
        private readonly IMapper mapper = mapper;

        [HttpGet("[action]")]
        public async Task<IActionResult> Get()
        {
            if (!ModelState.IsValid)
            {
                var errorMessage = ModelState.Values.SelectMany(p => p.Errors.Select(e => e.ErrorMessage));
                return BadRequest(errorMessage);
            }
            try
            {
                ICollection<Product> products = await productManager.GetAll();
                return Ok(products);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }

        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Search(SearchProductVm? productname)
        {
            if (!ModelState.IsValid)
            {
                var errorMessage = ModelState.Values.SelectMany(p => p.Errors.Select(e => e.ErrorMessage));
                return BadRequest(errorMessage);
            }
            try
            {
                if (productname.ProductName == null || productname.ProductName == "" || productname.ProductName == " ")
                {
                    return Ok();
                }
                var result = await productManager._repo.dbContext.Urunler.Where(p => p.Name.Contains(productname.ProductName)).ToListAsync();
                return Ok(result);


            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }

        }

    }
}
