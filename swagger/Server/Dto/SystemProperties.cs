using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Dto
{
    public class SystemProperties : Dictionary<SystemType, object>
    {
    }


    public enum SystemType
    {
        Type1,
        Type2,
        Type3
    }
}
