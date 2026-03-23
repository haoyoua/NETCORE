using System.ComponentModel.DataAnnotations;
using CoreApi.Model.Enums;

namespace CoreApi.Model.Requests
{
    public class UserCreateRequest
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string NickName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Phone]
        [StringLength(20)]
        public string Phone { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }

        public UserStatus Status { get; set; } = UserStatus.Enabled;
    }
}
