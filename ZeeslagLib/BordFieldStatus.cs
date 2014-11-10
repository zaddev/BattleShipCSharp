using System;

namespace ZeeslagLib
{
    [Flags]
    public enum BordFieldStatus
    {
        Bezet = 1,
        Vrij = 2,
        Geraden = 4,
        Ongeraden = 8
    }
}
