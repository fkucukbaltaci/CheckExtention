using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckExtention
{
    public static partial class IsExtention
    {
        public static IsObjectObject Is(this object obj)
        {
            IsObjectObject _IsObjectObject = new IsObjectObject();
            _IsObjectObject.Value = obj;
            return _IsObjectObject;
        }
    }

    public partial class IsObjectObject : IsObject<IsObjectObject, Object>
    {
        public bool Null()
        {
            return LogicReturn(Is.Null(Value));
        }

        public bool Numeric()
        {
            return LogicReturn(Is.Numeric(Value));
        }

        public bool Number()
        {
            return LogicReturn(Is.Number(Value));
        }
    }
}
