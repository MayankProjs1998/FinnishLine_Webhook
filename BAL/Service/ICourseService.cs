using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Service
{
    public interface ICourseService
    {
        Task<IEnumerable<Course>> GetAllCoursesAsync();
        Task<Course?> GetCourseByIdAsync(int id);
        Task<Course> AddCourseAsync(Course course);
        Task<Course?> UpdateCourseAsync(Course course);
        Task<bool> DeleteCourseAsync(int id);
    }
}
