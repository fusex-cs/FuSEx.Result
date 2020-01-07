using System;

namespace FuSEx.Result
{
    public sealed class Error<TSuccess, TError> : Result<TSuccess, TError>
    {
        public TError ErrorValue { get; }

        public Error(TError errorValue)
        {
            ErrorValue = errorValue;
        }

        public override Result<TSuccess, TError> OnError(Action<TError> onError)
        {
            onError(ErrorValue);
            return this;
        }

        public override Result<TSuccess, TError> OnSuccess(Action<TSuccess> onSuccess) => this;
    }
}