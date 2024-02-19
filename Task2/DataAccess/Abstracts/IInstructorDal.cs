using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Entities;

namespace Task2.DataAccess.Abstracts
{
    public interface IInstructorDal
    {
        List<Instructor> GetAll();
        Instructor GetInstructorById(int id);
        void Add(Instructor instructor);
        void Update(Instructor instructor);
        void Delete(int id);
    }
}
