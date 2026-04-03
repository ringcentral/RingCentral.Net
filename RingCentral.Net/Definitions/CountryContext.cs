namespace RingCentral
{
    /// <summary>
    /// Country context definition.
    /// 
    /// **In the request**:
    /// 
    /// Country context can be identified by `country.isoCode` value only:
    /// - If the value is not specified, it's taken from the context source:
    ///   - `Default` -> `null`
    ///   - `Account` -> home country of the requester's account
    /// - Explicitly set value redefines the value taken from the context source.
    /// - Explicitly set `null` value disables country context for parsing.
    /// 
    /// **In the response**:
    /// 
    /// Country context is returned with additional attributes.
    /// 
    /// **In particular result items**:
    /// 
    /// Country attribute is absent for the `results.category` response's attribute values: `Unknown` and `Extension`.
    /// </summary>
    public class CountryContext
    {
        /// <summary>
        ///     Two-letter country code in [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) format
        ///     Example: US
        /// </summary>
        public string isoCode { get; set; }

        /// <summary>
        ///     The official name of the country.
        ///     Example: United States
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Country calling code defined by [ITU-T](http://en.wikipedia.org/wiki/ITU-T)
        ///     recommendations, [E.123](http://en.wikipedia.org/wiki/E.123) and
        ///     [E.164](http://en.wikipedia.org/wiki/E.164).
        ///     See also [Calling Codes](http://en.wikipedia.org/wiki/List_of_country_calling_codes)
        /// </summary>
        public string callingCode { get; set; }
    }
}