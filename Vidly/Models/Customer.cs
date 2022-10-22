using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "please enter customer's name!")]

        [StringLength(255)]
        public string Name { get; set; }


        [Display(Name = "Date of Birth")]


        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

        [Display(Name = "SubscribeToNewsLetter?")]
        public bool IsSubscribedToNewsLetter { get; set; }


        [Display(Name = "Membership Type")]
        public MembershipType MembershipType { get; set; }

        [Display(Name = "MemberShipType")]
        [Required]

        public byte MembershipTypeId { get; set; }
    }
}