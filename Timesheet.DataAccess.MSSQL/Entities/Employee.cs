using System.Collections.Generic;

namespace Timesheet.DataAccess.MSSQL.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public  decimal Salary { get; set; }
        public string Position { get; set; }

        public ICollection<TimeLog> TimeLogs { get; set; }

    }
}            