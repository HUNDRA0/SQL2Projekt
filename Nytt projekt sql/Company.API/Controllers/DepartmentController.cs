using Company.API.Extensions;
using Company.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Company.API.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : Controller
    {
       
        private readonly IDbService _db;
        public DepartmentController(IDbService db) => _db = db;
        // GET: api/<AvdelningController>
        [HttpGet]
        public async Task<IResult> Get() => await _db.HttpGetAsync<Department, DepartmentDTO>();

        // GET api/<CoursesController>/5
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id) => await _db.HttpGetSingleAsync<Department, DepartmentDTO>(id);


        // POST api/<CoursesController>
        [HttpPost]
        public async Task<IResult> Post([FromBody] DepartmentDTO dto) => await _db.HttpPost<Department, DepartmentDTO>(dto);


        // PUT api/<CoursesController>/5
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] DepartmentDTO dto) => await _db.HttpPut<Department, DepartmentDTO>(id, dto);


        // DELETE api/<CoursesController>/5
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id) => await _db.HttpDeleteAsync<Department>(id);
    }
}
