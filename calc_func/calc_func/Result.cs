using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace calc_func
{
    public abstract class Result
    {
        public abstract bool IsSuccess { get; }

        public static Result Success<T>(T value)
        {
            return new Success<T>(value);
        }

        public static Result Failure(string reason)
        {
            return new Failure(reason);
        }

        public override string ToString()
        {
            if (this is ICanBeFormattedAsString)
            {
                return ((ICanBeFormattedAsString) this).ValueAsString();
            }

            if (this is Failure)
            {
                return ((Failure) this).Reason;
            }

            return String.Empty;
        }
    }

    public interface ICanBeFormattedAsString
    {
        string ValueAsString();
    }

    public class Success<TValueType> : Result, ICanBeFormattedAsString
    {
        public TValueType Value { get; private set; }

        public override bool IsSuccess => true;
       
        public Success(TValueType value)
        {
            Value = value;
        }

        public string ValueAsString()
        {
            return Value.ToString();
        }
    }

    public class Failure : Result
    {
        public string Reason { get; private set; }

        public override bool IsSuccess => false;

        public Failure(string reason)
        {
            Reason = reason;
        }
    }
}
