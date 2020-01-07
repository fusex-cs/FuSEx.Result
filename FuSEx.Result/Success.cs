using System;

namespace FuSEx.Result
{
    public sealed class Success<TSuccess, TError> : Result<TSuccess, TError>
    {
        public TSuccess Value { get; }

        public Success(TSuccess value)
        {
            Value = value;
        }

        public override Result<TSuccess, TError> OnSuccess(Action<TSuccess> onSuccess)
        {
            onSuccess(Value);
            return this;
        }

        public override Result<TSuccess, TError> OnError(Action<TError> onError) => this;
    }
}