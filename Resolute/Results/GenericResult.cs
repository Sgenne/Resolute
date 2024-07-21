namespace Resolute.Results;

/// <summary>
/// Represents a result that can either contain a value or an error.
/// </summary>
/// <typeparam name="TError">The type of the error.</typeparam>
/// <typeparam name="TValue">The type of the value.</typeparam>
public class Result<TError, TValue>
{
    private readonly TValue? _value;

    /// <summary>
    /// Gets the value of the result.
    /// </summary>
    /// <exception cref="InvalidOperationException">Thrown when the result does not have a value.</exception>
    public TValue Value
    {
        get
        {
            if (_value == null)
            {
                throw new InvalidOperationException("The Result does not have a value.");
            }

            return _value;
        }
    }

    private readonly TError? _error;

    /// <summary>
    /// Gets the error of the result.
    /// </summary>
    /// <exception cref="InvalidOperationException">Thrown when the result does not have an error.</exception>
    public TError Error
    {
        get
        {
            if (_error == null)
            {
                throw new InvalidOperationException("The Result does not have an error.");
            }

            return _error;
        }
    }

    /// <summary>
    /// Returns the current result if it is successful. Otherwise, the exception returned 
    /// by the provided function is thrown.
    /// </summary>
    /// <param name="exceptionFunc">The function used to produce an exception in the case of
    /// an unsuccessful result. The failed result object will be passed to the function.</param>
    /// <returns>The current result if it is successful.</returns>
    public Result<TError, TValue> ThrowIfFailed(Func<Result<TError, TValue>, Exception> exceptionFunc)
    {
        if (Failed)
        {
            throw exceptionFunc(this);
        }

        return this;
    }

    /// <summary>
    /// Gets a value indicating whether the result succeeded.
    /// </summary>
    public bool Succeeded => _error == null;

    /// <summary>
    /// Gets a value indicating whether the result failed.
    /// </summary>
    public bool Failed => !Succeeded;

    /// <summary>
    /// Gets a value indicating whether the result has a value.
    /// </summary>
    public bool HasValue => _value != null;

    /// <summary>
    /// Initializes a new instance of the <see cref="Result{TError, TValue}"/> class with an error.
    /// </summary>
    /// <param name="error">The error value.</param>
    /// <exception cref="ArgumentNullException">Thrown when the error is null.</exception>
    public Result(TError error)
    {
        if (error == null)
        {
            throw new ArgumentNullException(nameof(error));
        }

        _error = error;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Result{TError, TValue}"/> class with a value.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <exception cref="ArgumentNullException">Thrown when the value is null.</exception>
    public Result(TValue value)
    {
        if (value == null)
        {
            throw new ArgumentNullException(nameof(value));
        }

        _value = value;
    }
}


/// <summary>
/// Represents the absence of a value.
/// </summary>
public class Unit
{
    public static readonly Unit Value = new Unit();
}