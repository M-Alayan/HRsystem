using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRSystem.data;

namespace HRSystem.Models
{
    public class VMemployee
    {
       public Employee employee { set; get; }
       public List<Department> lidepartment { set; get; }
        public List<City> licity { set; get; }
       public List<Country>licountry{set;get;}

    }
}
