﻿namespace Adnc.Usr.Application.Contracts.Dtos
{
    /// <summary>
    /// 登录信息
    /// </summary>
    public class UserLoginDto : IInputDto
    {
        /// <summary>
        /// 账户
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
    }
}