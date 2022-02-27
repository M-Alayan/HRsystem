using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HRSystem.data
{
    [Table("Countries")]
    public class Country
    {
        public int Id { get; set; }
        [Required][Column("Country Name")]
        public string Name { get; set; }

        List<Employee> liemployee { set; get; }
    }
}
