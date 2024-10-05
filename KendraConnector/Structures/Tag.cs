using OutSystems.ExternalLibraries.SDK;

namespace KendraConnector.Structures
{
    [OSStructure(Description = "A list of key/value pairs that identify an index, FAQ, or data source. Tag keys and values can consist of Unicode letters, digits, white space, and any of the following symbols: _ . : / = + - @.")]
    /// <summary>
    /// A list of key/value pairs that identify an index, FAQ, or data source. Tag keys and values can consist of Unicode letters, digits, white space, and any of the following symbols: _ . : / = + - @.
    /// </summary>
    public struct Tag
    {
        [OSStructureField(DataType = OSDataType.Text, Description = "The key for the tag. Keys are not case sensitive and must be unique for the index, FAQ, or data source.")]
        /// <summary>
        /// The key for the tag. Keys are not case sensitive and must be unique for the index, FAQ, or data source.
        /// </summary>
        public string key;

        [OSStructureField(DataType = OSDataType.Text, Description = "The value associated with the tag. The value may be an empty string but it can't be null.")]
        /// <summary>
        /// The value associated with the tag. The value may be an empty string but it can't be null.
        /// </summary>
        public string value;

        /// <summary>
        /// Construtor for Tag structure.
        /// </summary>
        public Tag(Amazon.Kendra.Model.Tag tag) : this()
        {
            this.key = tag.Key;
            this.value = tag.Value;
        }

        /// <summary>
        /// Construtor for Tag structure.
        /// </summary>
        public Tag(string key, string value) : this()
        {
            this.key = key;
            this.value = value;
        }

        public readonly Amazon.Kendra.Model.Tag ToAWS()
        {
            Amazon.Kendra.Model.Tag result = new()
            {
                Key = this.key,
                Value = this.value
            };
            return result;
        }
    }
}