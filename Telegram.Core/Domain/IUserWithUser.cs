using System;
using System.Collections.Generic;
using System.Text;

namespace Telegram.Core.Domain
{
    public interface IUserWithUser : IUser
    {
        string Password { get; set; }
    }
}
