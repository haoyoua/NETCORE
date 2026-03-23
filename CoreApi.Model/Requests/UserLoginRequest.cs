using System.ComponentModel.DataAnnotations;

namespace CoreApi.Model.Requests
{
    public class UserLoginRequest
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }
    }
}
