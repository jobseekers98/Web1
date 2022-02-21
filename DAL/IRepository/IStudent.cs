using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IStudent
    {

        Task<Student> GetStudent(int? userId);

        Task<int> AddOrEdit(Student user);

        Task<int> DeleteStudent(int? userId);

    }
}
