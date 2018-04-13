# Entity Generator

## Generate all Entity.Model from selected database with all properties with respective data type as follow :


using System;

namespace EntityGeneratorForm
{
    public class Student
    {
        public int Id { get; set; }
        
        public DateTime? DOB { get; set; }
         
        public decimal Salary { get; set; }
        
        public string Email { get; set; }
        
        public bool IsActive { get; set; }
        
    }
}



