namespace MyApp.Tests;

public class ProgramTest
{
    [Fact]
    public void Year_2004_returns_true() {
        // Arrange
        // var leap = new Program(); // removed since static.

        // Act
        var result = Program.IsLeapYear(2004);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Year_1900_returns_false() {
        // Arrange
        // var leap = new Program(); // removed since static.

        // Act
        var result = Program.IsLeapYear(1900);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Year_1700_returns_nay() {
        // Arrange
        // var leap = new Program(); // removed since static.

        // Act
        var result = Program.IsLeapYearInput("1700");

        // Assert
        result.Should().Be("nay");
    }

    [Fact]
    public void Year_1581_throws_exeption() {
        // Arrange
        // var leap = new Program(); // removed since static.

        // Act
        var caughtException = Assert.Throws<InvalidYearException>(() => Program.IsLeapYear(1581));

        // Assert
        Assert.Equal("Year must be 1582 or later", caughtException.Message);
    }

    [Fact]
    public void String_invalid_throws_exeption() {
        // Arrange
        // var leap = new Program(); // removed since static.

        // Act
        var caughtException = Assert.Throws<InvalidYearException>(() => Program.IsLeapYearInput("Invalid"));

        // Assert
        Assert.Equal("Input is not a valid year!", caughtException.Message);
    }
}