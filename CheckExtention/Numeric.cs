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
        public static IsObjectNumeric<decimal> Is(this decimal obj)
        {
            IsObjectNumeric<decimal> _IsObjectNumeric = new IsObjectNumeric<decimal>();
            _IsObjectNumeric.Value = obj;
            return _IsObjectNumeric;
        }

        public static IsObjectNumeric<double> Is(this double obj)
        {
            IsObjectNumeric<double> _IsObjectNumeric = new IsObjectNumeric<double>();
            _IsObjectNumeric.Value = obj;
            return _IsObjectNumeric;
        }

        public static IsObjectNumeric<long> Is(this long obj)
        {
            IsObjectNumeric<long> _IsObjectNumeric = new IsObjectNumeric<long>();
            _IsObjectNumeric.Value = obj;
            return _IsObjectNumeric;
        }

        public static IsObjectNumeric<int> Is(this int obj)
        {
            IsObjectNumeric<int> _IsObjectNumeric = new IsObjectNumeric<int>();
            _IsObjectNumeric.Value = obj;
            return _IsObjectNumeric;
        }

        public static IsObjectNumeric<Int16> Is(this Int16 obj)
        {
            IsObjectNumeric<Int16> _IsObjectNumeric = new IsObjectNumeric<Int16>();
            _IsObjectNumeric.Value = obj;
            return _IsObjectNumeric;
        }


        public static IsObjectNumeric<UInt16> Is(this UInt16 obj)
        {
            IsObjectNumeric<UInt16> _IsObjectNumeric = new IsObjectNumeric<UInt16>();
            _IsObjectNumeric.Value = obj;
            return _IsObjectNumeric;
        }

        public static IsObjectNumeric<UInt32> Is(this UInt32 obj)
        {
            IsObjectNumeric<UInt32> _IsObjectNumeric = new IsObjectNumeric<UInt32>();
            _IsObjectNumeric.Value = obj;
            return _IsObjectNumeric;
        }
        public static IsObjectNumeric<UInt64> Is(this UInt64 obj)
        {
            IsObjectNumeric<UInt64> _IsObjectNumeric = new IsObjectNumeric<UInt64>();
            _IsObjectNumeric.Value = obj;
            return _IsObjectNumeric;
        }

        public static IsObjectNumeric<Single> Is(this Single obj)
        {
            IsObjectNumeric<Single> _IsObjectNumeric = new IsObjectNumeric<Single>();
            _IsObjectNumeric.Value = obj;
            return _IsObjectNumeric;
        }

    }

    public partial class IsObjectNumeric<T> : IsObject<IsObjectNumeric<T>,T>
    {
        public bool Zero()
        {
            bool CheckStatus = false;
            
            if (typeof(T) != typeof(Int16)) CheckStatus = Is.Zero(Convert.ToInt16(Value));
            if (typeof(T) != typeof(Int32)) CheckStatus = Is.Zero(Convert.ToInt32(Value));
            if (typeof(T) != typeof(Int64)) CheckStatus = Is.Zero(Convert.ToInt64(Value));
            if (typeof(T) != typeof(UInt16)) CheckStatus = Is.Zero(Convert.ToUInt16(Value));
            if (typeof(T) != typeof(UInt32)) CheckStatus = Is.Zero(Convert.ToUInt32(Value));
            if (typeof(T) != typeof(UInt64)) CheckStatus = Is.Zero(Convert.ToUInt64(Value));
            if (typeof(T) != typeof(Decimal)) CheckStatus = Is.Zero(Convert.ToDecimal(Value));
            if (typeof(T) != typeof(Double)) CheckStatus = Is.Zero(Convert.ToDouble(Value));
            if (typeof(T) != typeof(Single)) CheckStatus = Is.Zero(Convert.ToSingle(Value));

            return LogicReturn(CheckStatus);
        }

        public bool Positive()
        {
            bool CheckStatus = false;

            if (typeof(T) != typeof(Int16)) CheckStatus = Is.Positive(Convert.ToInt16(Value));
            if (typeof(T) != typeof(Int32)) CheckStatus = Is.Positive(Convert.ToInt32(Value));
            if (typeof(T) != typeof(Int64)) CheckStatus = Is.Positive(Convert.ToInt64(Value));
            if (typeof(T) != typeof(UInt16)) CheckStatus = Is.Positive(Convert.ToUInt16(Value));
            if (typeof(T) != typeof(UInt32)) CheckStatus = Is.Positive(Convert.ToUInt32(Value));
            if (typeof(T) != typeof(UInt64)) CheckStatus = Is.Positive(Convert.ToUInt64(Value));
            if (typeof(T) != typeof(Decimal)) CheckStatus = Is.Positive(Convert.ToDecimal(Value));
            if (typeof(T) != typeof(Double)) CheckStatus = Is.Positive(Convert.ToDouble(Value));
            if (typeof(T) != typeof(Single)) CheckStatus = Is.Positive(Convert.ToSingle(Value));

            return LogicReturn(CheckStatus);
        }

        public bool Negative()
        {
            bool CheckStatus = false;

            if (typeof(T) != typeof(Int16)) CheckStatus = Is.Negative(Convert.ToInt16(Value));
            if (typeof(T) != typeof(Int32)) CheckStatus = Is.Negative(Convert.ToInt32(Value));
            if (typeof(T) != typeof(Int64)) CheckStatus = Is.Negative(Convert.ToInt64(Value));
            if (typeof(T) != typeof(UInt16)) CheckStatus = Is.Negative(Convert.ToUInt16(Value));
            if (typeof(T) != typeof(UInt32)) CheckStatus = Is.Negative(Convert.ToUInt32(Value));
            if (typeof(T) != typeof(UInt64)) CheckStatus = Is.Negative(Convert.ToUInt64(Value));
            if (typeof(T) != typeof(Decimal)) CheckStatus = Is.Negative(Convert.ToDecimal(Value));
            if (typeof(T) != typeof(Double)) CheckStatus = Is.Negative(Convert.ToDouble(Value));
            if (typeof(T) != typeof(Single)) CheckStatus = Is.Negative(Convert.ToSingle(Value));

            return LogicReturn(CheckStatus);
        }

        public bool Equal(T CompareValue)
        {
            bool CheckStatus = false;

            if (typeof(T) != typeof(Int16)) CheckStatus = Is.Equal(Convert.ToInt16(Value), Convert.ToInt16(CompareValue));
            if (typeof(T) != typeof(Int32)) CheckStatus = Is.Equal(Convert.ToInt32(Value), Convert.ToInt32(CompareValue));
            if (typeof(T) != typeof(Int64)) CheckStatus = Is.Equal(Convert.ToInt64(Value), Convert.ToInt64(CompareValue));
            if (typeof(T) != typeof(UInt16)) CheckStatus = Is.Equal(Convert.ToUInt16(Value), Convert.ToUInt16(CompareValue));
            if (typeof(T) != typeof(UInt32)) CheckStatus = Is.Equal(Convert.ToUInt32(Value), Convert.ToUInt32(CompareValue));
            if (typeof(T) != typeof(UInt64)) CheckStatus = Is.Equal(Convert.ToUInt64(Value), Convert.ToUInt64(CompareValue));
            if (typeof(T) != typeof(Decimal)) CheckStatus = Is.Equal(Convert.ToDecimal(Value), Convert.ToDecimal(CompareValue));
            if (typeof(T) != typeof(Double)) CheckStatus = Is.Equal(Convert.ToDouble(Value), Convert.ToDouble(CompareValue));
            if (typeof(T) != typeof(Single)) CheckStatus = Is.Equal(Convert.ToSingle(Value), Convert.ToSingle(CompareValue));
            
            return LogicReturn(CheckStatus);
        }

        public bool Even()
        {
            bool CheckStatus = false;

            if (typeof(T) != typeof(Int16)) CheckStatus = Is.Even(Convert.ToInt16(Value));
            if (typeof(T) != typeof(Int32)) CheckStatus = Is.Even(Convert.ToInt32(Value));
            if (typeof(T) != typeof(Int64)) CheckStatus = Is.Even(Convert.ToInt64(Value));
            if (typeof(T) != typeof(UInt16)) CheckStatus = Is.Even(Convert.ToUInt16(Value));
            if (typeof(T) != typeof(UInt32)) CheckStatus = Is.Even(Convert.ToUInt32(Value));
            if (typeof(T) != typeof(UInt64)) CheckStatus = Is.Even(Convert.ToUInt64(Value));
            if (typeof(T) != typeof(Decimal)) CheckStatus = Is.Even(Convert.ToDecimal(Value));
            if (typeof(T) != typeof(Double)) CheckStatus = Is.Even(Convert.ToDouble(Value));
            if (typeof(T) != typeof(Single)) CheckStatus = Is.Even(Convert.ToSingle(Value));

            return LogicReturn(CheckStatus);
        }

        public bool Odd()
        {
            bool CheckStatus = false;

            if (typeof(T) != typeof(Int16)) CheckStatus = Is.Odd(Convert.ToInt16(Value));
            if (typeof(T) != typeof(Int32)) CheckStatus = Is.Odd(Convert.ToInt32(Value));
            if (typeof(T) != typeof(Int64)) CheckStatus = Is.Odd(Convert.ToInt64(Value));
            if (typeof(T) != typeof(UInt16)) CheckStatus = Is.Odd(Convert.ToUInt16(Value));
            if (typeof(T) != typeof(UInt32)) CheckStatus = Is.Odd(Convert.ToUInt32(Value));
            if (typeof(T) != typeof(UInt64)) CheckStatus = Is.Odd(Convert.ToUInt64(Value));
            if (typeof(T) != typeof(Decimal)) CheckStatus = Is.Odd(Convert.ToDecimal(Value));
            if (typeof(T) != typeof(Double)) CheckStatus = Is.Odd(Convert.ToDouble(Value));
            if (typeof(T) != typeof(Single)) CheckStatus = Is.Odd(Convert.ToSingle(Value));

            return LogicReturn(CheckStatus);
        }

        public bool Above(T CompareValue)
        {
            bool CheckStatus = false;

            if (typeof(T) != typeof(Int16)) CheckStatus = Is.Above(Convert.ToInt16(Value), Convert.ToInt16(CompareValue));
            if (typeof(T) != typeof(Int32)) CheckStatus = Is.Above(Convert.ToInt32(Value), Convert.ToInt32(CompareValue));
            if (typeof(T) != typeof(Int64)) CheckStatus = Is.Above(Convert.ToInt64(Value), Convert.ToInt64(CompareValue));
            if (typeof(T) != typeof(UInt16)) CheckStatus = Is.Above(Convert.ToUInt16(Value), Convert.ToUInt16(CompareValue));
            if (typeof(T) != typeof(UInt32)) CheckStatus = Is.Above(Convert.ToUInt32(Value), Convert.ToUInt32(CompareValue));
            if (typeof(T) != typeof(UInt64)) CheckStatus = Is.Above(Convert.ToUInt64(Value), Convert.ToUInt64(CompareValue));
            if (typeof(T) != typeof(Decimal)) CheckStatus = Is.Above(Convert.ToDecimal(Value), Convert.ToDecimal(CompareValue));
            if (typeof(T) != typeof(Double)) CheckStatus = Is.Above(Convert.ToDouble(Value), Convert.ToDouble(CompareValue));
            if (typeof(T) != typeof(Single)) CheckStatus = Is.Above(Convert.ToSingle(Value), Convert.ToSingle(CompareValue));

            return LogicReturn(CheckStatus);
        }

        public bool Under(T CompareValue)
        {
            bool CheckStatus = false;

            if (typeof(T) != typeof(Int16)) CheckStatus = Is.Under(Convert.ToInt16(Value), Convert.ToInt16(CompareValue));
            if (typeof(T) != typeof(Int32)) CheckStatus = Is.Under(Convert.ToInt32(Value), Convert.ToInt32(CompareValue));
            if (typeof(T) != typeof(Int64)) CheckStatus = Is.Under(Convert.ToInt64(Value), Convert.ToInt64(CompareValue));
            if (typeof(T) != typeof(UInt16)) CheckStatus = Is.Under(Convert.ToUInt16(Value), Convert.ToUInt16(CompareValue));
            if (typeof(T) != typeof(UInt32)) CheckStatus = Is.Under(Convert.ToUInt32(Value), Convert.ToUInt32(CompareValue));
            if (typeof(T) != typeof(UInt64)) CheckStatus = Is.Under(Convert.ToUInt64(Value), Convert.ToUInt64(CompareValue));
            if (typeof(T) != typeof(Decimal)) CheckStatus = Is.Under(Convert.ToDecimal(Value), Convert.ToDecimal(CompareValue));
            if (typeof(T) != typeof(Double)) CheckStatus = Is.Under(Convert.ToDouble(Value), Convert.ToDouble(CompareValue));
            if (typeof(T) != typeof(Single)) CheckStatus = Is.Under(Convert.ToSingle(Value), Convert.ToSingle(CompareValue));

            return LogicReturn(CheckStatus);
        }
    }
}
