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

    [Fact]
    public void Year_1900_returns_false() {
        // Arrange
        var leap = new Program();

        // Act
        var result = leap.IsLeapYear(1900);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Year_1700_returns_nay() {
        // Arrange
        var leap = new Program();

        // Act
        var result = leap.IsLeapYearInput("1700");

        // Assert
        result.Should().Be("nay");
    }

    [Fact]
    public void Year_1581_throws_exeption() {
        // Arrange
        var leap = new Program();

        // Act
        var caughtException = Assert.Throws<InvalidYearException>(() => leap.IsLeapYear(1581));

        // Assert
        Assert.Equal("Year must be 1582 or later", caughtException.Message);
    }
}