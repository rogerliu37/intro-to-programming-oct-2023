namespace LinkedOut.Tests;

public class UnitTest1
{
    [Fact]
    public void CanAddTwoIntegers();
    {

    // Given - "Arrange" - "Setup the world"
    int a = 10;
    int b = 20;
    int total;

    // when - "Act" - Poke at it and see what happens.
    total = a + b; 
    
     Assert.Equal(30, total);

}