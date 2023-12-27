using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.domain.Enums
{
    public enum ResponseResultType
    {
        Success,
        NotFound,
        AlreadyExists,
        NoChanges,
        ValidationError
    }
}
