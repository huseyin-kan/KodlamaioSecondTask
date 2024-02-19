using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.DataAccess.Concretes;
using Task2.Entities;

namespace Task2.Business
{
    public class InstructorManager
    {
        private readonly InstructorDal _instructoDal;

        public InstructorManager(InstructorDal instructoDal)
        {
            _instructoDal = instructoDal;
        }

        public List<Instructor> GetAll()
        {
            InstructorDal instructorDal = new InstructorDal();
            
            return instructorDal.GetAll();
        }

        public Instructor GetInstructorById(int id)
        {
            InstructorDal instructorDal = new InstructorDal();

            return instructorDal.GetInstructorById(id);
        }

        public void Add(Instructor instructor)
        {
            InstructorDal instructorDal = new InstructorDal();

            instructorDal.Add(instructor);
        }

        public void Delete(int id)
        {
            InstructorDal instructorDal = new InstructorDal();

            instructorDal.Delete(id);
        }
        public void Update(Instructor instructor)
        {
            InstructorDal instructorDal = new InstructorDal();

            instructorDal.Update(instructor);
        }
    }
}
