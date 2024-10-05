using OutSystems.ExternalLibraries.SDK;

namespace KendraConnector.Structures
{
    [OSStructure(Description = "AWS Credentials for Kendra.")]
    /// <summary>
    /// AWS Credentials for Kendra.
    /// </summary>
    public struct KendraCredentials
    {
        [OSStructureField(DataType = OSDataType.Text, Description = "AWS Access Key Identifier.", IsMandatory = true)]
        /// <summary>
        /// AWS Access Key Identifier.
        /// </summary>
        public string awsAccessKeyId;

        [OSStructureField(DataType = OSDataType.Text, Description = "AWS Secret Access Key.", IsMandatory = true)]
        /// <summary>
        /// AWS Secret Access Key.
        /// </summary>
        public string awsSecretAccessKey;

        [OSStructureField(DataType = OSDataType.Text, Description = "Region's system name like 'us-east-1'.", IsMandatory = true)]
        /// <summary>
        /// Region's system name like "us-east-1".
        /// </summary>
        public string region;

        /// <summary>
        /// Construtor for KendraCredentials structure.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key Identifier.</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key.</param>
        /// <param name="region">Region's system name like 'us-east-1'.</param>
        public KendraCredentials(string awsAccessKeyId, string awsSecretAccessKey, string region) : this()
        {
            this.awsAccessKeyId = awsAccessKeyId;
            this.awsSecretAccessKey = awsSecretAccessKey;
            this.region = region;
        }
    }
}