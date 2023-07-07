using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using namdemocoreapi.Services;
using System.Threading.Tasks;
using namdemocoreapi.Models;


namespace namdemocoreapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        private readonly IEmpRepo _employee;
        public EmpController(IEmpRepo employee)
        {
            _employee = employee;
        }
    
        [HttpGet]
        [Route("getdata")]
        public async Task<IActionResult> GetEmployeeList()
        {
            var result = await _employee.GetEmployeeList();
            return Ok(result);
        }

        [HttpPost]

        public async Task<IActionResult> SaveEmp(TblEmployee Emp)
        {

            var result = await _employee.SaveEmpAsync(Emp);
            return Ok(result);
        }

        [HttpGet]
        [Route("getbyid")]
        public async Task<IActionResult> Getbyid(int id)
        {
            var result = await _employee.Getbyid(id);
            return Ok(result);
        }

        [HttpPut]
        [Route("DeleteData")]
        public async Task<IActionResult> Delectdata(int id)
        {
            var result = await _employee.Delectdatas(id);
            return Ok(result);
        }

    }
}
