using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CheckExtention
{
    public static partial class IsExtention
    {
        public static IsObjectString Is(this string obj)
        {
            IsObjectString _IsObjectString = new IsObjectString();
            _IsObjectString.Value = obj;
            return _IsObjectString;
        }
    }

    public partial class IsObjectString : IsObject<IsObjectString, String>
    {
        public bool Email()
        {
            return LogicReturn(Is.Email(Value));
        }

        public bool Assigned()
        {
            return LogicReturn(Is.Assigned(Value));
        }

        public bool Url()
        {
            return LogicReturn(Is.Url(Value));
        }

        public bool CreditCard()
        {
            return LogicReturn(Is.CreditCard(Value));
        }
    }
}
