
namespace CheckExtention
{
    public class IsObject<T, TCheckType> where T : IsObject<T, TCheckType>, new()
    {
        internal TCheckType Value;
        internal bool DefaultReturnValue = true;

        public IsObject(TCheckType _Value)
        {
            Value = _Value;
        }

        internal IsObject()
        {

        }

        public T Not()
        {
            T _Not;
            _Not = new T();
            _Not.Value = Value;
            _Not.DefaultReturnValue = DefaultReturnValue ? false : true; // for Not().Not().Not().Not() ... usage
            return _Not;
        }

        internal bool LogicReturn(bool CheckResult){
            if (DefaultReturnValue)
            {
                return CheckResult;
            }
            else
            {
                return !CheckResult;
            }
        }
    }
}
