namespace EmployeeApp.Models
{
    public class WorkingHour
    {
        public int Id { get; set; }
        public int Hour { get; set; }

        public ICollection<Employee>? Employee { get; set; }
    }
}