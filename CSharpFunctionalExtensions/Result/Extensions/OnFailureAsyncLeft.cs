using System;
using System.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class AsyncResultExtensionsLeftOperand
    {
        public static async Task<Result<T>> OnFailure<T>(this Task<Result<T>> resultTask, Action action)
        {
            Result<T> result = await resultTask.ConfigureAwait(Result.DefaultConfigureAwait);
            return result.OnFailure(action);
        }

        public static async Task<Result> OnFailure(this Task<Result> resultTask, Action action)
        {
            Result result = await resultTask.ConfigureAwait(Result.DefaultConfigureAwait);
            return result.OnFailure(action);
        }

        public static async Task<Result<T>> OnFailure<T>(this Task<Result<T>> resultTask, Action<string> action)
        {
            Result<T> result = await resultTask.ConfigureAwait(Result.DefaultConfigureAwait);
            return result.OnFailure(action);
        }

        public static async Task<Result<T, E>> OnFailure<T, E>(this Task<Result<T, E>> resultTask, Action<E> action)
        {
            Result<T, E> result = await resultTask.ConfigureAwait(Result.DefaultConfigureAwait);
            return result.OnFailure(action);
        }

        public static async Task<Result> OnFailure(this Task<Result> resultTask, Action<string> action)
        {
            Result result = await resultTask.ConfigureAwait(Result.DefaultConfigureAwait);
            return result.OnFailure(action);
        }
    }
}
