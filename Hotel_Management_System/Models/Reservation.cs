using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Hotel_Management_System.Models
{


    public class Reservation
    {
        [Key]
        [Required(ErrorMessage = "RoomNo must be specified")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
           
         public int ReservationId { get; set; }
       
        [DataMember]

        public int RoomNo { get; set; }

        [DataMember]
        [Required]
        public int NumberOfChildren { get; set; }
        [DataMember]
        [Required]
        public int NumberOfAdults { get; set; }
        [DataMember]
        [Required]
        [Display(Name = "CheckInDate")]
        [DataType(DataType.Date)]
        public DateTime? CheckIn { get; set; }
        [DataMember]
        [Required]
        [Display(Name = "CheckOutDate")]
        [DataType(DataType.Date)]
        public DateTime? CheckOut { get; set; }

        [DataMember]
        [Required]
        public int NumberOfNights { get; set; }
        

    }
}