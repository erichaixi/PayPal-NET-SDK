//==============================================================================
//
//  This file was auto-generated by a tool using the PayPal REST API schema.
//  More information: https://developer.paypal.com/docs/api/
//
//==============================================================================
using Newtonsoft.Json;
using PayPal.Util;

namespace PayPal.Api
{
    /// <summary>
    /// A REST API order resource used when making payment orders.
    /// <para>
    /// See <a href="https://developer.paypal.com/docs/api/">PayPal Developer documentation</a> for more information.
    /// </para>
    /// </summary>
    public class Order : PayPalResourceObject
    {
        /// <summary>
        /// Identifier of the order transaction.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public string id { get; set; }

        /// <summary>
        /// Identifier to the purchase unit associated with this object. Obsolete. Use one in cart_base.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "purchase_unit_reference_id")]
        public string purchase_unit_reference_id { get; set; }

        /// <summary>
        /// Amount being collected.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public Amount amount { get; set; }

        /// <summary>
        /// specifies payment mode of the transaction
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payment_mode")]
        public string payment_mode { get; set; }

        /// <summary>
        /// State of the order transaction.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state")]
        public string state { get; set; }

        /// <summary>
        /// Reason code for the transaction state being Pending or Reversed. This field will replace pending_reason field eventually
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reason_code")]
        public string reason_code { get; set; }

        /// <summary>
        /// Reason code for the transaction state being Pending. Obsolete. Retained for backward compatability. Use reason_code field above instead. 
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pending_reason")]
        public string pending_reason { get; set; }

        /// <summary>
        /// Protection Eligibility of the Payer 
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "protection_eligibility")]
        public string protection_eligibility { get; set; }

        /// <summary>
        /// Protection Eligibility Type of the Payer 
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "protection_eligibility_type")]
        public string protection_eligibility_type { get; set; }

        /// <summary>
        /// ID of the Payment resource that this transaction is based on.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "parent_payment")]
        public string parent_payment { get; set; }

        /// <summary>
        /// Fraud Management Filter (FMF) details applied for the payment that could result in accept/deny/pending action.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fmf_details")]
        public FmfDetails fmf_details { get; set; }

        /// <summary>
        /// Time the resource was created in UTC ISO8601 format.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "create_time")]
        public string create_time { get; set; }

        /// <summary>
        /// Time the resource was last updated in UTC ISO8601 format.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "update_time")]
        public string update_time { get; set; }

        /// <summary>
        /// Obtain the Order resource for the given identifier.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <param name="orderId">Identifier of the Order resource to obtain the data for.</param>
        /// <returns>Order</returns>
        public static Order Get(APIContext apiContext, string orderId)
        {
            // Validate the arguments to be used in the request
            ArgumentValidator.ValidateAndSetupAPIContext(apiContext);
            ArgumentValidator.Validate(orderId, "orderId");

            // Configure and send the request
            var pattern = "v1/payments/orders/{0}";
            var resourcePath = SDKUtil.FormatURIPath(pattern, new object[] { orderId });
            return PayPalResource.ConfigureAndExecute<Order>(apiContext, HttpMethod.GET, resourcePath);
        }

        /// <summary>
        /// Creates (and processes) a new Capture Transaction added as a related resource.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <param name="capture">Capture</param>
        /// <returns>Capture</returns>
        public Capture Capture(APIContext apiContext, Capture capture)
        {
            return Order.Capture(apiContext, this.id, capture);
        }

        /// <summary>
        /// Creates (and processes) a new Capture Transaction added as a related resource.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <param name="orderId">ID of the order to capture.</param>
        /// <param name="capture">Capture</param>
        /// <returns>Capture</returns>
        public static Capture Capture(APIContext apiContext, string orderId, Capture capture)
        {
            // Validate the arguments to be used in the request
            ArgumentValidator.ValidateAndSetupAPIContext(apiContext);
            ArgumentValidator.Validate(orderId, "orderId");
            ArgumentValidator.Validate(capture, "capture");

            // Configure and send the request
            var pattern = "v1/payments/orders/{0}/capture";
            var resourcePath = SDKUtil.FormatURIPath(pattern, new object[] { orderId });
            return PayPalResource.ConfigureAndExecute<Capture>(apiContext, HttpMethod.POST, resourcePath, capture.ConvertToJson());
        }

        /// <summary>
        /// Voids (cancels) an Order.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <returns>Order</returns>
        public Order Void(APIContext apiContext)
        {
            return Order.Void(apiContext, this.id);
        }

        /// <summary>
        /// Voids (cancels) an Order.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <param name="orderId">ID of the order to void.</param>
        /// <returns>Order</returns>
        public static Order Void(APIContext apiContext, string orderId)
        {
            // Validate the arguments to be used in the request
            ArgumentValidator.ValidateAndSetupAPIContext(apiContext);
            ArgumentValidator.Validate(orderId, "orderId");

            // Configure and send the request
            var pattern = "v1/payments/orders/{0}/do-void";
            var resourcePath = SDKUtil.FormatURIPath(pattern, new object[] { orderId });
            return PayPalResource.ConfigureAndExecute<Order>(apiContext, HttpMethod.POST, resourcePath);
        }

        /// <summary>
        /// Creates an authorization on an order
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <returns>Authorization</returns>
        public Authorization Authorize(APIContext apiContext)
        {
            return Order.Authorize(apiContext, this);
        }

        /// <summary>
        /// Creates an authorization on an order
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <param name="order">Order object to authorize.</param>
        /// <returns>Authorization</returns>
        public static Authorization Authorize(APIContext apiContext, Order order)
        {
            // Validate the arguments to be used in the request
            ArgumentValidator.ValidateAndSetupAPIContext(apiContext);
            ArgumentValidator.Validate(order, "order");

            // Configure and send the request
            var pattern = "v1/payments/orders/{0}/authorize";
            var resourcePath = SDKUtil.FormatURIPath(pattern, new object[] { order.id });
            return PayPalResource.ConfigureAndExecute<Authorization>(apiContext, HttpMethod.POST, resourcePath, order.ConvertToJson());
        }
    }
}
