using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Hotel_Management_System.Models
{
    
    
    public class Staff
    {
        [Key]
        [Required(ErrorMessage = "StaffId must be specified")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        
        public int StaffId { get; set; }
        [DataMember]
        [Required]
        public string EmployeeName { get; set; }
        [DataMember]
        [Required]
        public string EmployeeAddress { get; set; }
        [DataMember]
        [Required]
        public double Salary { get; set; }
        [DataMember]
        [Required]
        /* [Range(18,50,ErrorMessage ="Please Eneter between 18 to 50")]*/
        public int Age { get; set; }
        [DataMember]
        [Required]
        public string Occupation { get; set; }
        [DataMember]
        [Required]
       /* [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please Enter valid Email")]*/
        public string Email { get; set; }

    }
}
