using DAL.Data;
using DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ServiceDal
{
    public class CourseServiceDal : ICourseServiceDal
    {
        private readonly ApplicationDbContext _Context;
        public CourseServiceDal(ApplicationDbContext context)
        {
            this._Context = context;
        }

        public async Task<IEnumerable<Course>> GetAllCoursesAsync()
        {
            return await _Context._Course.ToListAsync();
        }

        public async Task<Course?> GetCourseByIdAsync(int id)
        {
            return await _Context._Course.FindAsync(id);
        }

        public async Task<Course> AddCourseAsync(Course course)
        {
            _Context._Course.Add(course);
            await _Context.SaveChangesAsync();
            return course;
        }

        public async Task<Course?> UpdateCourseAsync(Course course)
        {
            var existing = await _Context._Course.FindAsync(course.Id);
            if (existing == null) return null;

            existing.CourseName = course.CourseName;
            existing.Fees = course.Fees;
            existing.Duration = course.Duration;

            await _Context.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteCourseAsync(int id)
        {
            var course = await _Context._Course.FindAsync(id);
            if (course == null) return false;

            _Context._Course.Remove(course);
            await _Context.SaveChangesAsync();
            return true;
        }
    }
}
