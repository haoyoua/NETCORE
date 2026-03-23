using System.ComponentModel.DataAnnotations;
using CoreApi.Model.Common;
using CoreApi.Model.Enums;

namespace CoreApi.Model.Requests
{
    public class UserQueryRequest : PageQuery
    {
        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string NickName { get; set; }

        public UserStatus? Status { get; set; }
    }
}
