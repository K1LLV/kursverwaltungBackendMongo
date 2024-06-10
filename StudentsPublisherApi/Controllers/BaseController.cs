using Microsoft.AspNetCore.Mvc;
using StudentsPublisherApi.Services;

namespace StudentsPublisherApi.Controllers
{
    [ApiController]
    public abstract class BaseController<T> : ControllerBase where T : class
    {
        protected readonly MongoDbServiceBase<T> _service;

        protected BaseController(MongoDbServiceBase<T> service)
        {
            _service = service;
        }

        [HttpGet]
        public virtual async Task<IEnumerable<T>> Get()
        {
            return await _service.GetAsync();
        }

        [HttpGet("{id}")]
        public virtual async Task<T> Get(string id)
        {
            return await _service.GetAsync(id);
        }

        [HttpPost]
        public virtual async Task<IActionResult> Post([FromBody] T item)
        {
            await _service.CreateAsync(item);
            return CreatedAtAction(
                nameof(Post),
                new { id = ((dynamic)item).Id },
                item);
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Put(string id, [FromBody] T item)
        {
            var result = await _service.UpdateAsync(id, item);
            return CreatedAtAction(nameof(Put), result);
        }

        [HttpDelete("{id}")]
        public virtual async void Delete(string id)
        {
            await _service.DeleteAsync(id);
        }
    }
}
