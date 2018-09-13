# IO.Swagger.Api.UtilsApi

All URIs are relative to *https://api.thesmsworks.co.uk/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Test**](UtilsApi.md#test) | **GET** /utils/test | 


<a name="test"></a>
# **Test**
> TestResponse Test ()



Returns the customer ID to the caller

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TestExample
    {
        public void main()
        {
            var apiInstance = new UtilsApi();

            try
            {
                TestResponse result = apiInstance.Test();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilsApi.Test: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TestResponse**](TestResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

