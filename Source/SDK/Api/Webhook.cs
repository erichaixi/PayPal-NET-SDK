//==============================================================================
//
//  This file was auto-generated by a tool using the PayPal REST API schema.
//  More information: https://developer.paypal.com/docs/api/
//
//==============================================================================
using System.Collections.Generic;
using Newtonsoft.Json;
using PayPal.Util;

namespace PayPal.Api
{
    /// <summary>
    /// A REST API webhook resource object.
    /// <para>
    /// See <a href="https://developer.paypal.com/docs/api/">PayPal Developer documentation</a> for more information.
    /// </para>
    /// </summary>
    public class Webhook : PayPalResourceObject
    {
        /// <summary>
        /// Identifier of the webhook resource.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public string id { get; set; }

        /// <summary>
        /// Webhook notification endpoint url.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "url")]
        public string url { get; set; }

        /// <summary>
        /// List of Webhooks event-types.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "event_types")]
        public List<WebhookEventType> event_types { get; set; }

        /// <summary>
        /// Creates the Webhook for the application associated with the access token.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <returns>Webhook</returns>
        public Webhook Create(APIContext apiContext)
        {
            return Webhook.Create(apiContext, this);
        }

        /// <summary>
        /// Creates the Webhook for the application associated with the access token.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <returns>Webhook</returns>
        public static Webhook Create(APIContext apiContext, Webhook webhook)
        {
            // Validate the arguments to be used in the request
            ArgumentValidator.ValidateAndSetupAPIContext(apiContext);

            // Configure and send the request
            var resourcePath = "v1/notifications/webhooks";
            return PayPalResource.ConfigureAndExecute<Webhook>(apiContext, HttpMethod.POST, resourcePath, webhook.ConvertToJson());
        }

        /// <summary>
        /// Retrieves the Webhook identified by webhook_id for the application associated with access token.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <param name="webhookId">Identifier of the webhook</param>
        /// <returns>Webhook</returns>
        public static Webhook Get(APIContext apiContext, string webhookId)
        {
            // Validate the arguments to be used in the request
            ArgumentValidator.ValidateAndSetupAPIContext(apiContext);
            ArgumentValidator.Validate(webhookId, "webhookId");

            // Configure and send the request
            var pattern = "v1/notifications/webhooks/{0}";
            var resourcePath = SDKUtil.FormatURIPath(pattern, new object[] { webhookId });
            return PayPalResource.ConfigureAndExecute<Webhook>(apiContext, HttpMethod.GET, resourcePath);
        }

        /// <summary>
        /// Retrieves all Webhooks for the application associated with access token.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <returns>WebhookList</returns>
        public static WebhookList GetAll(APIContext apiContext)
        {
            // Validate the arguments to be used in the request
            ArgumentValidator.ValidateAndSetupAPIContext(apiContext);

            // Configure and send the request
            var resourcePath = "v1/notifications/webhooks";
            return PayPalResource.ConfigureAndExecute<WebhookList>(apiContext, HttpMethod.GET, resourcePath);
        }

        /// <summary>
        /// Updates the Webhook identified by webhook_id for the application associated with access token.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <param name="patchRequest">PatchRequest</param>
        /// <returns>Webhook</returns>
        public Webhook Update(APIContext apiContext, PatchRequest patchRequest)
        {
            return Webhook.Update(apiContext, this.id, patchRequest);
        }

        /// <summary>
        /// Updates the Webhook identified by webhook_id for the application associated with access token.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <param name="patchRequest">PatchRequest</param>
        /// <returns>Webhook</returns>
        public static Webhook Update(APIContext apiContext, string webhookId, PatchRequest patchRequest)
        {
            // Validate the arguments to be used in the request
            ArgumentValidator.ValidateAndSetupAPIContext(apiContext);
            ArgumentValidator.Validate(webhookId, "webhookId");
            ArgumentValidator.Validate(patchRequest, "patchRequest");

            // Configure and send the request
            var pattern = "v1/notifications/webhooks/{0}";
            var resourcePath = SDKUtil.FormatURIPath(pattern, new object[] { webhookId });
            return PayPalResource.ConfigureAndExecute<Webhook>(apiContext, HttpMethod.PATCH, resourcePath, patchRequest.ConvertToJson());
        }

        /// <summary>
        /// Deletes the Webhook identified by webhook_id for the application associated with access token.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        public void Delete(APIContext apiContext)
        {
            Webhook.Delete(apiContext, this.id);
        }

        /// <summary>
        /// Deletes the Webhook identified by webhook_id for the application associated with access token.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <param name="webhookId">Identifier of the webhook</param>
        public static void Delete(APIContext apiContext, string webhookId)
        {
            // Validate the arguments to be used in the request
            ArgumentValidator.ValidateAndSetupAPIContext(apiContext);
            ArgumentValidator.Validate(webhookId, "webhookId");

            // Configure and send the request
            apiContext.MaskRequestId = true;
            var pattern = "v1/notifications/webhooks/{0}";
            var resourcePath = SDKUtil.FormatURIPath(pattern, new object[] { webhookId });
            PayPalResource.ConfigureAndExecute(apiContext, HttpMethod.DELETE, resourcePath);
        }
    }
}
