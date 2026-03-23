using System;
using CoreApi.Model.Enums;

namespace CoreApi.Model.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string NickName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public UserStatus Status { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
