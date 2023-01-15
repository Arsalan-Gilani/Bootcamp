﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_EmployeData.Models.DBEntities
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }    
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
    }
}
