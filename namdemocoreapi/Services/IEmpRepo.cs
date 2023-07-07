
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using namdemocoreapi.Models;

namespace namdemocoreapi.Services
{
    public interface IEmpRepo
    {
        Task<IEnumerable<TblEmployee>> GetEmployeeList();
        Task<string> SaveEmpAsync(TblEmployee Emp);
        Task<TblEmployee> Getbyid(int Emp);
        Task<string> Delectdatas(int Emp);
    }
}
