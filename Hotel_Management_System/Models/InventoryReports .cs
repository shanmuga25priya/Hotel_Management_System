using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Hotel_Management_System.Models
{
    public class InventoryReports
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        [Required]
        public int Id { get; set; }
        [DataMember]
        public double TotalIncome { get; set; }

        [DataMember]
        public double MaintainanceCost { get; set; }
        [DataMember]
      
        public double EmployeeSalary { get; set; }
        [DataMember]
        public double TotalProfit { get; set; }
    }
}