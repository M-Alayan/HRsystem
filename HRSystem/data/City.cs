using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HRSystem.data
{
    [Table("Cities")]
    public class City
    {
        public int Id { get; set; }
        [Required][Column("City Name")]
        public string Name { get; set; }

        List<Employee> liemployee { set; get; }
    }
}
