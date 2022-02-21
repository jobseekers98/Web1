using DAL.IRepository;
using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class StudentDAL : IStudent
    {
        public Task<int> AddOrEdit(Student user)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteStudent(int? userId)
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetStudent(int? userId)
        {
            throw new NotImplementedException();
        }
    }
}
