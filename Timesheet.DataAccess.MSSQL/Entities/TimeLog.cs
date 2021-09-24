using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timesheet.DataAccess.MSSQL.Entities
{
    public class TimeLog
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }
        public int WorkingHours { get; set; }
        public int LastName { get; set; }
        public int Comment { get; set; }
        

    }
}
