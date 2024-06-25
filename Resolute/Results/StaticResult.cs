using Resolute.Errors;
using Resolute.Results;

namespace Resolute.Results;

/// <summary>
/// Provides static methods for creating Results.
/// </summary>
public static class Result
{
    /// <summary>
    /// Creates a successful <see cref="Result{TValue}"/> instance with the specified value.
    /// </summary>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <param name="value">The value.</param>
    /// <returns>A successful <see cref="Result{TValue}"/> instance.</returns>
    public static Result<TValue> Success<TValue>(TValue value)
    {
        var result = new Result<TValue>(value);

        return result;
    }

    /// <summary>
    /// Creates a successful <see cref="Result{TError, TValue}"/> instance with the specified value.
    /// </summary>
    /// <typeparam name="TError">The type of the error.</typeparam>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <param name="value">The value.</param>
    /// <returns>A successful <see cref="Result{TError, TValue}"/> instance.</returns>
    public static Result<TError, TValue> Success<TError, TValue>(TValue value)
    {
        var result = new Result<TError, TValue>(value);

        return result;
    }

    /// <summary>
    /// Creates a failed <see cref="Result{TError, TValue}"/> instance with the specified error.
    /// </summary>
    /// <typeparam name="TError">The type of the error.</typeparam>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <param name="error">The error.</param>
    /// <returns>A failed <see cref="Result{TError, TValue}"/> instance.</returns>
    public static Result<TError, TValue> Failure<TError, TValue>(TError error)
    {
        var result = new Result<TError, TValue>(error);

        return result;
    }

    /// <summary>
    /// Creates a failed <see cref="Result{TValue}"/> instance with the specified error.
    /// </summary>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <param name="error">The error.</param>
    /// <returns>A failed <see cref="Result{TValue}"/> instance.</returns>
    public static Result<TValue> Failure<TValue>(Error error)
    {
        var result = new Result<TValue>(error);

        return result;
    }

    /// <summary>
    /// Creates a failed <see cref="Result{TValue}"/> instance with the specified message and error code.
    /// </summary>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <param name="message">The error message.</param>
    /// <param name="errorCode">The error code.</param>
    /// <returns>A failed <see cref="Result{TValue}"/> instance.</returns>
    public static Result<TValue> Failure<TValue>(string message, ErrorCode errorCode)
    {
        var result = new Result<TValue>(Error.From(message, errorCode));

        return result;
    }

    /// <summary>
    /// Creates a failed <see cref="Result{TValue}"/> instance with the specified message and error code.
    /// </summary>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <param name="message">The error message.</param>
    /// <param name="errorCode">The error code.</param>
    /// <param name="sanitizedMessage">The sanitized error message.</param>
    /// <returns>A failed <see cref="Result{TValue}"/> instance.</returns>
    public static Result<TValue> Failure<TValue>(string message, ErrorCode errorCode, string sanitizedMessage)
    {
        var result = new Result<TValue>(Error.From(message, errorCode, sanitizedMessage));

        return result;
    }


    /// <summary>
    /// Creates a failed <see cref="Result{TValue}"/> instance with the specified message and error code.
    /// </summary>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <param name="message">The error message.</param>
    /// <param name="errorCode">The error code.</param>
    /// <param name="sanitizedMessage">The sanitized error message.</param>
    /// <returns>A failed <see cref="Result{TValue}"/> instance.</returns>
    public static Result<TValue> Failure<TValue>(string message, ErrorCode errorCode, string sanitizedMessage, string source)
    {
        var result = new Result<TValue>(Error.From(message, errorCode, sanitizedMessage, source));

        return result;
    }
}