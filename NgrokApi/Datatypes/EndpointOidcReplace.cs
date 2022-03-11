using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class EndpointOidcReplace : HasId
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("module")]
        public EndpointOidc Module { get; set; }

        public override string ToString()
        {
            return $"EndpointOidcReplace Id={ Id }  Module={ Module } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Module?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EndpointOidcReplace)obj;
            return (
                 this.Id == other.Id
                && this.Module == other.Module
            );
        }

    }
}
