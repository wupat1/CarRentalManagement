﻿using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
    public class Customer: BaseDomainModel 
    {
        [Required]
        [StringLength(100,MinimumLength=2,ErrorMessage="First Name does not meet length requirements")] 
        public string? FirstName { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Last Name does not meet length requirements")]
        public string? LastName { get; set; }
        [Required]
        [RegularExpression(@"^[STFGstfg]\d{7}[A-Aa-z]", ErrorMessage ="Driving License does not meet NRIC requirements")]
        public string? DrivingLicense { get; set; }
        public string? Address { get; set;}
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"(6|8|9)\d{7}[A-Aa-z]", ErrorMessage = "Contact number is not a valid number")]
        public string? ContactNumber { get; set;}
        [Required]
        [DataType (DataType.EmailAddress, ErrorMessage ="Email Address is not a valid email")]
        [EmailAddress]
        public string? EmailAddress { get; set;}
        public List<Booking>? Bookings;
    }
}