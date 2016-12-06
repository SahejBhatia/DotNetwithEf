using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenithDataLib
{
    public class Activity
    {
        [Key]
        public int ActivityID { get; set; }

        [Display(Name = "Description")]

        [StringLength(70, ErrorMessage = "The {0} must be between {2} and {1} characters.", MinimumLength = 2)]
        public string ActivityDescrption { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
