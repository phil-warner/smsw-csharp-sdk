# IO.Swagger.Api.UtilsApi

All URIs are relative to *https://api.thesmsworks.co.uk/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Hello**](UtilsApi.md#hello) | **GET** /utils/hello | 


<a name="hello"></a>
# **Hello**
> HelloWorldResponse Hello (string name = null)



Returns 'Hello' to the caller

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HelloExample
    {
        public void main()
        {
            var apiInstance = new UtilsApi();
            var name = name_example;  // string | The name of the person to whom to say hello (optional) 

            try
            {
                HelloWorldResponse result = apiInstance.Hello(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilsApi.Hello: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the person to whom to say hello | [optional] 

### Return type

[**HelloWorldResponse**](HelloWorldResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

