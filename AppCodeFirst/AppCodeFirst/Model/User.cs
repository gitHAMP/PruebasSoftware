using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCodeFirst.Model
{
    public class User
    {
        public int UserId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public List<Task> Tasks { get; set; }

        public String GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }
        public override string ToString()
        {
            return $"User id={UserId}, name={GetFullName()}";
        }
    }
}
