namespace Resolute.Errors;

public enum ErrorCode
{
    GeneralError = 0,
    ValidationError = 1,
    NotFound = 2,
    Unauthorized = 3,
    Forbidden = 4,
    Conflict = 5,
    InternalServerError = 6,
    ServiceUnavailable = 7,
    NotImplemented = 8,
    BadGateway = 9,
    GatewayTimeout = 10,
    RequestTimeout = 11,
    BadRequest = 12,
    TooManyRequests = 13,
    UnsupportedMediaType = 14,
    UnsupportedMethod = 15,
    UnsupportedVersion = 16,
    UnsupportedFormat = 17,
    UnsupportedLanguage = 18,
    UnsupportedEncoding = 19,
    UnsupportedCharacter = 20,
    UnsupportedProtocol = 21,
    UnsupportedScheme = 22,
    UnsupportedAuth = 23,
    UnsupportedType = 24,
    DatabaseError = 25,
    NetworkError = 26,
    UnexpectedError = 27,
}