using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "First Name does not meet length requirements")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Last Name does not meet length requirements")]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]{2}[0-9]{2}[A-Z]{2}[0-9]{7}$", ErrorMessage = "Driving License does not meet NIC requirements")] //NIRC Regular Expression
        public string DrivingLicense { get; set; }

        // Address is not a required property, it is intentionally not given any data annotations
        public string Address { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\d{8})|(\d{7})$", ErrorMessage = "Contact Number is not a valid phone number")]
        public string ContactNumber { get; set; }

        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email Address is not a valid email")]
        [EmailAddress]
        public string EmailAddress { get; set; }

        public virtual IList<Booking> Bookings { get; set; }
    }
}