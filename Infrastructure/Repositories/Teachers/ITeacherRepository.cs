﻿

using Domain.Models.Teacher;

namespace Infrastructure.Repositories.Teachers
{
    public interface ITeacherRepository
    {
        Task<List<Teacher>> GetAllTeacher(CancellationToken cancellationToken);
        Task<Teacher> GetTeacherById(Guid id);
        Task<Teacher> AddTeacher(Teacher newTeacher, CancellationToken cancellationToken);
        Task<Teacher> UpdateTeacher(Guid id, string FirstName,
                              string LastName, DateTime DateOfBirth,
                              string Address, string PhoneNumber,
                              string Email, CancellationToken cancellationToken);
        Task<Teacher> DeleteTeacher(Guid id, CancellationToken cancellationToken);
    }
}
