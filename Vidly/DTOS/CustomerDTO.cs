using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.DTOS
{
    public class CustomerDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "please enter customer's name!")]

        [StringLength(255)]
        public string Name { get; set; }

        //[Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }

        [Required]
        public byte MembershipTypeId { get; set; }
    }
}