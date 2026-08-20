namespace ComposableUI.Component1.Tests;

public class CounterTests
{
    [Fact]
    public void CounterShouldIncrementWhenClicked()
    {
        // Arrange
        using var ctx = new BunitContext();
        var cut = ctx.Render<Counter>();
        var paraElm = cut.Find("p");

        // Act
        cut.Find("button").Click();

        // Assert
        var paraElmText = paraElm.TextContent;
        paraElmText.MarkupMatches("Current count: 1");
    }
}