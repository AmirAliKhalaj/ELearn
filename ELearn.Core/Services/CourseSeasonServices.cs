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
    public class CourseSeasonServices : ICourseSeason
    {
        private readonly ELearnContext _context;
        public CourseSeasonServices(ELearnContext context)
        {
            _context = context;
        }


        public async Task<bool> CreatCourseSeason(CourseSeason courseSeason)
        {
           try
            {
                await _context.CourseSeasons.AddAsync(courseSeason);
                await _context.SaveChangesAsync();
                return true;
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public async Task<bool> DeleteCourseSeason(int id)
        {
            var courseSeason=await GetCourseSeasonById(id);
            if (courseSeason == null)
            {
                throw new Exception("Course Season Not Found");
            }
            try
            {
                courseSeason.IsDeleted = true;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                    return false;
            }
        }

        public async Task<CourseGroup> GetCourseSeasonById(int id)
        {
            var courseSeason = await _context.CourseSeasons.FindAsync();
            if (courseSeason == null)
            {
                throw new Exception("CourseSeason Not Found");
            }
            return courseSeason;
        }

        public IEnumerable<CourseSeason> GetCourseSeasons()
        {
            return _context.CourseSeasons;
        }

        public async Task<bool> UpdateCourseSeason(CourseSeason courseSeason)
        {
            try
            {
                _context.CourseSeasons.Update(courseSeason);
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
