
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EndpointMutualTls
    {
        // <summary>
        // <c>true</c> if the module will be applied to traffic, <c>false</c> to disable.
        // default <c>true</c> if unspecified
        // </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
        // <summary>
        // PEM-encoded CA certificates that will be used to validate. Multiple CAs may be
        // provided by concatenating them together.
        // </summary>
        [JsonProperty("certificate_authorities")]
        public List<Ref> CertificateAuthorities { get; set; }

        public override string ToString()
        {
            return $"EndpointMutualTls Enabled={ Enabled }  CertificateAuthorities={ CertificateAuthorities } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Convert.ToInt32(Enabled);
                hash = hash * 23 + (CertificateAuthorities?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EndpointMutualTls)obj;
            return (
                 this.Enabled == other.Enabled
                && this.CertificateAuthorities == other.CertificateAuthorities
            );
        }

    }
}
