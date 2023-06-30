namespace EmployeeApp.Models
{
    public class Designation
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;
        public ICollection<Employee>? Employee { get; set; }
    }
}