using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Hotel_Management_System.Models
{
    public class Issuebill
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IssueBillId { get; set; }

        [DataMember]

        public int RoomNo { get; set; }

        [DataMember]

        public int BillNo { get; set; }
        [DataMember]

        public int Quantity { get; set; }
        [DataMember]

        public double Price { get; set; }
        [DataMember]

        public double Taxes { get; set; }
        [DataMember]

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }
        [DataMember]
        public double Services { get; set; }

        public double Total { get; set; }
    }
}