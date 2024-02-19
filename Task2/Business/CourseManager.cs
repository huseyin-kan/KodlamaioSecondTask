using SecondTask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.DataAccess.Abstracts;
using Task2.DataAccess.Concretes;

namespace SecondTask.Business
{
    public class CourseManager
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public List<Course> GetAll()
        {
            CourseDal courseDal = new CourseDal();

            return courseDal.GetAll();
        }
        public void AddCourse(Course course)
        {
            CourseDal courseDal = new CourseDal();
            courseDal.Add(course);
        }
        public Course GetCourseById(int id)
        {
            CourseDal courseDal = new CourseDal();

            return courseDal.GetCourseById(id);
        }
        public void UpdateCourse(Course course)
        {
            CourseDal courseDal = new CourseDal();
            
            courseDal.Update(course);
        }
        public void DeleteCourse(int id)
        {
            CourseDal courseDal = new CourseDal();

            courseDal.Delete(id);
        }
    }
}
