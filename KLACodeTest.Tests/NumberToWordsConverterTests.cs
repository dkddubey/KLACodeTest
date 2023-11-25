
using KLACodeTest.BusinessLayer;
using Xunit;

public class NumberToWordsConverterTests
{

    [Fact]
    public void ConvertNumberToWords_Minimum_ReturnsCorrectWords()
    {
        // Arrange
        var converter = new NumberToWordsConverter();
        double number = 0;

        // Act
        var result = converter.ConvertNumberToWords(number);

        // Assert
        Assert.Equal("zero dollars", result);
    }

    [Fact]
    public void ConvertNumberToWords_One_ReturnsCorrectWords()
    {
        // Arrange
        var converter = new NumberToWordsConverter();
        double number = 1;

        // Act
        var result = converter.ConvertNumberToWords(number);

        // Assert
        Assert.Equal("one dollar", result);
    }

    [Fact]
    public void ConvertNumberToWords_ZeroDollarOneCent_ReturnsCorrectWords()
    {
        // Arrange
        var converter = new NumberToWordsConverter();
        double number = 0.01;

        // Act
        var result = converter.ConvertNumberToWords(number);

        // Assert
        Assert.Equal("zero dollars and one cent", result);
    }

    [Fact]
    public void ConvertNumberToWords_WithValidNumber_ReturnsCorrectWords()
    {
        // Arrange
        var converter = new NumberToWordsConverter();
        double number = 12345.67;

        // Act
        var result = converter.ConvertNumberToWords(number);

        // Assert
        Assert.Equal("twelve thousand three hundred forty-five dollars and sixty-seven cents", result);
    }

    [Fact]
    public void ConvertNumberToWords_WithZero_ReturnsZeroDollars()
    {
        // Arrange
        var converter = new NumberToWordsConverter();
        double number = 0;

        // Act
        var result = converter.ConvertNumberToWords(number);

        // Assert
        Assert.Equal("zero dollars".ToLower(), result);
    }

    [Fact]
    public void ConvertNumberToWords_WithLargeNumber_ReturnsCorrectWords()
    {
        // Arrange
        var converter = new NumberToWordsConverter();
        double number = 123456789.12;

        // Act
        var result = converter.ConvertNumberToWords(number);

        // Assert
        Assert.Equal("one hundred twenty-three million four hundred fifty-six thousand seven hundred eighty-nine dollars and twelve cents", result);
    }
}