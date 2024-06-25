using Resolute.Errors;
using Resolute.Results;

namespace Resolute.Tests.Extensions;

public class ResultExtensionsTests
{
    [Fact]
    public void Match_ReturnsOutcomeFromOnError_WhenResultIsFailure()
    {
        var result = Result.Failure<string>("Error message", ErrorCode.GeneralError);
        var expectedOutcome = "Error outcome";

        var outcome = result.Match(
            onError: error => expectedOutcome,
            onSuccess: value => "Success outcome"
        );

        Assert.Equal(expectedOutcome, outcome);
    }

    [Fact]
    public void Match_ReturnsOutcomeFromOnSuccess_WhenResultIsSuccess()
    {
        var result = Result.Success(1);
        var expectedOutcome = "Success outcome";

        var outcome = result.Match(
            onError: error => "Error outcome",
            onSuccess: value => expectedOutcome
        );

        Assert.Equal(expectedOutcome, outcome);
    }
}