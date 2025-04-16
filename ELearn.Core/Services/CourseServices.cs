using ELearn.Core.Interfaces;
using ELearnDataLayer.Context;
using ELearnDataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearn.Core.Services
{
    public class CourseServices : ICourse
    {
        private readonly ELearnContext _context;
        public CourseServices(ELearnContext context)
        {
            _context = context;
        }
        public async Task<bool> CreatCourse(Course course)
        {
           try
            {
                await _context.Courses.AddAsync(course);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public async Task<bool> DeleteCourse(int id)
        {
            var course = await GetCourseById(id);
            if (course == null)
            {
                throw new Exception("Course Not Found");
            }
            try
            {
                course.IsDeleted = true;
                await _context.SaveChangesAsync();
                return true;


            }
            catch (Exception ex  )
            {
                
                Console.WriteLine(ex);
                return false;
            }

        }

       

        public async Task<Course> GetCourseById(int id)
        {
           var course = await _context.Courses.FindAsync(id);
            if ( course == null )
            {
                throw new Exception("Course Not Found");
            }
            return course;

        }

        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses;
        }

        public async Task<bool> UpdateCourse(Course course)
        {
            try
            {
                _context.Courses.Update(course);
                _context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return false;

            }
        }
    }
}
