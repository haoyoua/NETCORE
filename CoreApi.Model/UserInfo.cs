using System.ComponentModel.DataAnnotations;
using CoreApi.Model.Entities;
using CoreApi.Model.Enums;

namespace CoreApi.Model
{
    public class UserInfo : BaseAuditEntity<int>
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
        [StringLength(200)]
        public string PasswordHash { get; set; }

        public UserStatus Status { get; set; } = UserStatus.Enabled;
    }
}
