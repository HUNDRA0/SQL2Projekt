//using Company.API.Extensions;
//using Microsoft.AspNetCore.Mvc;

//namespace Company.API.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class Employee_PositionController : Controller
//    {
//        private readonly IDbService _db;
//        public Employee_PositionController(IDbService db) => _db = db;
//         GET: api/<BeffatningController>
//        [HttpGet]
//        public async Task<IResult> Get() => await _db.HttpGetAsync<Employee_Position, Employee_PositionDTO>();

//         GET api/<CoursesController>/5
//        [HttpGet("{id}")]
//        public async Task<IResult> Get(int id) => await _db.HttpGetSingleAsync<Employee_Position, Employee_PositionController>(id);


//         POST api/<CoursesController>
//        [HttpPost]
//        public async Task<IResult> Post([FromBody] Employee_PositionDTO dto) => await _db.HttpPost<Employee_Position, Employee_PositionDTO>(dto);


//         PUT api/<CoursesController>/5
//        [HttpPut("{id}")]
//        public async Task<IResult> Put(int id, [FromBody] Employee_PositionDTO dto) => await _db.HttpPut<Employee_Position, Employee_PositionDTO>(id, dto);


//         DELETE api/<CoursesController>/5
//        [HttpDelete("{id}")]
//        public async Task<IResult> Delete(Employee_Position dto) => await _db.HttpDeleteAsync<Employee_Position>(dto);
//    }
//}
