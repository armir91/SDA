namespace Advanced.Features.Coding.Shared;

public class Tests
{
    private List<string> _listStrings;
    [SetUp]
    public void Setup()
    {
        // arrange
        _listStrings = new List<string>
        {
            "Bla Bla",
            "Lumturi",
            "Antonio"
        };
    }

    [TearDown]
    public void TearDown()
    {
        _listStrings.Clear();
    }

    [Test]
    public void OrderListDesc()
    {
        //Act
        var result = Helpers.ListMethod(_listStrings);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.FirstOrDefault(), Is.EqualTo("Lumturi"));
            Assert.That(result.FirstOrDefault(), Is.EqualTo("Antonio"));
        });
    }

    [Test]
    public void NotOrderListDesc()
    {
        //Act
        var result = Helpers.ListMethod(_listStrings);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.FirstOrDefault(), Is.Not.EqualTo("Antonio"));
            Assert.That(result.FirstOrDefault(), Is.Not.EqualTo("Antonio"));
        });
    }
}