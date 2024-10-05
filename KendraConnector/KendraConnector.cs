using Amazon;
using Amazon.Kendra;
using Amazon.Kendra.Model;
using KendraConnector.Structures;

namespace KendraConnector;

public class KendraConnector : IKendraConnector
{
    public KendraConnector()
    {

    }

    private static AmazonKendraClient NewClient(String awsAccessKeyId,
         String awsSecretAccessKey,
         String region)
    {
        RegionEndpoint re;
        AmazonKendraClient client;
        try
        {
            re = RegionEndpoint.GetBySystemName(region);
        }
        catch (Exception)
        {
            throw new Exception("Invalid region: " + region);
        }
        
        try
        {
            client = new(awsAccessKeyId, awsSecretAccessKey, re);
        }
        catch(Exception e)
        {
            throw new Exception("Could not stablish connection to Kendra. [" + e.Message + "]");
        }
        
        return client;
    }

    private static AmazonKendraClient NewClient(KendraCredentials credentials)
    {
        return NewClient(credentials.awsAccessKeyId, credentials.awsSecretAccessKey, credentials.region);
    }

    /// <summary>
    /// Gets information about an Amazon Kendra index.
    /// </summary>
    /// <param name="credentials">AWS Kendra credentials.</param>
    /// <param name="indexId">The Index identifier.</param>
    /// <returns>The DescribeIndexResponse struture.</returns>
    public Structures.DescribeIndexResponse DescribeIndex(KendraCredentials credentials, string indexId)
    {
        AmazonKendraClient client = NewClient(credentials);
        DescribeIndexRequest req = new()
        {
            Id = indexId
        };

        Amazon.Kendra.Model.DescribeIndexResponse res = client.DescribeIndexAsync(req).GetAwaiter().GetResult();
        Structures.DescribeIndexResponse result = new(res);
        return result;
    }

    /// <summary>
    /// Creates an Amazon Kendra index. Index creation is an asynchronous API. To determine if index creation has completed, check the Status field returned from a call to DescribeIndex. The Status field is set to ACTIVE when the index is ready to use.
    /// Once the index is active, you can index your documents using the BatchPutDocument API or using one of the supported data sources.
    /// </summary>
    /// <param name="credentials">AWS Kendra credentials.</param>
    /// <param name="request">Container for the necessary parameters to execute the CreateIndex service method.</param>
    /// <returns>The response from the CreateIndex service method, as returned by Kendra.</returns>
    public Structures.CreateIndexResponse CreateIndex(KendraCredentials credentials, Structures.CreateIndexRequest request)
    {
        AmazonKendraClient client = NewClient(credentials);
        Amazon.Kendra.Model.CreateIndexRequest req = request.ToAWS();
        Amazon.Kendra.Model.CreateIndexResponse res = client.CreateIndexAsync(req).GetAwaiter().GetResult();
        return new Structures.CreateIndexResponse(res);
    }

}
