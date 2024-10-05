using Amazon.Kendra.Model;
using OutSystems.ExternalLibraries.SDK;

namespace KendraConnector.Structures
{
    [OSStructure(Description = "Container for the parameters to the CreateIndex operation. Creates an Amazon Kendra index. Index creation is an asynchronous API. To determine if index creation has completed, check the Status field returned from a call to DescribeIndex. The Status field is set to ACTIVE when the index is ready to use. Once the index is active, you can index your documents using the BatchPutDocument API or using one of the supported data sources.")]
    /// <summary>
    /// Container for the parameters to the CreateIndex operation. Creates an Amazon Kendra index. Index creation is an asynchronous API. To determine if index creation has completed, check the Status field returned from a call to DescribeIndex. The Status field is set to ACTIVE when the index is ready to use.
    /// Once the index is active, you can index your documents using the BatchPutDocument API or using one of the supported data sources.
    /// </summary>
    public struct CreateIndexRequest
    {
        [OSStructureField(DataType = OSDataType.Text, Description = "A token that you provide to identify the request to create an index. Multiple calls to the CreateIndex API with the same client token will create only one index.")]
        /// <summary>
        /// A token that you provide to identify the request to create an index. Multiple calls to the CreateIndex API with the same client token will create only one index.
        /// </summary>
        public string clientToken;

        [OSStructureField(DataType = OSDataType.Text, Description = "The description for the index.")]
        /// <summary>
        /// The description for the index.
        /// </summary>
        public string description;

        [OSStructureField(DataType = OSDataType.Text, Description = "The Amazon Kendra edition used for the index. You decide the edition when you create the index. Possible values: DEVELOPER_EDITION or ENTERPRISE_EDITION.")]
        /// <summary>
        /// The Amazon Kendra edition used for the index. You decide the edition when you create the index. Possible values: DEVELOPER_EDITION or ENTERPRISE_EDITION.
        /// </summary>
        public string edition;

        [OSStructureField(DataType = OSDataType.Text, Description = "The name of the index.")]
        /// <summary>
        /// The name of the index.
        /// </summary>
        public string name;

        [OSStructureField(DataType = OSDataType.Text, Description = "The Amazon Resource Name (ARN) of the IAM role that gives Amazon Kendra permission to write to your Amazon CloudWatch logs.")]
        /// <summary>
        /// The Amazon Resource Name (ARN) of the IAM role that gives Amazon Kendra permission to write to your Amazon CloudWatch logs.
        /// </summary>
        public string roleArn;

        [OSStructureField(DataType = OSDataType.Text, Description = "The identifier of the KMS customer managed key (CMK) that's used to encrypt data indexed by Amazon Kendra. Amazon Kendra doesn't support asymmetric CMKs. The identifier of the KMS key. Amazon Kendra doesn't support asymmetric keys.")]
        /// <summary>
        /// The identifier of the KMS customer managed key (CMK) that's used to encrypt data indexed by Amazon Kendra. Amazon Kendra doesn't support asymmetric CMKs.
        /// </summary>
        public string serverSideEncryptionConfiguration;

        [OSStructureField(Description = "A list of key-value pairs that identify or categorize the index. You can also use tags to help control access to the index. Tag keys and values can consist of Unicode letters, digits, white space, and any of the following symbols: _ . : / = + - @.")]
        /// <summary>
        /// A list of key-value pairs that identify or categorize the index. You can also use tags to help control access to the index. Tag keys and values can consist of Unicode letters, digits, white space, and any of the following symbols: _ . : / = + - @.
        /// </summary>
        public List<Tag> tags;

        [OSStructureField(DataType = OSDataType.Text, Description = "The user context policy. ATTRIBUTE_FILTER: All indexed content is searchable and displayable for all users. If you want to filter search results on user context, you can use the attribute filters of _user_id and _group_ids or you can provide user and group information in UserContext. USER_TOKEN: Enables token-based user access control to filter search results on user context. All documents with no access control and all documents accessible to the user will be searchable and displayable.")]
        /// <summary>
        /// The user context policy.
        /// 
        /// ATTRIBUTE_FILTER
        ///     All indexed content is searchable and displayable for all users. If you want to filter search results on user context, you can use the attribute filters of _user_id and _group_ids or you can provide user and group information in UserContext.
        ///     
        /// USER_TOKEN
        ///     Enables token-based user access control to filter search results on user context. All documents with no access control and all documents accessible to the user will be searchable and displayable.
        /// </summary>
        public string userContextPolicy;

