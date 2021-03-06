﻿// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Profile
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The profile.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class Profile
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the company info.
        /// </summary>
        public ProfileCompanyInfo CompanyInfo { get; set; }

        /// <summary>
        ///     Gets or sets the customer.
        /// </summary>
        public ProfileCustomer Customer { get; set; }

        /// <summary>
        ///     Gets or sets the preference collections.
        /// </summary>
        public ProfilePreferenceCollections PrefCollections { get; set; }

        #endregion
    }
}