using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Hotel_Management_System.Models
{
    [DataContract(IsReference = true)]
    public class Guest
    {
        [Key]
        [Required(ErrorMessage = "GuestId must be specified")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    
        public int GuestId { get; set; }

        [DataMember]
     
        public int RoomNo { get; set; }

        [DataMember]
        [Required]
        
        public string PhoneNumber { get; set; }
        [DataMember]
        public string Company { get; set; }
        [DataMember]
        [Required]
        public string Name { get; set; }
        [DataMember]
        [Required]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage ="Please Enter valid Email")]
        public string Email { get; set; }

        public string Gender { get; set; }
        [DataMember]
        [Required]
        public string Address { get; set; }
        [DataMember]
        public string Subject { get; set; }
        [DataMember]
        public string Body { get; set; }


    }
}