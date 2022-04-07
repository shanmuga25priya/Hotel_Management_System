using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
namespace Hotel_Management_System.Models
{
    public class SetRates
    {
        [Required(ErrorMessage = "Total must be specified")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        [Key]
        public int SetRateId { get; set; }
        [DataMember]
        [Required]
        public int NumberOfGuests { get; set; }
        
        [DataMember]
        [Required]
        public int Day { get; set; }
      
        [DataMember]
        [Required]
        public double OneNightPrice { get; set; }
        [DataMember]
        [Required]
        public double Extention { get; set; }


    }
}