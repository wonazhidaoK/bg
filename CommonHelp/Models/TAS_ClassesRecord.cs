using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonHelp.Models
{
   public class TAS_ClassesRecord
    {
        public int Id { get; set; }

        public int CourseID { get; set; }

        public double Hours { get; set; }

        public string ClasseTitle { get; set; }

        public string UId { get; set; }

        public string Position { get; set; }
    }
}
