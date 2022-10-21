using System.ComponentModel.DataAnnotations;//that permits you applie validations using require, and get in the ModelState

namespace PartyInvites.Models{
    public class GuestResponse {


        [Required(ErrorMessage ="Please Enter Your Name")]
        public string Name { get; set; }  
        [Required(ErrorMessage ="Please Enter Your Email")]
        public string Email { get; set; }  
        [Required(ErrorMessage ="Please Enter Your Phone")]
        public string Phone { get; set; }  
        [Required(ErrorMessage ="Please specify wheter you'll attend")]
        public bool? WillAttend { get; set; }  
    }
}