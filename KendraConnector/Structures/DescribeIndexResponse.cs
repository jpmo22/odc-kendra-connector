using OutSystems.ExternalLibraries.SDK;

namespace KendraConnector.Structures
{
    [OSStructure(Description = "This is the response object from the DescribeIndex operation.")]
    /// <summary>
    /// This is the response object from the DescribeIndex operation.
    /// </summary>
    public struct DescribeIndexResponse
    {
        [OSStructureField(DataType = OSDataType.DateTime, Description = "AThe timestamp when the index was created.")]
        /// <summary>
        /// The timestamp when the index was created.
        /// </summary>
        public DateTime createdAt;

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

        [OSStructureField(DataType = OSDataType.Text, Description = "When the Status field value is FAILED, the ErrorMessage field contains a message that explains why.")]
        /// <summary>
        /// When the Status field value is FAILED, the ErrorMessage field contains a message that explains why.
        /// </summary>
        public string errorMessage;

        [OSStructureField(DataType = OSDataType.Text, Description = "The identifier of the index.")]
        /// <summary>
        /// The identifier of the index.
        /// </summary>
        public string id;

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

        [OSStructureField(DataType = OSDataType.Text, Description = "The current status of the index. When the value is ACTIVE, the index is ready for use. If the Status field value is FAILED, the ErrorMessage field contains a message that explains why. Possible values: ACTIVE, CREATING, DELETING, FAILED, SYSTEM_UPDATING or UPDATING.")]
        /// <summary>
        /// The current status of the index. When the value is ACTIVE, the index is ready for use. If the Status field value is FAILED, the ErrorMessage field contains a message that explains why. Possible values: ACTIVE, CREATING, DELETING, FAILED, SYSTEM_UPDATING or UPDATING.
        /// </summary>
        public string status;

        [OSStructureField(DataType = OSDataType.DateTime, Description = "The timestamp when the index was last updated.")]
        /// <summary>
        /// The timestamp when the index was last updated.
        /// </summary>
        public DateTime updatedAt;

        /// <summary>
        /// Construtor for DescribeIndexResponse structure.
        /// </summary>
        public DescribeIndexResponse(Amazon.Kendra.Model.DescribeIndexResponse res) : this()
        {
            this.createdAt = res.CreatedAt;
            this.description = res.Description;
            this.edition = res.Edition.Value;
            this.errorMessage = res.ErrorMessage;
            this.id = res.Id;
            this.name = res.Name;
            this.roleArn = res.RoleArn;
            this.status = res.Status.Value;
            this.updatedAt = res.UpdatedAt;
        }
    }
}