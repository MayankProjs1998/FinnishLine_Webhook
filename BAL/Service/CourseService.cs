using DAL.Data;
using DAL.Model;
using DAL.ServiceDal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Service
{
    public class CourseService : ICourseService
    {
        private readonly ICourseServiceDal _Context;
        public CourseService(ICourseServiceDal context)
        {
                this._Context = context;
        }

        public async Task<IEnumerable<Course>> GetAllCoursesAsync()
        {
            return await _Context.GetAllCoursesAsync();
        }

        public async Task<Course?> GetCourseByIdAsync(int id)
        {
            return await _Context.GetCourseByIdAsync(id);
        }

        public async Task<Course> AddCourseAsync(Course course)
        {
            return await _Context.AddCourseAsync(course);
        }

        public async Task<Course?> UpdateCourseAsync(Course course)
        {
            var existing = await _Context.UpdateCourseAsync(course);
            return existing;
        }

        public async Task<bool> DeleteCourseAsync(int id)
        {
            var course = await _Context.DeleteCourseAsync(id);
            return course;
        }
    }
}
