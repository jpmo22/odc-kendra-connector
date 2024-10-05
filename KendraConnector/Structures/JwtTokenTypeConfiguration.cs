using System.Security.AccessControl;
using Amazon.Kendra;
using Amazon.Kendra.Model;
using OutSystems.ExternalLibraries.SDK;

namespace KendraConnector.Structures
{
    [OSStructure(Description = "Provides the configuration information for the JWT token type.")]
    /// <summary>
    /// Provides the configuration information for the JWT token type.
    /// </summary>
    public struct JwtTokenTypeConfiguration
    {
        [OSStructureField(DataType = OSDataType.Text, Description = "The regular expression that identifies the claim.")]
        /// <summary>
        /// The regular expression that identifies the claim.
        /// </summary>
        public string claimRegex;

        [OSStructureField(DataType = OSDataType.Text, Description = "The group attribute field.")]
        /// <summary>
        /// The group attribute field.
        /// </summary>
        public string groupAttributeField;

        [OSStructureField(DataType = OSDataType.Text, Description = "The issuer of the token.")]
        /// <summary>
        /// The issuer of the token.
        /// </summary>
        public string issuer;

        [OSStructureField(DataType = OSDataType.Text, Description = "The location of the key. Possible values: SECRET_MANAGER or URL.")]
        /// <summary>
        /// The location of the key.
        /// Possible values: SECRET_MANAGER or URL.
        /// </summary>
        public string keyLocation;

        [OSStructureField(DataType = OSDataType.Text, Description = "The Amazon Resource Name (arn) of the secret.")]
        /// <summary>
        /// The Amazon Resource Name (arn) of the secret.
        /// </summary>
        public string secretManagerArn;

        [OSStructureField(DataType = OSDataType.Text, Description = "The signing key URL.")]
        /// <summary>
        /// The signing key URL.
        /// </summary>
        public string url;

        [OSStructureField(DataType = OSDataType.Text, Description = "The user name attribute field.")]
        /// <summary>
        /// The user name attribute field.
        /// </summary>
        public string userNameAttributeField;

        /// <summary>
        /// Construtor for JwtTokenTypeConfiguration structure.
        /// </summary>
        public JwtTokenTypeConfiguration(Amazon.Kendra.Model.JwtTokenTypeConfiguration input) : this()
        {
            this.claimRegex = input.ClaimRegex;
            this.groupAttributeField = input.GroupAttributeField;
            this.issuer = input.Issuer;
            this.keyLocation = input.KeyLocation.Value;
            this.secretManagerArn = input.SecretManagerArn;
            this.url = input.URL;
            this.userNameAttributeField = input.UserNameAttributeField;
        }

        /// <summary>
        /// Converts a OS Structure to AWS Model.
        /// </summary>
        /// <returns>The AWS object.</returns>
        public readonly Amazon.Kendra.Model.JwtTokenTypeConfiguration ToAWS()
        {
            Amazon.Kendra.Model.JwtTokenTypeConfiguration result = new()
            {
                ClaimRegex = this.claimRegex,
                GroupAttributeField = this.groupAttributeField,
                Issuer = this.issuer,
                KeyLocation = KeyLocation.FindValue(this.keyLocation),
                SecretManagerArn = this.secretManagerArn,
                URL = this.url,
                UserNameAttributeField = this.userNameAttributeField
            };
            return result;
        }

    }
}