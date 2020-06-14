using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
