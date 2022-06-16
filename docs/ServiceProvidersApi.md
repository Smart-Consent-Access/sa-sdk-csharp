# SmartAccess.Api.ServiceProvidersApi

All URIs are relative to *http://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteServiceProvider**](ServiceProvidersApi.md#deleteserviceprovider) | **DELETE** /serviceproviders/{serviceProviderId} | 
[**GetServiceProvider**](ServiceProvidersApi.md#getserviceprovider) | **GET** /serviceproviders/{id} | 
[**PatchServiceProviders**](ServiceProvidersApi.md#patchserviceproviders) | **PATCH** /serviceproviders/{serviceProviderId} | 
[**PostServiceProviders**](ServiceProvidersApi.md#postserviceproviders) | **POST** /serviceproviders | 


<a name="deleteserviceprovider"></a>
# **DeleteServiceProvider**
> void DeleteServiceProvider (string serviceProviderId)



Soft deletes (set to INACTIVE) a service provider

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SmartAccess.Api;
using SmartAccess.Client;
using SmartAccess.Model;

namespace Example
{
    public class DeleteServiceProviderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: jwt
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServiceProvidersApi(config);
            var serviceProviderId = serviceProviderId_example;  // string | The service provider id in UUID format

            try
            {
                apiInstance.DeleteServiceProvider(serviceProviderId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceProvidersApi.DeleteServiceProvider: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceProviderId** | **string**| The service provider id in UUID format | 

### Return type

void (empty response body)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **401** | Authentication failed |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getserviceprovider"></a>
# **GetServiceProvider**
> ServiceProviderDTO GetServiceProvider (string id)



Fetch information about the given service provider

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SmartAccess.Api;
using SmartAccess.Client;
using SmartAccess.Model;

namespace Example
{
    public class GetServiceProviderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: jwt
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServiceProvidersApi(config);
            var id = id_example;  // string | The service provider id in UUID format

            try
            {
                ServiceProviderDTO result = apiInstance.GetServiceProvider(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceProvidersApi.GetServiceProvider: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The service provider id in UUID format | 

### Return type

[**ServiceProviderDTO**](ServiceProviderDTO.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **401** | Authentication failed |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchserviceproviders"></a>
# **PatchServiceProviders**
> ServiceProviderDTO PatchServiceProviders (string serviceProviderId, ServiceProviderPatchDTO serviceProviderPatchDTO)



Updates a service provider with new data. Only updates explicitly set new values, rest is left as is

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SmartAccess.Api;
using SmartAccess.Client;
using SmartAccess.Model;

namespace Example
{
    public class PatchServiceProvidersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: jwt
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServiceProvidersApi(config);
            var serviceProviderId = serviceProviderId_example;  // string | The service provider id in UUID format
            var serviceProviderPatchDTO = new ServiceProviderPatchDTO(); // ServiceProviderPatchDTO | 

            try
            {
                ServiceProviderDTO result = apiInstance.PatchServiceProviders(serviceProviderId, serviceProviderPatchDTO);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceProvidersApi.PatchServiceProviders: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceProviderId** | **string**| The service provider id in UUID format | 
 **serviceProviderPatchDTO** | [**ServiceProviderPatchDTO**](ServiceProviderPatchDTO.md)|  | 

### Return type

[**ServiceProviderDTO**](ServiceProviderDTO.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **401** | Authentication failed |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postserviceproviders"></a>
# **PostServiceProviders**
> ServiceProviderDTO PostServiceProviders (ServiceProviderDTO serviceProviderDTO)



Creates a new service provider in SA

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SmartAccess.Api;
using SmartAccess.Client;
using SmartAccess.Model;

namespace Example
{
    public class PostServiceProvidersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: jwt
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServiceProvidersApi(config);
            var serviceProviderDTO = new ServiceProviderDTO(); // ServiceProviderDTO | 

            try
            {
                ServiceProviderDTO result = apiInstance.PostServiceProviders(serviceProviderDTO);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceProvidersApi.PostServiceProviders: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceProviderDTO** | [**ServiceProviderDTO**](ServiceProviderDTO.md)|  | 

### Return type

[**ServiceProviderDTO**](ServiceProviderDTO.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **401** | Authentication failed |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

