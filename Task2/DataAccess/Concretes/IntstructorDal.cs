using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.DataAccess.Abstracts;
using Task2.Entities;

namespace Task2.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> instructors;
        public InstructorDal() 
        {
            Instructor instructor1 = new Instructor();
            instructor1.Id = 1;
            instructor1.FirstName = "Engin";
            instructor1.LastName = "Demiroğ";
            Instructor instructor2 = new Instructor();
            instructor2.Id = 2;
            instructor2.FirstName = "Halit";
            instructor2.LastName = "Kalaycı";
            Instructor instructor3 = new Instructor();
            instructor3.Id = 3;
            instructor3.FirstName = "Hüseyin";
            instructor3.LastName = "Kan";

            instructors = new List<Instructor> { instructor1,instructor2,instructor3};
        }
        public void Add(Instructor instructor)
        {
            instructors.Add(instructor);
            instructors.ForEach(instructor => Console.WriteLine(instructor.FirstName + " " + instructor.LastName));
        }

        public void Delete(int id)
        {
            Instructor removedInstructor = instructors.Find(i => i.Id == id);

            if(removedInstructor != null)
            {
                instructors.Remove(removedInstructor);
                instructors.ForEach(instructor => Console.WriteLine(instructor.FirstName + " " + instructor.LastName));
            }
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public Instructor GetInstructorById(int id)
        {
            Instructor instructor = instructors.Find(i => i.Id == id);
            if(instructor == null)
            {
                return null;
            }
            return instructor;
        }

        public void Update(Instructor instructor)
        {
            if(instructors.Exists(i=>i.Id == instructor.Id))
            {
                int index  = instructors.FindIndex(i =>  i.Id == instructor.Id);
                instructors[index] = instructor;
                instructors.ForEach(instructor => Console.WriteLine(instructor.FirstName + " " + instructor.LastName));
            }else
            {
                Console.WriteLine("Böyle bir öğretmen yok");
            }
        }
    }
}
