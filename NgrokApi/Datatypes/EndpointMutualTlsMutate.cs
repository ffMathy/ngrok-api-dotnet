
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class EndpointMutualTlsMutate
    {
        // <summary>
        // <c>true</c> if the module will be applied to traffic, <c>false</c> to disable.
        // default <c>true</c> if unspecified
        // </summary>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
        // <summary>
        // list of certificate authorities that will be used to validate the TLS client
        // certificate presnted by the initiatiator of the TLS connection
        // </summary>
        [JsonPropertyName("certificate_authority_ids")]
        public List<string> CertificateAuthorityIds { get; set; }

        public override string ToString()
        {
            return $"EndpointMutualTlsMutate Enabled={ Enabled }  CertificateAuthorityIds={ CertificateAuthorityIds } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Convert.ToInt32(Enabled);
                hash = hash * 23 + (CertificateAuthorityIds?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EndpointMutualTlsMutate)obj;
            return (
                 this.Enabled == other.Enabled
                && this.CertificateAuthorityIds == other.CertificateAuthorityIds
            );
        }

    }
}
