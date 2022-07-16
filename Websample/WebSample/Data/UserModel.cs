using System;
using System.ComponentModel.DataAnnotations;
using Jexpa.Core;

namespace WebSample.Data
{
    #nullable enable
    public class UserModel
    {
        public long Id { get; set; }
        public long BrandId { get; set; }
        public string? UserCode { get; set; }
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; } = String.Empty;
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = String.Empty;
        [StringLength(6, ErrorMessage = "The passphrase is too long.")]
        public string Passphrase { get; set; } = String.Empty;
        public UserType UserType { get; set; } = UserType.Unset;
        public bool? IsEmailVerified { get; set; }
        public bool? IsUserVerified { get; set; }
        public byte? RiskMark { get; set; }
        public UserStatus Status { get; set; } = UserStatus.Inactive;
        public DateTime? LastModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? NickName { get; set; }
        public string? Avatar { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; } = String.Empty;
        public string? Phone1 { get; set; }
        public string? Phone2 { get; set; }
        public string? Phone3 { get; set; }
        public string? Website { get; set; }
        public long? TimezoneId { get; set; }
        public long PackageId { get; set; }
        public short? TrackingLevel { get; set; }
        public int? MaxAllowedDeviceNumber { get; set; }
        public string? ThemeStyle { get; set; }
        public bool? IsSignInDetectionEnabled { get; set; }
        public DateTime? ExpiryDate { get; set; }
    }
}
