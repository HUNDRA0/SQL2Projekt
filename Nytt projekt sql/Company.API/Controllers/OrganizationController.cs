using Company.API.Extensions;
using Company.Common.DTOs;
using Company.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Company.Data.Entities;

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController : Controller
    {
        private readonly IDbService _db;
        public OrganizationController(IDbService db) => _db = db;
        // GET: api/<FöretagController>
        [HttpGet]
        public async Task<IResult> Get() => await _db.HttpGetAsync<Organization, CompanyDTO>();

        // GET api/<CoursesController>/5
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id) => await _db.HttpGetSingleAsync<Organization, CompanyDTO>(id);


        // POST api/<CoursesController>
        [HttpPost]
        public async Task<IResult> Post([FromBody] CompanyDTO dto) => await _db.HttpPost<Organization, CompanyDTO>(dto);


        // PUT api/<CoursesController>/5
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] CompanyDTO dto) => await _db.HttpPut<Organization, CompanyDTO>(id, dto);


        // DELETE api/<CoursesController>/5
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id) => await _db.HttpDeleteAsync<Organization>(id);
    }
}
