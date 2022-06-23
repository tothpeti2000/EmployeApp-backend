using Domain.Models.Entity;
using Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    public abstract class CRUDController<T1, T2, T3> : ControllerBase where T1 : IService<T2, T3> where T2 : Entity
    {
        protected readonly T1 service;

        public CRUDController(T1 service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var response = await service.Query(_ => true);



            return Ok(typeof(T1).ToString());
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult> GetById(long Id)
        {
            var item = await service.GetByIdAsync(Id);

            return item == null ? NotFound() : Ok(item);
        }

        [HttpPost]
        public async Task<ActionResult> Add([FromBody] T3 data)
        {
            var item = await service.AddAsync(data);

            return CreatedAtAction(nameof(GetById), new { Id = item.Id }, item);
        }

        [HttpPatch("{Id}")]
        public async Task<ActionResult> Update([FromBody] T3 data)
        {
            await service.UpdateAsync(data);

            return NoContent();
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult> Delete(long Id)
        {
            var succeeded = await service.DeleteByIdAsync(Id);

            return succeeded ? NoContent() : NotFound();
        }
    }
}
