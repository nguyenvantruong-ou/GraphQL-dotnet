namespace GraphQLDemo.GraphQL.Inputs
{
    public class AddStudentInput
    {
        public string FullName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Address { get; set; } = "";
    }
    public class UpdateStudentInput
    {
        public int Id { get; set; }
        public string FullName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Address { get; set; } = "";
    }
}
