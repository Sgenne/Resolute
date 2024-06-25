using Resolute.Errors;
using Resolute.Results;

namespace Resolute.Tests.Results;

public class ResultTests
{
    [Fact]
    public void ResultHasError_SuccessIsFalse()
    {
        var result = Result.Failure<int>("Error message", ErrorCode.GeneralError);

        Assert.False(result.Succeeded);
    }

    [Fact]
    public void ResultHasError_FailureIsTrue()
    {
        var result = Result.Failure<int>("Error message", ErrorCode.GeneralError);

        Assert.True(result.Failed);
    }

    [Fact]
    public void ResultHasErrorAndValueIsNullable_ValueThrowsException()
    {
        var result = Result.Failure<string>("Error message", ErrorCode.GeneralError);

        Assert.Throws<InvalidOperationException>(() => result.Value);
    }

    [Fact]
    public void ResultHasErrorAndValueIsNullable_HasValueIsFalse()
    {
        var result = Result.Failure<string>("Error message", ErrorCode.GeneralError);

        Assert.False(result.HasValue);
    }

    [Fact]
    public void ResultHasValue_ValueReturnsSuccessfully()
    {
        var result = Result.Success(42);

        Assert.Equal(42, result.Value);
    }

    [Fact]
    public void Constructor_NullErrorCollection_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => new Result<int>(null!));
    }

    [Fact]
    public void Success_NullValue_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => Result.Success<Error>(null!));
    }
}