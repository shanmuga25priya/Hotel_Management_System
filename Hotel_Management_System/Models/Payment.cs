using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Windows.Input;

namespace Hotel_Management_System.Models
{

    public class Payment
    {
        [Key]
        [Required(ErrorMessage = "CreditCardDetails must be specified")]
       
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int RoomId { get; set; }

        [DataMember]
        public int RoomNo { get; set; }

        [DataMember]
        [Required]
       
        public string CreditCardDetails { get; set; }
        [DataMember]
        [Required]
        public  double Total { get; set; }

        [DataMember]
        [Required]

        [Display(Name = "PayTime")]
        [DataType(DataType.Date)]
        public DateTime? PayTime { get; set; }
    }
}