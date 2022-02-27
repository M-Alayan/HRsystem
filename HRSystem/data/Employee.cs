using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HRSystem.data
{
    [Table("Employees")]
    public class Employee
    {
        public int Id
        {
            get; set;
        }
        [Required][Column("First name")]
        public string FName
        {
            get; set;
        }
        [Column("Last Name")]
        public string LName { get; set; }

        public string Phone { get; set; }

        public string Gender { get; set; }
        public string  Address { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
        public double ExpectedSalary { get; set; }

        public DateTime Hiredate { get; set; }
        [ForeignKey("department")]
        public int department_id { get; set; }
        [ForeignKey("city")]
        public int city_id { get; set; }
        [ForeignKey("country")]
        public int country_id { get; set; }

        public Department department { set; get; }
        public Country country { set; get; }
        public City city { set; get; }
    }
}
