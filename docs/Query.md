# IO.Swagger.Model.Query
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The status of the messages you would like returned (either &#39;SENT&#39;, &#39;DELIVERED&#39;, &#39;EXPIRED&#39;, &#39;DELETED&#39;, &#39;UNDELIVERABLE&#39;, &#39;ACCEPTED&#39;, &#39;UNKNOWN&#39;, &#39;REJECTED&#39;) | [optional] 
**Destination** | **string** | The phone number of the recipient. Start UK numbers with 44 and drop the leading 0. | [optional] 
**Sender** | **string** | The sender of the message (this can be the configured sender name for an outbound message or the senders phone number for an inbound message). | [optional] 
**Keyword** | **string** | The keyword used in the inbound message | [optional] 
**From** | **string** | The date-time from which you would like matching messages | [optional] 
**To** | **string** | The date-time to which you would like matching messages | [optional] 
**Metadata** | [**QueryMetadata**](QueryMetadata.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

