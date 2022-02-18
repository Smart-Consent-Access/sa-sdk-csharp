# SmartAccess.Api.BackofficeInternalAdminApi

All URIs are relative to *http://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteConsentRequest**](BackofficeInternalAdminApi.md#deleteconsentrequest) | **DELETE** /backoffice/consent_requests/{consentRequestId} | 
[**DeleteServiceProvider**](BackofficeInternalAdminApi.md#deleteserviceprovider) | **DELETE** /backoffice/serviceproviders/{serviceProviderId} | 
[**GetAllConsentRequests**](BackofficeInternalAdminApi.md#getallconsentrequests) | **GET** /backoffice/consent_requests | 
[**GetAllConsents**](BackofficeInternalAdminApi.md#getallconsents) | **GET** /backoffice/consents | 
[**GetAllServiceProviders**](BackofficeInternalAdminApi.md#getallserviceproviders) | **GET** /backoffice/serviceproviders | 
[**GetDebug**](BackofficeInternalAdminApi.md#getdebug) | **GET** /backoffice/debug | 
[**PatchServiceProviders**](BackofficeInternalAdminApi.md#patchserviceproviders) | **PATCH** /backoffice/serviceproviders/{serviceProviderId} | 
[**PostServiceProviders**](BackofficeInternalAdminApi.md#postserviceproviders) | **POST** /backoffice/serviceproviders | 


<a name="deleteconsentrequest"></a>
# **DeleteConsentRequest**
> void DeleteConsentRequest (string consentRequestId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SmartAccess.Api;
using SmartAccess.Client;
using SmartAccess.Model;

namespace Example
{
    public class DeleteConsentRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/api/v1";
            var apiInstance = new BackofficeInternalAdminApi(config);
            var consentRequestId = consentRequestId_example;  // string | 

            try
            {
                apiInstance.DeleteConsentRequest(consentRequestId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackofficeInternalAdminApi.DeleteConsentRequest: " + e.Message );
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
 **consentRequestId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteserviceprovider"></a>
# **DeleteServiceProvider**
> void DeleteServiceProvider (string serviceProviderId)



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
            var apiInstance = new BackofficeInternalAdminApi(config);
            var serviceProviderId = serviceProviderId_example;  // string | 

            try
            {
                apiInstance.DeleteServiceProvider(serviceProviderId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackofficeInternalAdminApi.DeleteServiceProvider: " + e.Message );
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
 **serviceProviderId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallconsentrequests"></a>
# **GetAllConsentRequests**
> List&lt;ConsentRequestSummaryDTO&gt; GetAllConsentRequests ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SmartAccess.Api;
using SmartAccess.Client;
using SmartAccess.Model;

namespace Example
{
    public class GetAllConsentRequestsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/api/v1";
            var apiInstance = new BackofficeInternalAdminApi(config);

            try
            {
                List<ConsentRequestSummaryDTO> result = apiInstance.GetAllConsentRequests();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackofficeInternalAdminApi.GetAllConsentRequests: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;ConsentRequestSummaryDTO&gt;**](ConsentRequestSummaryDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallconsents"></a>
# **GetAllConsents**
> List&lt;ConsentDTO&gt; GetAllConsents ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SmartAccess.Api;
using SmartAccess.Client;
using SmartAccess.Model;

namespace Example
{
    public class GetAllConsentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/api/v1";
            var apiInstance = new BackofficeInternalAdminApi(config);

            try
            {
                List<ConsentDTO> result = apiInstance.GetAllConsents();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackofficeInternalAdminApi.GetAllConsents: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;ConsentDTO&gt;**](ConsentDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallserviceproviders"></a>
# **GetAllServiceProviders**
> List&lt;ServiceProviderDTO&gt; GetAllServiceProviders ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SmartAccess.Api;
using SmartAccess.Client;
using SmartAccess.Model;

namespace Example
{
    public class GetAllServiceProvidersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/api/v1";
            var apiInstance = new BackofficeInternalAdminApi(config);

            try
            {
                List<ServiceProviderDTO> result = apiInstance.GetAllServiceProviders();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackofficeInternalAdminApi.GetAllServiceProviders: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;ServiceProviderDTO&gt;**](ServiceProviderDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdebug"></a>
# **GetDebug**
> DebugDTO GetDebug ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SmartAccess.Api;
using SmartAccess.Client;
using SmartAccess.Model;

namespace Example
{
    public class GetDebugExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/api/v1";
            var apiInstance = new BackofficeInternalAdminApi(config);

            try
            {
                DebugDTO result = apiInstance.GetDebug();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackofficeInternalAdminApi.GetDebug: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**DebugDTO**](DebugDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchserviceproviders"></a>
# **PatchServiceProviders**
> ServiceProviderDTO PatchServiceProviders (string serviceProviderId, ServiceProviderPatchDTO serviceProviderPatchDTO)



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
            var apiInstance = new BackofficeInternalAdminApi(config);
            var serviceProviderId = serviceProviderId_example;  // string | 
            var serviceProviderPatchDTO = new ServiceProviderPatchDTO(); // ServiceProviderPatchDTO | 

            try
            {
                ServiceProviderDTO result = apiInstance.PatchServiceProviders(serviceProviderId, serviceProviderPatchDTO);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackofficeInternalAdminApi.PatchServiceProviders: " + e.Message );
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
 **serviceProviderId** | **string**|  | 
 **serviceProviderPatchDTO** | [**ServiceProviderPatchDTO**](ServiceProviderPatchDTO.md)|  | 

### Return type

[**ServiceProviderDTO**](ServiceProviderDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postserviceproviders"></a>
# **PostServiceProviders**
> ServiceProviderDTO PostServiceProviders (ServiceProviderDTO serviceProviderDTO)



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
            var apiInstance = new BackofficeInternalAdminApi(config);
            var serviceProviderDTO = new ServiceProviderDTO(); // ServiceProviderDTO | 

            try
            {
                ServiceProviderDTO result = apiInstance.PostServiceProviders(serviceProviderDTO);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackofficeInternalAdminApi.PostServiceProviders: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

