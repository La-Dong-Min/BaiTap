using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Department
    {
        public string IdDepartment { get; set; }
        public string Name { get; set; }
        public List<ProjectDTO> Project { get; set; }
    }
}
