namespace RingCentral
{
    /// <summary>
    ///     The OpenID Connect configuration document as defined by the
    ///     [OpenID Connect Discovery 1.0](https://openid.net/specs/openid-connect-discovery-1_0.html#ProviderMetadata)
    ///     specification
    /// </summary>
    public class OpenIdDiscovery
    {
        /// <summary>
        ///     An identifier of the ID token's issuer. This value is identical to the `iss` Claim value in ID Tokens
        ///     Required
        ///     Format: uri
        ///     Example: https://platform.ringcentral.com
        /// </summary>
        public string issuer { get; set; }

        /// <summary>
        ///     URL of the OAuth 2.0 authorization endpoint
        ///     Required
        ///     Format: uri
        ///     Example: https://platform.ringcentral.com/restapi/oauth/authorize
        /// </summary>
        public string authorization_endpoint { get; set; }

        /// <summary>
        ///     URL of the OAuth 2.0 token endpoint
        ///     Required
        ///     Format: uri
        ///     Example: https://platform.ringcentral.com/restapi/oauth/token
        /// </summary>
        public string token_endpoint { get; set; }

        /// <summary>
        ///     URL of the OAuth 2.0 revocation endpoint as defined by [RFC-7009](https://datatracker.ietf.org/doc/html/rfc7009)
        ///     Required
        ///     Format: uri
        ///     Example: https://platform.ringcentral.com/restapi/oauth/revoke
        /// </summary>
        public string revocation_endpoint { get; set; }

        /// <summary>
        ///     URL of the user info endpoint as defined by
        ///     [OpenID Connect Core 1.0](https://openid.net/specs/openid-connect-core-1_0.html#UserInfo) specification
        ///     Required
        ///     Format: uri
        ///     Example: https://platform.ringcentral.com/restapi/oauth/userinfo
        /// </summary>
        public string userinfo_endpoint { get; set; }

        /// <summary>
        ///     URL of JSON Web Key Set document that contains public key(s) to be used by the Relying Party
        ///     to validate ID Token signatures
        ///     Required
        ///     Format: uri
        ///     Example: https://platform.ringcentral.com/restapi/oauth/jwks
        /// </summary>
        public string jwks_uri { get; set; }

        /// <summary>
        ///     The list of the OAuth 2.0 scope values that this server supports
        ///     Required
        ///     Example: openid,email,profile
        ///     Enum: openid, email, profile
        /// </summary>
        public string[] scopes_supported { get; set; }

        /// <summary>
        ///     The list of Client Authentication methods supported by the Token Endpoint
        ///     Required
        ///     Example: client_secret_basic
        ///     Enum: client_secret_basic, client_secret_jwt, private_key_jwt
        /// </summary>
        public string[] token_endpoint_auth_methods_supported { get; set; }

        /// <summary>
        ///     The list of the OAuth 2.0 `response_type` values supported by the provider
        ///     Required
        ///     Example: code
        ///     Enum: code
        /// </summary>
        public string[] response_types_supported { get; set; }

        /// <summary>
        ///     The list of the Subject Identifier types supported by the provider (only `public` is currently supported)
        ///     Required
        ///     Example: public
        ///     Enum: public
        /// </summary>
        public string[] subject_types_supported { get; set; }

        /// <summary>
        ///     The list of the JWS signing algorithms (`alg` values) supported by the UserInfo Endpoint  to encode the Claims in a
        ///     JWT
        ///     Required
        ///     Example: none
        ///     Enum: none
        /// </summary>
        public string[] userinfo_signing_alg_values_supported { get; set; }

        /// <summary>
        ///     The list of the JWS signing algorithms (`alg` values) supported by the provider for the ID Token
        ///     to encode the Claims in a JWT
        ///     Required
        ///     Example: RS256,HS256
        ///     Enum: RS256, HS256
        /// </summary>
        public string[] id_token_signing_alg_values_supported { get; set; }

        /// <summary>
        ///     The list of the `display` parameter values (in OAuth 2.0 Authorization Endpoint) supported by the provider
        ///     Enum: page, popup, touch, mobile
        /// </summary>
        public string[] display_values_supported { get; set; }

        /// <summary>
        ///     The list of the Claim Names of the Claims that the OpenID Provider MAY be able to supply values for
        ///     Example: sub,iss,auth_time,exp
        ///     Enum: sub, iss, auth_time, aud, exp, iat, jti, nonce, account_id, email, email_verified, given_name, family_name
        /// </summary>
        public string[] claims_supported { get; set; }

        /// <summary>
        ///     Language codes supported for the user interface, represented as language tags defined in
        ///     [RFC-5646](https://datatracker.ietf.org/doc/html/rfc5646)
        ///     Example: en,en-US,en-GB,fr-CA
        /// </summary>
        public string[] ui_locales_supported { get; set; }

        /// <summary>
        ///     Boolean value specifying whether the provide supports use of the `claims` parameter
        /// </summary>
        public bool? claims_parameter_supported { get; set; }

        /// <summary>
        ///     Boolean value specifying whether the provide supports use of the `request` parameter
        /// </summary>
        public bool? request_parameter_supported { get; set; }

        /// <summary>
        ///     Boolean value specifying whether the provide supports use of the `request` parameter
        /// </summary>
        public bool? request_uri_parameter_supported { get; set; }
    }
}