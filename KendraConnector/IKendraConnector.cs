using KendraConnector.Structures;
using OutSystems.ExternalLibraries.SDK;

namespace KendraConnector
{
    [OSInterface(Description = "Kendra Connector to ODC apps.", Name = "KendraConnector")]
    public interface IKendraConnector
    {
        [OSAction(Description = "Gets information about an Amazon Kendra index.", ReturnName = "DescribeIndexResponse")]
        public Structures.DescribeIndexResponse DescribeIndex(
            [OSParameter(Description = "AWS Kendra credentials.")]
            KendraCredentials credentials, 
            [OSParameter(DataType = OSDataType.Text, Description = "The Index identifier.")]
            string indexId);

        [OSAction(Description = "Creates an Amazon Kendra index. Index creation is an asynchronous API. To determine if index creation has completed, check the Status field returned from a call to DescribeIndex. The Status field is set to ACTIVE when the index is ready to use. Once the index is active, you can index your documents using the BatchPutDocument API or using one of the supported data sources.", ReturnName = "CreateIndexResponse")]
        public Structures.CreateIndexResponse CreateIndex(
            [OSParameter(Description = "AWS Kendra credentials.")]
            KendraCredentials credentials, 
            [OSParameter(Description = "Container for the necessary parameters to execute the CreateIndex service method.")]
            Structures.CreateIndexRequest request);

    }
}