        [OSStructureField(DataType = OSDataType.Text, Description = "The identity store provider (mode) you want to use to get users and groups. IAM Identity Center is currently the only available mode. Your users and groups must exist in an IAM Identity Center identity source in order to use this mode. Possible values: AWS_SSO, NONE.")]
        /// <summary>
        /// The identity store provider (mode) you want to use to get users and groups. IAM Identity Center is currently the only available mode. Your users and groups must exist in an IAM Identity Center identity source in order to use this mode.
        /// Possible values: AWS_SSO, NONE.
        /// </summary>
        public string userGroupResolutionConfiguration;

        [OSStructureField(Description = "The Amazon Resource Name (ARN) of the IAM role that gives Amazon Kendra permission to write to your Amazon CloudWatch logs.")]
        /// <summary>
        /// The Amazon Resource Name (ARN) of the IAM role that gives Amazon Kendra permission to write to your Amazon CloudWatch logs.
        /// </summary>
        public List<UserTokenConfiguration> userTokenConfigurations;

        /// <summary>
        /// Construtor for CreateIndexRequest structure.
        /// </summary>
        public CreateIndexRequest(Amazon.Kendra.Model.CreateIndexRequest res) : this()
        {
            this.clientToken = res.ClientToken;
            this.description = res.Description;
            this.edition = res.Edition.Value;
            this.name = res.Name;
            this.roleArn = res.RoleArn;
            this.serverSideEncryptionConfiguration = res.ServerSideEncryptionConfiguration.KmsKeyId;
            this.tags = [];
            foreach(Amazon.Kendra.Model.Tag e in res.Tags)
            {
                this.tags.Add(new Tag(e));
            }
            this.userContextPolicy = res.UserContextPolicy;
            this.userGroupResolutionConfiguration = res.UserGroupResolutionConfiguration.UserGroupResolutionMode.Value;
            this.userTokenConfigurations = [];
            foreach(Amazon.Kendra.Model.UserTokenConfiguration e in res.UserTokenConfigurations)
            {
                this.userTokenConfigurations.Add(new UserTokenConfiguration(e));
            }
        }

        public readonly Amazon.Kendra.Model.CreateIndexRequest ToAWS()
        {
            Amazon.Kendra.Model.CreateIndexRequest result = new();

            // Copy User Token Configurations to AWS model
            List<Amazon.Kendra.Model.UserTokenConfiguration> userTokenConfigurations = [];
            this.userTokenConfigurations.ForEach(e => userTokenConfigurations.Add(e.ToAWS()));

            // Copy Tags to AWS model
            List<Amazon.Kendra.Model.Tag> tags = [];
            this.tags.ForEach(e => tags.Add(e.ToAWS()));

            result.ClientToken = this.clientToken;
            result.Description = this.description;
            result.Edition = Amazon.Kendra.IndexEdition.FindValue(this.edition);
            result.Name = this.name;
            result.RoleArn = this.roleArn;

            Amazon.Kendra.Model.ServerSideEncryptionConfiguration serverSideEncryptionConfiguration = new() {
                KmsKeyId = this.serverSideEncryptionConfiguration
            };
            result.ServerSideEncryptionConfiguration = serverSideEncryptionConfiguration;

            result.Tags = tags;
            result.UserContextPolicy = this.userContextPolicy;

            result.UserGroupResolutionConfiguration = new Amazon.Kendra.Model.UserGroupResolutionConfiguration(){
                UserGroupResolutionMode = Amazon.Kendra.UserGroupResolutionMode.FindValue(this.userGroupResolutionConfiguration)
            };

            result.UserTokenConfigurations = userTokenConfigurations;

            return result;
        }
    }
}