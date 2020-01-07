using System;

namespace FuSEx.Result
{
    public abstract class Result<TSuccess, TError>
    {
        public abstract Result<TSuccess, TError> OnSuccess(Action<TSuccess> onSuccess);
        public abstract Result<TSuccess, TError> OnError(Action<TError> onError);
    }
}
