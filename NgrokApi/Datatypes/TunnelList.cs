using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class TunnelList
    {
        // <summary>
        // the list of all online tunnels on this account
        // </summary>
        [JsonPropertyName("tunnels")]
        public List<Tunnel> Tunnels { get; set; }
        // <summary>
        // URI of the tunnels list API resource
        // </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
        // <summary>
        // URI of the next page, or null if there is no next page
        // </summary>
        [JsonPropertyName("next_page_uri")]
        public string NextPageUri { get; set; }

        public override string ToString()
        {
            return $"TunnelList Tunnels={ Tunnels }  Uri={ Uri }  NextPageUri={ NextPageUri } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Tunnels?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (NextPageUri?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (TunnelList)obj;
            return (
                 this.Tunnels == other.Tunnels
                && this.Uri == other.Uri
                && this.NextPageUri == other.NextPageUri
            );
        }

    }
}
