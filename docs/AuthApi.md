# IO.Swagger.Api.AuthApi

All URIs are relative to *https://api.thesmsworks.co.uk/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**KeySecret**](AuthApi.md#keysecret) | **GET** /auth/getApiKey | 
[**Login**](AuthApi.md#login) | **POST** /auth/token | 


<a name="keysecret"></a>
# **KeySecret**
> ApiKeyResponse KeySecret (string customerid)



Generates an API Key/Secret pair

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class KeySecretExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();
            var customerid = customerid_example;  // string | The Customer ID

            try
            {
                ApiKeyResponse result = apiInstance.KeySecret(customerid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.KeySecret: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerid** | **string**| The Customer ID | 

### Return type

[**ApiKeyResponse**](ApiKeyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="login"></a>
# **Login**
> TokenResponse Login (Login credentials)



Generates a Json Web Token

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LoginExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();
            var credentials = new Login(); // Login | API Key & Secret

            try
            {
                TokenResponse result = apiInstance.Login(credentials);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.Login: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **credentials** | [**Login**](Login.md)| API Key &amp; Secret | 

### Return type

[**TokenResponse**](TokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

