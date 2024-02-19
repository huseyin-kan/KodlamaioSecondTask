using SecondTask.Business;
using SecondTask.Entities;
using Task2.Business;
using Task2.DataAccess.Concretes;
using Task2.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        CourseManager courseManager = new(new CourseDal());

        List<Course> courses = courseManager.GetAll();
        Course course = new Course();
        course.Name = "Pyhton";
        course.Description = "Artifical Inteligence";
        course.Id = 3;
        course.Price = 50;
        //courseManager.DeleteCourse(3);
        //Console.WriteLine();

        InstructorManager instructorManager = new(new InstructorDal());
        List<Instructor> instructors = instructorManager.GetAll();
        Instructor instructor  = new Instructor();
        instructor.Id = 3;
        instructor.FirstName = "Barış";
        instructor.LastName = "Yılmaz";
        //instructorManager.Delete(3);
        //Console.WriteLine();

        CategoryManager categoryManager = new(new CategoryDal());
        List<Category> categories = categoryManager.GetAll();
        Category category = new Category();
        category.Id = 3;
        category.Name = "Machine Learning";
        categoryManager.Delete(3);

    }
}