using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    interface IIterator
    {
        object First();
        void Next();
        bool IsDone();
        object CurrentItem();
    }
}
