using OutSystems.ExternalLibraries.SDK;

namespace KendraConnector.Structures
{
    [OSStructure(Description = "Provides the configuration information for a token.")]
    /// <summary>
    /// Provides the configuration information for a token.
    /// </summary>
    public struct UserTokenConfiguration
    {
        [OSStructureField(Description = "Information about the JSON token type configuration.")]
        /// <summary>
        /// Information about the JSON token type configuration.
        /// </summary>
        public JsonTokenTypeConfiguration jsonTokenTypeConfiguration;

        [OSStructureField(Description = "Information about the JWT token type configuration.")]
        /// <summary>
        /// Information about the JWT token type configuration.
        /// </summary>
        public JwtTokenTypeConfiguration jwtTokenTypeConfiguration;

        /// <summary>
        /// Construtor for Tag structure.
        /// </summary>
        public UserTokenConfiguration(Amazon.Kendra.Model.UserTokenConfiguration input) : this()
        {
            this.jwtTokenTypeConfiguration = new JwtTokenTypeConfiguration(input.JwtTokenTypeConfiguration);
            this.jsonTokenTypeConfiguration = new JsonTokenTypeConfiguration(input.JsonTokenTypeConfiguration);
        }

        /// <summary>
        /// Construtor for Tag structure.
        /// </summary>
        public UserTokenConfiguration(JwtTokenTypeConfiguration jwtTokenTypeConfiguration, JsonTokenTypeConfiguration jsonTokenTypeConfiguration) : this()
        {
            this.jwtTokenTypeConfiguration = jwtTokenTypeConfiguration;
            this.jsonTokenTypeConfiguration = jsonTokenTypeConfiguration;
        }

        public readonly Amazon.Kendra.Model.UserTokenConfiguration ToAWS()
        {
            Amazon.Kendra.Model.UserTokenConfiguration result = new()
            {
                JwtTokenTypeConfiguration = this.jwtTokenTypeConfiguration.ToAWS(),
                JsonTokenTypeConfiguration = this.jsonTokenTypeConfiguration.ToAWS()
            };
            return result;
        }
    }
}