using System;
using System.Collections.Generic;
using System.Text;

namespace ManipulandoStrings
{
    public interface IStream
    {
        char GetNext();
        bool HasNext();
        int Index();
    }
}
