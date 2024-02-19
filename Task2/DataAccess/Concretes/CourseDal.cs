using SecondTask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.DataAccess.Abstracts;

namespace Task2.DataAccess.Concretes
{
    public class CourseDal:ICourseDal
    {
        List<Course> courses;

        public CourseDal()
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "C#";
            course1.Description = ".NET 8";
            course1.Price = 0;
            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "Java";
            course2.Description = "Sprin boot";
            course2.Price = 10;
            Course course3 = new Course();
            course3.Id = 3;
            course3.Name = "Javascript";
            course3.Description = "React";
            course3.Price = 20;

            courses = new List<Course> { course1, course2, course3 };

        }
        public List<Course> GetAll()
        {
            return courses;
        }

        public void Add(Course course)
        {
            courses.Add(course);
            courses.ForEach(course => Console.WriteLine(course.Name));
            
        }

        public Course GetCourseById(int id)
        {
            Course course = courses.Find(c => c.Id == id);
            if(course == null)
            {
                return null;
            }
            return course;
            
        }

        public void Delete(int id)
        {
            Course removedItem = courses.Find(c => c.Id == id);

            if(removedItem != null)
            {
                courses.Remove(removedItem);
                courses.ForEach(course => Console.WriteLine(course.Name));
            }
        }

        public void Update(Course course)
        {
            if(courses.Exists(c=> c.Id == course.Id))
            {
                int index = courses.FindIndex(c => c.Id == course.Id);
                courses[index] = course;
                courses.ForEach(course => Console.WriteLine(course.Name));
            }
            else
            {
                Console.WriteLine("Böyle bir kurs yok");
            }
        }
    }
}
