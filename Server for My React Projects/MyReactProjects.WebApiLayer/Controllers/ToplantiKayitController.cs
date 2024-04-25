using AutoMapper;
using MeetingOrganizer.BussinesLayer.Abstract;
using MeetingOrganizer.EntityLayer.Concrete;
using MeetingOrganizer.EntityLayer.Concrete.VMs.ToplantiKayitVm;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MeetingOrganizer.WebApiLayer.Controllers
{
    [Authorize(Roles = "Üye")]
    [Route("api/[controller]")]
    [ApiController]
    public class ToplantiKayitController(IToplantiKayitManager ToplantiKayitManager, IMapper mapper) : ControllerBase
    {
        private readonly IToplantiKayitManager toplantiKayitManager = ToplantiKayitManager;
        private readonly IMapper mapper = mapper;

        [HttpGet("[action]")]
        public async Task<IActionResult> Get()
        {
            ICollection<ToplantiKayit> meetings = await toplantiKayitManager.GetAll();
            return Ok(meetings);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create(ToplantiCreateVm toplantiKayitCreateVm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ToplantiKayit urun = mapper.Map<ToplantiKayit>(toplantiKayitCreateVm);
                    return Ok(await toplantiKayitManager.Insert(urun));
                }
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }

            var errorMessage = ModelState.Values.SelectMany(p => p.Errors.Select(e => e.ErrorMessage));
            return BadRequest(new { Errors = errorMessage });
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> Update(ToplantiUpdateVm toplantiKayitUpdateVm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ToplantiKayit urun = mapper.Map<ToplantiKayit>(toplantiKayitUpdateVm);

                    await toplantiKayitManager.update(urun);

                    return Ok();
                }
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }

            var errorMessage = ModelState.Values.SelectMany(p => p.Errors.Select(e => e.ErrorMessage));
            return BadRequest(errorMessage);
        }

        [HttpDelete("[action]/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                int sonuc = await toplantiKayitManager.DeleteByPK(id);
                return Ok(sonuc);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }

        }

        [HttpPost("[action]/{id}")]
        public async Task<IActionResult> Search(int id)
        {
            if (id == 0)
            {
                ICollection<ToplantiKayit> results = await toplantiKayitManager.GetAll();
                return Ok(results);
            }
            else
            {
                ToplantiKayit result = await toplantiKayitManager.GetByPK(id);
                if (result == null)
                {
                    return null;
                }
                return Ok(result);
            }


        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetPropNamesAndTypes()
        {
            ICollection<string> propname = await toplantiKayitManager.GelAllTablePropsNamesAndTypes();
            return Ok(propname);
        }

    }
}
