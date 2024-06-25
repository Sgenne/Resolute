namespace Resolute.Errors;

/// <summary>
/// Represents an error in the application.
/// </summary>
public class Error
{
    /// <summary>
    /// Describes the error.
    /// </summary>
    public string Message { get; init; } = string.Empty;

    /// <summary>
    /// Describes the type of error.
    /// </summary>
    public ErrorCode ErrorCode { get; init; }

    /// <summary>
    /// A generic error message that has been sanitized to remove sensitive information. Should be safe to display to the user.
    /// </summary>
    public string SanitizedMessage { get; init; } = string.Empty;

    /// <summary>
    /// Returns a value indicating whether the error has a sanitized message.
    /// </summary>
    public bool HasSanitizedMessage => !string.IsNullOrWhiteSpace(SanitizedMessage);


    /// <summary>
    /// Short description of what the source of the error was. This may be a property, method, or other identifier.
    /// </summary>
    public string Source { get; init; } = string.Empty;

    /// <summary>
    /// Returns a value indicating whether the error has a source.
    /// </summary>
    public bool HasSource => !string.IsNullOrWhiteSpace(Source);

    /// <summary>
    /// Creates a new instance of the <see cref="Error"/> class with the specified message and error code.
    /// </summary>
    /// <param name="message">The error message.</param>
    /// <param name="errorCode">The error code.</param>
    /// <returns>An instance of the <see cref="Error"/> class.</returns>
    public static Error From(string message, ErrorCode errorCode)
    {
        var error = new Error()
        {
            Message = message,
            ErrorCode = errorCode
        };

        return error;
    }

    /// <summary>
    /// Creates a new instance of the <see cref="Error"/> class with the specified message, error code, and sanitized message.
    /// </summary>
    /// <param name="message">The error message.</param>
    /// <param name="errorCode">The error code.</param>
    /// <param name="sanitizedMessage">The sanitized error message.</param>
    /// <returns>An instance of the <see cref="Error"/> class.</returns>
    public static Error From(string message, ErrorCode errorCode, string sanitizedMessage)
    {
        var error = new Error()
        {
            Message = message,
            ErrorCode = errorCode,
            SanitizedMessage = sanitizedMessage
        };

        return error;
    }

    /// <summary>
    /// Creates a new instance of the <see cref="Error"/> class with the specified message, error code, and sanitized message.
    /// </summary>
    /// <param name="message">The error message.</param>
    /// <param name="errorCode">The error code.</param>
    /// <param name="sanitizedMessage">The sanitized error message.</param>
    /// <param name="source">The source of the error.</param>
    /// <returns>An instance of the <see cref="Error"/> class.</returns>
    public static Error From(string message, ErrorCode errorCode, string sanitizedMessage, string source)
    {
        var error = new Error()
        {
            Message = message,
            ErrorCode = errorCode,
            SanitizedMessage = sanitizedMessage,
            Source = source
        };

        return error;
    }

}