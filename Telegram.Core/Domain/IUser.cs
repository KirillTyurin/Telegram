using System;
using System.Collections.Generic;
using System.Text;

namespace Telegram.Core.Domain
{
    public interface IUser
    {
        Guid UserId { get; set; }
        string UserFirstName { get; set; }
        string UserLastName { get; set; }
        string UserEmail { get; set; }

    }
}
