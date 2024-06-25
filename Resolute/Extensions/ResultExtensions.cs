using System.Text.RegularExpressions;
using Resolute.Results;

public static class ResultExtensions
{
    /// <summary>
    /// Converts a value to a successful <see cref="Result{TValue}"/>.
    /// </summary>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <param name="value">The value to convert.</param>
    /// <returns>A <see cref="Result{TValue}"/> with a success status.</returns>
    public static Result<TValue> ToResult<TValue>(this TValue value)
    {
        return Result.Success(value);
    }

    /// <summary>
    /// Executes the appropriate function based on the result status.
    /// </summary>
    /// <typeparam name="TError">The type of the error.</typeparam>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <typeparam name="TOutcome">The type of the outcome.</typeparam>
    /// <param name="result">The result to match.</param>
    /// <param name="onError">The function to execute if the result is an error.</param>
    /// <param name="onSuccess">The function to execute if the result is a success.</param>
    /// <returns>The outcome of the executed function.</returns>
    public static TOutcome Match<TError, TValue, TOutcome>(this Result<TError, TValue> result, Func<TError, TOutcome> onError, Func<TValue, TOutcome> onSuccess)
    {
        if (result.Succeeded)
        {
            var outcome = onSuccess(result.Value);

            return outcome;
        }
        else
        {
            var outcome = onError(result.Error);

            return outcome;
        }
    }
}