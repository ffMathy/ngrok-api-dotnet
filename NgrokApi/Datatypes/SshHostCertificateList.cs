using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class SshHostCertificateList
    {
        // <summary>
        // the list of all ssh host certificates on this account
        // </summary>
        [JsonPropertyName("ssh_host_certificates")]
        public List<SshHostCertificate> SshHostCertificates { get; set; }
        // <summary>
        // URI of the ssh host certificates list API resource
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
            return $"SshHostCertificateList SshHostCertificates={ SshHostCertificates }  Uri={ Uri }  NextPageUri={ NextPageUri } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (SshHostCertificates?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (NextPageUri?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (SshHostCertificateList)obj;
            return (
                 this.SshHostCertificates == other.SshHostCertificates
                && this.Uri == other.Uri
                && this.NextPageUri == other.NextPageUri
            );
        }

    }
}
