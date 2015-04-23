//==============================================================================
//
//  This file was auto-generated by a tool using the PayPal REST API schema.
//  More information: https://developer.paypal.com/docs/api/
//
//==============================================================================
using Newtonsoft.Json;
using System;

namespace PayPal.Api
{
    /// <summary>
    /// Details of a transaction associated with a billing agreement.
    /// <para>
    /// See <a href="https://developer.paypal.com/docs/api/">PayPal Developer documentation</a> for more information.
    /// </para>
    /// </summary>
    public class AgreementTransaction : PayPalSerializableObject
    {
        /// <summary>
        /// Id corresponding to this transaction.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "transaction_id")]
        public string transaction_id { get; set; }

        /// <summary>
        /// State of the subscription at this time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status")]
        public string status { get; set; }

        /// <summary>
        /// Type of transaction, usually Recurring Payment.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "transaction_type")]
        public string transaction_type { get; set; }

        /// <summary>
        /// Amount for this transaction.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public Currency amount { get; set; }

        /// <summary>
        /// Fee amount for this transaction.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fee_amount")]
        public Currency fee_amount { get; set; }

        /// <summary>
        /// Net amount for this transaction.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "net_amount")]
        public Currency net_amount { get; set; }

        /// <summary>
        /// Email id of payer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payer_email")]
        public string payer_email { get; set; }

        /// <summary>
        /// Business name of payer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payer_name")]
        public string payer_name { get; set; }

        /// <summary>
        /// Time at which this transaction happened.
        /// </summary>
        [JsonIgnore]
        [Obsolete("This property is obsolete. Use time_stamp instead.", false)]
        public string time_updated
        {
            get { return this.time_stamp; }
            set { this.time_stamp = value; }
        }

        /// <summary>
        /// Time at which this transaction happened.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "time_stamp")]
        public string time_stamp { get; set; }

        /// <summary>
        /// Time zone of time_updated field.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "time_zone")]
        public string time_zone { get; set; }
    }
}
