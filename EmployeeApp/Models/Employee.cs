using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeApp.Models
{
    public class Employee
    {
        public int Id { get; set; } 
        public string EmployeeName { get; set; } = null!;

        public int WorkingHourId { get; set; }
        public WorkingHour? workingHour { get; set; }

        public int DesignationId { get; set; }
        public Designation? designation { get; set; }

        public int PaymentRuleId { get; set; }
        public PaymentRule? paymentRule { get; set; }
        
    }
}
