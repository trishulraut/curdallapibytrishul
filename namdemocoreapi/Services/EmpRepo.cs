using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using namdemocoreapi.Services;
using namdemocoreapi.Models;
using Microsoft.EntityFrameworkCore;

namespace namdemocoreapi.Services
{
    public class EmpRepo:IEmpRepo
    {
        private readonly mitrozassigmentContext _appDbContext;
        public EmpRepo(mitrozassigmentContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IEnumerable<TblEmployee>> GetEmployeeList()
        {
            var empList = await _appDbContext.TblEmployee.ToListAsync();
            return empList;
        }

        public async Task<string> SaveEmpAsync(TblEmployee Emp)
        { 
           
            if (Emp.EId == 0)
            {
                _appDbContext.TblEmployee.Add(Emp);
                await _appDbContext.SaveChangesAsync();
            }
            else {

            
                _appDbContext.TblEmployee.Update(Emp);
                await _appDbContext.SaveChangesAsync();
            }
            return "Save Sucessfully";

        }
        public async Task<TblEmployee> Getbyid(int id)
        {
            TblEmployee emp = new TblEmployee();

               var empList = await _appDbContext.TblEmployee.FirstOrDefaultAsync(x => x.EId == id);
            if (empList != null)
            {
                emp.EId = empList.EId;
               emp.Name = empList.Name;
                emp.Email = empList.Email;
                emp.Address = empList.Address;
                emp.DeptId = empList.DeptId;

            }

            return emp;
        }

        public async Task<string> Delectdatas(int id)
        {
            var result = await _appDbContext.TblEmployee.FirstOrDefaultAsync(x => x.EId == id);
            if (result == null)
            {
                return null;
            }
            _appDbContext.TblEmployee.Remove(result);
            _appDbContext.SaveChangesAsync();
            return "Delect SucessFully";
        }


    }
}
