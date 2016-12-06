using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenithDataLib
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Display(Name = "Event starts  :")]

        [Required(ErrorMessage = "Must enter a start Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MMMM dd, yyyy}")]
        public DateTime EventFromDateaAndTime { get; set; }


        [Display(Name = "Event ends :")]
        [Required(ErrorMessage = "Must enter an end date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MMMM dd, yyyy}")]
        public DateTime EventToDateAndTime { get; set; }

        public string EnteredByUserName { get; set; }

        [Display(Name = "Activity Name: ")]
        [Required(ErrorMessage = "Must enter Actvity name")]
        public string activity { get; set; }

        public DateTime CreationDate { get; set; }

        public bool IsActive { get; set; }


    }
}
