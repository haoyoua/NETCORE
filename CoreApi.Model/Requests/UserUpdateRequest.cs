using System.ComponentModel.DataAnnotations;
using CoreApi.Model.Enums;

namespace CoreApi.Model.Requests
{
    public class UserUpdateRequest
    {
        [Range(1, int.MaxValue)]
        public int Id { get; set; }

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

        public UserStatus Status { get; set; }
    }
}
