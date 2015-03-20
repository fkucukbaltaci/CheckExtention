using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace CheckExtention
{
    public static class Is
    {
        #region "Numeric Check"
        public static bool Zero(Int16 Value) { return Value == 0; }
        public static bool Zero(Int32 Value) { return Value == 0; }
        public static bool Zero(Int64 Value) { return Value == 0; }
        public static bool Zero(UInt16 Value) { return Value == 0; }
        public static bool Zero(UInt32 Value) { return Value == 0; }
        public static bool Zero(UInt64 Value) { return Value == 0; }
        public static bool Zero(Decimal Value) { return Value == 0; }
        public static bool Zero(Double Value) { return Value == 0; }
        public static bool Zero(Single Value) { return Value == 0; }


        public static bool Positive(Int16 Value) { return Value > 0; }
        public static bool Positive(Int32 Value) { return Value > 0; }
        public static bool Positive(Int64 Value) { return Value > 0; }
        public static bool Positive(UInt16 Value) { return Value > 0; }
        public static bool Positive(UInt32 Value) { return Value > 0; }
        public static bool Positive(UInt64 Value) { return Value > 0; }
        public static bool Positive(Decimal Value) { return Value > 0; }
        public static bool Positive(Double Value) { return Value > 0; }
        public static bool Positive(Single Value) { return Value > 0; }

        public static bool Negative(Int16 Value) { return Value < 0; }
        public static bool Negative(Int32 Value) { return Value < 0; }
        public static bool Negative(Int64 Value) { return Value < 0; }
        public static bool Negative(UInt16 Value) { return Value < 0; }
        public static bool Negative(UInt32 Value) { return Value < 0; }
        public static bool Negative(UInt64 Value) { return Value < 0; }
        public static bool Negative(Decimal Value) { return Value < 0; }
        public static bool Negative(Double Value) { return Value < 0; }
        public static bool Negative(Single Value) { return Value < 0; }

        public static bool Equal(Int16 Value, Int16 CompareValue) { return Value == CompareValue; }
        public static bool Equal(Int32 Value, Int32 CompareValue) { return Value == CompareValue; }
        public static bool Equal(Int64 Value, Int64 CompareValue) { return Value == CompareValue; }
        public static bool Equal(UInt16 Value, UInt16 CompareValue) { return Value == CompareValue; }
        public static bool Equal(UInt32 Value, UInt32 CompareValue) { return Value == CompareValue; }
        public static bool Equal(UInt64 Value, UInt64 CompareValue) { return Value == CompareValue; }
        public static bool Equal(Decimal Value, Decimal CompareValue) { return Value == CompareValue; }
        public static bool Equal(Double Value, Double CompareValue) { return Value == CompareValue; }
        public static bool Equal(Single Value, Single CompareValue) { return Value == CompareValue; }

        public static bool Even(Int16 Value) { return Value % 2 == 0; }
        public static bool Even(Int32 Value) { return Value % 2 == 0; }
        public static bool Even(Int64 Value) { return Value % 2 == 0; }
        public static bool Even(UInt16 Value) { return Value % 2 == 0; }
        public static bool Even(UInt32 Value) { return Value % 2 == 0; }
        public static bool Even(UInt64 Value) { return Value % 2 == 0; }
        public static bool Even(Decimal Value) { return Math.Floor(Value) % 2 == 0; }
        public static bool Even(Double Value) { return Math.Floor(Value) % 2 == 0; }
        public static bool Even(Single Value) { return Math.Floor(Value) % 2 == 0; }

        public static bool Odd(Int16 Value) { return Value % 2 != 0; }
        public static bool Odd(Int32 Value) { return Value % 2 != 0; }
        public static bool Odd(Int64 Value) { return Value % 2 != 0; }
        public static bool Odd(UInt16 Value) { return Value % 2 != 0; }
        public static bool Odd(UInt32 Value) { return Value % 2 != 0; }
        public static bool Odd(UInt64 Value) { return Value % 2 != 0; }
        public static bool Odd(Decimal Value) { return Math.Floor(Value) % 2 != 0; }
        public static bool Odd(Double Value) { return Math.Floor(Value) % 2 != 0; }
        public static bool Odd(Single Value) { return Math.Floor(Value) % 2 != 0; }

        public static bool Above(Int16 Value, Int16 CompareValue) { return Value > CompareValue; }
        public static bool Above(Int32 Value, Int32 CompareValue) { return Value > CompareValue; }
        public static bool Above(Int64 Value, Int64 CompareValue) { return Value > CompareValue; }
        public static bool Above(UInt16 Value, UInt16 CompareValue) { return Value > CompareValue; }
        public static bool Above(UInt32 Value, UInt32 CompareValue) { return Value > CompareValue; }
        public static bool Above(UInt64 Value, UInt64 CompareValue) { return Value > CompareValue; }
        public static bool Above(Decimal Value, Decimal CompareValue) { return Value > CompareValue; }
        public static bool Above(Double Value, Double CompareValue) { return Value > CompareValue; }
        public static bool Above(Single Value, Single CompareValue) { return Value > CompareValue; }


        public static bool Under(Int16 Value, Int16 CompareValue) { return Value < CompareValue; }
        public static bool Under(Int32 Value, Int32 CompareValue) { return Value < CompareValue; }
        public static bool Under(Int64 Value, Int64 CompareValue) { return Value < CompareValue; }
        public static bool Under(UInt16 Value, UInt16 CompareValue) { return Value < CompareValue; }
        public static bool Under(UInt32 Value, UInt32 CompareValue) { return Value < CompareValue; }
        public static bool Under(UInt64 Value, UInt64 CompareValue) { return Value < CompareValue; }
        public static bool Under(Decimal Value, Decimal CompareValue) { return Value < CompareValue; }
        public static bool Under(Double Value, Double CompareValue) { return Value < CompareValue; }
        public static bool Under(Single Value, Single CompareValue) { return Value < CompareValue; }
        #endregion

        #region "String Check"
        public static bool Email(string Value)
        {
            return Regex.IsMatch(Value, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }

        public static bool Assigned(string Value)
        {
            return !string.IsNullOrEmpty(Value) && !string.IsNullOrWhiteSpace(Value) && !Convert.IsDBNull(Value);
        }

        public static bool Url(string Value)
        {
            bool Result = false;

            if (Is.Assigned(Value))
            {
                Result = Regex.IsMatch(Value,@"^(https?:\/\/)?([\da-z\.-]+)\.([a-z\.]{2,6})([\/\w \.-]*)*\/?$",RegexOptions.Compiled);
            }

            return Result;
        }
        public static bool CreditCard(string Value)
        {
            bool Result = false;

            if (Is.Assigned(Value))
            {
                Result = Regex.IsMatch(Value, @"^(?:(4[0-9]{12}(?:[0-9]{3})?)|(5[1-5][0-9]{14})|(6(?:011|5[0-9]{2})[0-9]{12})|(3[47][0-9]{13})|(3(?:0[0-5]|[68][0-9])[0-9]{11})|((?:2131|1800|35[0-9]{3})[0-9]{11}))$", RegexOptions.Compiled);
            }

            return Result;
        }

        #endregion

        #region "Object Check"
        public static bool Null(object Value)
        {
            return Convert.IsDBNull(Value) || Value == null;
        }

        public static bool Numeric(object Value)
        {
            return Microsoft.VisualBasic.Information.IsNumeric(Value);
        }

        public static bool Number(object Value)
        {
            bool Result = false;

            if (!Is.Null(Value) && Is.Assigned(Value.ToString()))
            {
                Result = Regex.IsMatch(Value.ToString(), @"^\d+$", RegexOptions.Compiled);
            }
            return Result;
        }
        #endregion
    }
}
