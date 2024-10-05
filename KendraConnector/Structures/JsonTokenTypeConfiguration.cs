using OutSystems.ExternalLibraries.SDK;

namespace KendraConnector.Structures
{
    [OSStructure(Description = "Provides the configuration information for the JSON token type.")]
    /// <summary>
    /// Provides the configuration information for the JSON token type.
    /// </summary>
    public struct JsonTokenTypeConfiguration
    {
        [OSStructureField(DataType = OSDataType.Text, Description = "The group attribute field.")]
        /// <summary>
        /// The group attribute field.
        /// </summary>
        public string groupAttributeField;

        [OSStructureField(DataType = OSDataType.Text, Description = "The user name attribute field.")]
        /// <summary>
        /// The user name attribute field.
        /// </summary>
        public string userNameAttributeField;

        /// <summary>
        /// Construtor for JsonTokenTypeConfiguration structure.
        /// </summary>
        public JsonTokenTypeConfiguration(Amazon.Kendra.Model.JsonTokenTypeConfiguration tag) : this()
        {
            this.groupAttributeField = tag.GroupAttributeField;
            this.userNameAttributeField = tag.UserNameAttributeField;
        }

        /// <summary>
        /// Construtor for JsonTokenTypeConfiguration structure.
        /// </summary>
        public JsonTokenTypeConfiguration(string groupAttributeField, string userNameAttributeField) : this()
        {
            this.groupAttributeField = groupAttributeField;
            this.userNameAttributeField = userNameAttributeField;
        }

        /// <summary>
        /// Converts a OS Structure to AWS Model.
        /// </summary>
        /// <returns>The AWS object.</returns>
        public readonly Amazon.Kendra.Model.JsonTokenTypeConfiguration ToAWS()
        {
            Amazon.Kendra.Model.JsonTokenTypeConfiguration result = new()
            {
                GroupAttributeField = this.groupAttributeField,
                UserNameAttributeField = this.userNameAttributeField
            };
            return result;
        }
    }
}