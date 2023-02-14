using Newtonsoft.Json;
using NUnit.Framework;

public class NewtonsoftJsonTest
{
    // A Test behaves as an ordinary method
    [Test]
    [TestCase("{\"a\":\"This is a string.\",\"b\":0}")]
    public void ParseJsonToAnonymousObject(string jsonString)
    {
        var anonymous = JsonConvert.DeserializeAnonymousType(jsonString, new
        {
            a = string.Empty
        })!;

        Assert.AreEqual(anonymous.a, "This is a string.");
    }
}
