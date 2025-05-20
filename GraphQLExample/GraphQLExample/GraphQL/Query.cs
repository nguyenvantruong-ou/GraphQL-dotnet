
using GraphQLDemo.Models;

namespace GraphQLDemo.GraphQL
{
    public class Query 
    {
        public IQueryable<Student> GetStudents([Service] AppDbContext context) =>
            context.Students;
    }
}
