using Resolute.Errors;

namespace Resolute.Results;

/// <summary>
/// Represents a result that can either contain a value of type <typeparamref name="TValue"/> or an error of type <see cref="Error"/>.
/// </summary>
/// <typeparam name="TValue">The type of the value.</typeparam>
public class Result<TValue> : Result<Error, TValue>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Result{TValue}"/> class with a value.
    /// </summary>
    /// <param name="value">The value.</param>
    public Result(TValue value) : base(value) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="Result{TValue}"/> class with an error.
    /// </summary>
    /// <param name="error">The error.</param>
    public Result(Error error) : base(error) { }
}