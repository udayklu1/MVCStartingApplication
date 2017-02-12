using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCStartingApplication.Models
{
    public class CheckingAccount
    {
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"\d{6,10}", ErrorMessage = "Account number must be between 6 to 10")]
        //[StringLength(10)]
       // [Column(TypeName="varchar")]
        [Display(Name = "Account #")]
        public string AccountNumber { get; set; }
        [Required]
        [Display(Name = "First name")]
        public String FirstName { get; set; }
        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        public string Name
        {
            get
            {
                return String.Format("{0} {1}", this.FirstName, LastName);
            }
        }
        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }

        public virtual ApplicationUser User { get; set; }

        public string ApplcationUserId { get; set; }
    }
}
