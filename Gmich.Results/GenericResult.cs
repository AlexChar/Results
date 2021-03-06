﻿namespace Gmich.Results
{
    public class Result<TValue> : Result
    {
        private readonly TValue value;

        public virtual TValue Value
        {
            get
            {
                return value;
            }
        }

        public override string ToString()
        {
            return $"Success: { Success } , State: {State} , ValueType: {typeof(TValue)} , Value: {Value?.ToString() ?? "null"} , Message: {ErrorMessage ?? ""}";
        }

        protected internal Result(TValue value, State status, string error)
            : base(status, error)
        {
            this.value = value;
        }

        public static implicit operator Result<TValue>(TValue someValue)
        {
            return Result.Ok(someValue);
        }
    }

}
