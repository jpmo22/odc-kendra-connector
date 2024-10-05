using OutSystems.ExternalLibraries.SDK;

namespace KendraConnector.Structures
{
    [OSStructure(Description = "This is the response object from the CreateIndex operation.")]
    /// <summary>
    /// This is the response object from the CreateIndex operation.
    /// </summary>
    public struct CreateIndexResponse
    {
        [OSStructureField(DataType = OSDataType.LongInteger, Description = "Inherited from Amazon.Runtime.AmazonWebServiceResponse.")]
        /// <summary>
        /// Inherited from Amazon.Runtime.AmazonWebServiceResponse.
        /// </summary>
        public long contentLength;

        [OSStructureField(DataType = OSDataType.Text, Description = "Inherited from Amazon.Runtime.AmazonWebServiceResponse.")]
        /// <summary>
        /// Inherited from Amazon.Runtime.AmazonWebServiceResponse.
        /// </summary>
        public string httpStatusCode;

        [OSStructureField(DataType = OSDataType.Text, Description = "The identifier of the index. Use this identifier when you query an index, set up a data source, or index a document.")]
        /// <summary>
        /// The identifier of the index. Use this identifier when you query an index, set up a data source, or index a document.
        /// </summary>
        public string id;

        /// <summary>
        /// Construtor for Tag structure.
        /// </summary>
        public CreateIndexResponse(Amazon.Kendra.Model.CreateIndexResponse input) : this()
        {
            this.contentLength = input.ContentLength;
            this.httpStatusCode = input.HttpStatusCode.ToString();
            this.id = input.Id;
        }

        /// <summary>
        /// Construtor for Tag structure.
        /// </summary>
        public CreateIndexResponse(long contentLength, string httpStatusCode, string id) : this()
        {
            this.contentLength = contentLength;
            this.httpStatusCode = httpStatusCode;
            this.id = id;
        }

        public readonly Amazon.Kendra.Model.CreateIndexResponse ToAWS()
        {
            Amazon.Kendra.Model.CreateIndexResponse result = new()
            {
                ContentLength = this.contentLength,
                HttpStatusCode = (System.Net.HttpStatusCode) Enum.Parse(typeof(System.Net.HttpStatusCode), this.httpStatusCode),
                Id = this.id
            };
            return result;
        }
    }
}