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
    public class CourseGroupServices : ICourseGroup
    {
        private readonly ELearnContext _context;
        public  CourseGroupServices( ELearnContext context)
        {
            _context = context;
        }
        public async Task<bool> CreatCourseGroup(CourseGroup courseGroup)
        {
            try
            {
                await _context.CourseGroups.AddAsync(courseGroup);

                await _context.SaveChangesAsync();

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public async Task<bool> DeleteCourseGroup(int id)
        {

           var courseGroup = await GetCourseGroupById(id);
            if (courseGroup == null)
            {
                throw new Exception("this course group not found");
            }
            try
            {
                courseGroup.IsDeleted = true;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
                
           
        }

        public async Task<CourseGroup> GetCourseGroupById(int id)
        {
            var courseGroup = await _context.CourseGroups.FindAsync();
            if (courseGroup == null)
            {
                throw new Exception("Course Group not Found");
            }
            return courseGroup;
        }

        public IEnumerable<CourseGroup> GetCourseGroups()
        {
            return _context.CourseGroups;
        }

        public async Task<bool> UpdateCourseGroup(CourseGroup courseGroup)
        {
            try
            {
                _context.CourseGroups.Update(courseGroup);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
    }

  
 }

