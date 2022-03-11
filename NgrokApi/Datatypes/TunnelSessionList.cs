using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class TunnelSessionList
    {
        // <summary>
        // list of all tunnel sessions on this account
        // </summary>
        [JsonPropertyName("tunnel_sessions")]
        public List<TunnelSession> TunnelSessions { get; set; }
        // <summary>
        // URI to the API resource of the tunnel session list
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
            return $"TunnelSessionList TunnelSessions={ TunnelSessions }  Uri={ Uri }  NextPageUri={ NextPageUri } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (TunnelSessions?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (NextPageUri?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (TunnelSessionList)obj;
            return (
                 this.TunnelSessions == other.TunnelSessions
                && this.Uri == other.Uri
                && this.NextPageUri == other.NextPageUri
            );
        }

    }
}
