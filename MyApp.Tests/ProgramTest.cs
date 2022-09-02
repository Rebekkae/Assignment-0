namespace MyApp.Tests;

public class ProgramTest
{
    [Fact]
    public void Year_2004_returns_true() {
        // Arrange
        var leap = new Program();

        // Act
        var result = leap.IsLeapYear(2004);

        // Assert
        Assert.True(result);
    }
}