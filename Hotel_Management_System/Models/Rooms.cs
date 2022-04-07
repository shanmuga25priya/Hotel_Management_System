using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
namespace Hotel_Management_System.Models
{
   
    public class Rooms
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
       
        [Key]
        [Required(ErrorMessage = "Enter Room Number")]
        public int RoomNumber { get; set; }
        
        [Required(ErrorMessage = "Enter Room Type")]                   
        public string RoomType { get; set; }

        public string IsOccupied { get; set; }
     
        [Required]
        public Nullable<long> RoomCost { get; set; }

        [Required(ErrorMessage = "checkin must be specified")]
        [DataMember]
       
        [DataType(DataType.Date)]
        public DateTime? CheckIn { get; set; }

        [Required(ErrorMessage = "checkout must be specified")]
        [DataMember]
       
        [DataType(DataType.Date)]
        public DateTime? CheckOut { get; set; }

    }
}