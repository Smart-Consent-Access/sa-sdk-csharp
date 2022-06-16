using SmartAccess.Api;
using SmartAccess.Client;
using Jose;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

namespace SmartAccess
{
    ///<Summary>
    /// Smart access entry point
    ///</Summary>
    public class SA
    {
        private readonly Configuration _ApiConfig = new();
        private readonly BaseConfiguration _BaseConfig = new();
        public SA()
        {
            var saBaseUrlAPI = Environment.GetEnvironmentVariable("SA_BASE_URL_API") ?? "http://localhost:3000/api/v1"; // TODO: Prod URL
            var saBaseUrlWeb = Environment.GetEnvironmentVariable("SA_BASE_URL_WEB") ?? "http://localhost:8080"; // TODO: Prod URL
            var saServiceProviderId = Environment.GetEnvironmentVariable("SA_SERVICE_PROVIDER_ID");
            if (string.IsNullOrEmpty(saServiceProviderId)) throw new Exception("No ServiceProviderId");

            var saPrivateKey = Environment.GetEnvironmentVariable("SA_SERVICE_PROVIDER_PRIVATE_KEY") ??
                File.ReadAllText(
                    Path.Combine(Directory.GetCurrentDirectory(),
                        @Environment.GetEnvironmentVariable(@"SA_SERVICE_PROVIDER_PRIVATE_KEY_PATH") ??
                            @"./config/saPrivateKey.pem"
                        )
                    );

            var saPublicKey = Environment.GetEnvironmentVariable("SA_PUBLIC_KEY") ??
                File.ReadAllText(
                    Path.Combine(Directory.GetCurrentDirectory(),
                         @Environment.GetEnvironmentVariable(@"SA_PUBLIC_KEY_PATH") ??
                            @"./config/saPublicKey.pem"
                        )
                    );

            var scope = new string[] { "serviceprovider:info", "serviceprovider:ticket", "serviceprovider:flow" };

            var payload = new Dictionary<string, object>()
                {
                    { "iss", saServiceProviderId },
                    { "aud", "Association Orchestrator" },
                    { "type", "API_AUTHORIZATION" },
                    { "scope", scope }
                };

            string token = "Bearer " + CreateToken(payload, saPrivateKey);

            _ApiConfig.BasePath = saBaseUrlAPI;
            _ApiConfig.DefaultHeaders.Add("jwt", token.ToString());

            _BaseConfig.BaseUrlWeb = saBaseUrlWeb;
            _BaseConfig.PublicKey = saPublicKey;
            _BaseConfig.PrivateKey = saPrivateKey;
            _BaseConfig.ServiceProviderId = saServiceProviderId;
        }

        public ConsentRequestsApi ConsentRequests()
        {
            return new ConsentRequestsApi(_ApiConfig);
        }

        public ServiceProvidersApi ServiceProviders()
        {
            return new ServiceProvidersApi(_ApiConfig);
        }

        public ConsentsApi Consents()
        {
            return new ConsentsApi(_ApiConfig);
        }

        public ActionTemplatesApi ActionTemplates()
        {
            return new ActionTemplatesApi(_ApiConfig);
        }

        private static string CreateToken(Dictionary<string, object> payload, string privateRsaKey)
        {
            RSAParameters rsaParams;
            using (var tr = new StringReader(privateRsaKey))
            {
                var pemReader = new PemReader(tr);
                var keyPair = pemReader.ReadObject() as AsymmetricCipherKeyPair;
                if (keyPair == null)
                {
                    throw new Exception("Could not read RSA private key");
                }
                var privateRsaParams = keyPair.Private as RsaPrivateCrtKeyParameters;
                rsaParams = DotNetUtilities.ToRSAParameters(privateRsaParams);
            }
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportParameters(rsaParams);
                return JWT.Encode(payload, rsa, JwsAlgorithm.RS256);
            }
        }
    }

    public class BaseConfiguration
    {
        public BaseConfiguration() { }

        public string BaseUrlWeb { get; set; }
        public string PublicKey { get; set; }
        public string PrivateKey { get; set; }
        public string ServiceProviderId { get; set; }
    }
}