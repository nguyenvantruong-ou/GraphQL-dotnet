using GraphQLDemo.GraphQL.Inputs;
using GraphQLDemo.Models;

namespace GraphQLDemo.GraphQL
{
    public class Mutation
    {
        public async Task<Student> AddStudentAsync(AddStudentInput input, [Service] AppDbContext context)
        {
            var student = new Student
            {
                FullName = input.FullName,
                Email = input.Email,
                Address = input.Address
            };

            context.Students.Add(student);
            await context.SaveChangesAsync();

            return student;
        }

        public async Task<Student?> UpdateStudentAsync(UpdateStudentInput input, [Service] AppDbContext context)
        {
            var student = await context.Students.FindAsync(input.Id);

            if (student == null)
                return null;

            student.FullName = input.FullName;
            student.Email = input.Email;
            student.Address = input.Address;

            await context.SaveChangesAsync();
            return student;
        }

        public async Task<bool> DeleteStudentAsync(int id, [Service] AppDbContext context)
        {
            var student = await context.Students.FindAsync(id);

            if (student == null)
                return false;

            context.Students.Remove(student);
            await context.SaveChangesAsync();
            return true;
        }
    }
}
