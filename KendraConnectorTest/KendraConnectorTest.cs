using KendraConnector;
using KendraConnector.Structures;

namespace KendraConnectorTest;

[TestClass]
public class KendraConnectorTest
{
    [TestMethod]
    public void TestDescribeIndex()
    {
        KendraConnector.KendraConnector kc = new();
        KendraConnector.Structures.KendraCredentials credentials = new() {
            awsAccessKeyId = "<AccessKeyId>",
            awsSecretAccessKey = "<SecretAccessKey>",
            region = "us-east-1"
        };
        KendraConnector.Structures.DescribeIndexResponse res = kc.DescribeIndex(credentials, "<IndexId>");
        Assert.IsNotNull(res);
    }
}