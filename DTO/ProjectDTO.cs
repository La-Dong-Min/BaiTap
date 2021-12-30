using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProjectDTO
    {
        public string IdEmployee { get; set; }
        public string Name { get; set; }
        public string DateBirth { get; set; }
        public bool Gender { get; set; }
        public string PlaceBirth { get; set; }
        public string IdDepartment { get; set; }
        public Department Depart { get; set; }
        public string Department
        {
            get { return Depart.Name; }
        }
    }
}
