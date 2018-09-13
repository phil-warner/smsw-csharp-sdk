# IO.Swagger.Api.MessagesApi

All URIs are relative to *https://api.thesmsworks.co.uk/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelScheduledJob**](MessagesApi.md#cancelscheduledjob) | **DELETE** /messages/schedule/{messageid} | 
[**GetInboxMessages**](MessagesApi.md#getinboxmessages) | **POST** /messages/inbox | 
[**GetMessageById**](MessagesApi.md#getmessagebyid) | **GET** /messages/{messageid} | 
[**GetMessages**](MessagesApi.md#getmessages) | **POST** /messages | 
[**ScheduleMessage**](MessagesApi.md#schedulemessage) | **POST** /message/schedule | 
[**SendMessage**](MessagesApi.md#sendmessage) | **POST** /message/send | 


<a name="cancelscheduledjob"></a>
# **CancelScheduledJob**
> CancelledMessageResponse CancelScheduledJob (string messageid)



Cancels a scheduled SMS message

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CancelScheduledJobExample
    {
        public void main()
        {
            // Configure API key authorization: JWT
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessagesApi();
            var messageid = messageid_example;  // string | The ID of the message you would like returned

            try
            {
                CancelledMessageResponse result = apiInstance.CancelScheduledJob(messageid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagesApi.CancelScheduledJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageid** | **string**| The ID of the message you would like returned | 

### Return type

[**CancelledMessageResponse**](CancelledMessageResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinboxmessages"></a>
# **GetInboxMessages**
> MessagesResponse GetInboxMessages (Query query)



Get unread uncoming messages matching your search criteria

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetInboxMessagesExample
    {
        public void main()
        {
            // Configure API key authorization: JWT
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessagesApi();
            var query = new Query(); // Query | 

            try
            {
                MessagesResponse result = apiInstance.GetInboxMessages(query);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagesApi.GetInboxMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | [**Query**](Query.md)|  | 

### Return type

[**MessagesResponse**](MessagesResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmessagebyid"></a>
# **GetMessageById**
> MessageResponse GetMessageById (string messageid)



Retrieve a logged message by the message ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMessageByIdExample
    {
        public void main()
        {
            // Configure API key authorization: JWT
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessagesApi();
            var messageid = messageid_example;  // string | The ID of the message you would like returned

            try
            {
                MessageResponse result = apiInstance.GetMessageById(messageid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagesApi.GetMessageById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageid** | **string**| The ID of the message you would like returned | 

### Return type

[**MessageResponse**](MessageResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmessages"></a>
# **GetMessages**
> MessagesResponse GetMessages (Query query)



Get messages matching your search criteria

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMessagesExample
    {
        public void main()
        {
            // Configure API key authorization: JWT
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessagesApi();
            var query = new Query(); // Query | 

            try
            {
                MessagesResponse result = apiInstance.GetMessages(query);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagesApi.GetMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | [**Query**](Query.md)|  | 

### Return type

[**MessagesResponse**](MessagesResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="schedulemessage"></a>
# **ScheduleMessage**
> ScheduledMessageResponse ScheduleMessage (Message smsMessage)



Schedules an SMS message to be sent at the date-time you specify

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ScheduleMessageExample
    {
        public void main()
        {
            // Configure API key authorization: JWT
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessagesApi();
            var smsMessage = new Message(); // Message | Message properties

            try
            {
                ScheduledMessageResponse result = apiInstance.ScheduleMessage(smsMessage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagesApi.ScheduleMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **smsMessage** | [**Message**](Message.md)| Message properties | 

### Return type

[**ScheduledMessageResponse**](ScheduledMessageResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendmessage"></a>
# **SendMessage**
> SendMessageResponse SendMessage (Message smsMessage)



Sends an SMS message

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SendMessageExample
    {
        public void main()
        {
            // Configure API key authorization: JWT
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessagesApi();
            var smsMessage = new Message(); // Message | Message properties

            try
            {
                SendMessageResponse result = apiInstance.SendMessage(smsMessage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagesApi.SendMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **smsMessage** | [**Message**](Message.md)| Message properties | 

### Return type

[**SendMessageResponse**](SendMessageResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

