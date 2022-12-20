using Xunit;

namespace Refactoring.Tests;

public class GradingTest 
{
    [Fact]
    public void GetLetterGrade_GetA()
    {   
        // Arrange
        Grading grading = new Grading();
        int grade = 1;
        char expected = 'A';

        // Act
        char actual = grading.GetLetterGrade(grade);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetLetterGrade_GetB()
    {   
        // Arrange
        Grading grading = new Grading();
        int grade = 2;
        char expected = 'B';

        // Act
        char actual = grading.GetLetterGrade(grade);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetLetterGrade_GetC()
    {   
        // Arrange
        Grading grading = new Grading();
        int grade = 3;
        char expected = 'C';

        // Act
        char actual = grading.GetLetterGrade(grade);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetLetterGrade_GetD()
    {   
        // Arrange
        Grading grading = new Grading();
        int grade = 4;
        char expected = 'D';

        // Act
        char actual = grading.GetLetterGrade(grade);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetLetterGrade_GetE()
    {   
        // Arrange
        Grading grading = new Grading();
        int grade = 5;
        char expected = 'E';

        // Act
        char actual = grading.GetLetterGrade(grade);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetLetterGrade_GetF()
    {   
        // Arrange
        Grading grading = new Grading();
        int grade = 6;
        char expected = 'F';

        // Act
        char actual = grading.GetLetterGrade(grade);

        // Assert
        Assert.Equal(expected, actual);
    }
}