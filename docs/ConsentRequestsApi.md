# SmartAccess.Api.ConsentRequestsApi

All URIs are relative to *http://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteId**](ConsentRequestsApi.md#deleteid) | **DELETE** /consent_requests/{consentRequestId} | 
[**FlowConsentRequestFinalize**](ConsentRequestsApi.md#flowconsentrequestfinalize) | **POST** /consent_requests/flow_consent_req_finalize | 
[**FlowConsentRequestInitialize**](ConsentRequestsApi.md#flowconsentrequestinitialize) | **POST** /consent_requests/flow_consent_req_initialize | 
[**GetConsentRequest**](ConsentRequestsApi.md#getconsentrequest) | **GET** /consent_requests/{consentRequestId} | 
[**GetConsentRequests**](ConsentRequestsApi.md#getconsentrequests) | **GET** /consent_requests | 
[**SearchConsentRequests**](ConsentRequestsApi.md#searchconsentrequests) | **POST** /consent_requests/search | 


<a name="deleteid"></a>
# **DeleteId**
> void DeleteId (string consentRequestId)



Soft delete (set to INACTIVE) the given consent request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SmartAccess.Api;
using SmartAccess.Client;
using SmartAccess.Model;

namespace Example
{
    public class DeleteIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: jwt
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConsentRequestsApi(config);
            var consentRequestId = consentRequestId_example;  // string | The consent request id in UUID format

            try
            {
                apiInstance.DeleteId(consentRequestId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConsentRequestsApi.DeleteId: " + e.Message );
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
 **consentRequestId** | **string**| The consent request id in UUID format | 

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
| **403** | Authorization failed |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="flowconsentrequestfinalize"></a>
# **FlowConsentRequestFinalize**
> ConsentRequestFinalizeUrlDTO FlowConsentRequestFinalize (ConsentRequestFinalizeBody consentRequestFinalizeBody)



Finalize a consent request as the consenting service provider. The information about the consent request is specified in the request body with a signed JWT which will be verified to be signed by the calling/consenting service provider

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SmartAccess.Api;
using SmartAccess.Client;
using SmartAccess.Model;

namespace Example
{
    public class FlowConsentRequestFinalizeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/api/v1";
            var apiInstance = new ConsentRequestsApi(config);
            var consentRequestFinalizeBody = new ConsentRequestFinalizeBody(); // ConsentRequestFinalizeBody | The signed jwt with payload of type SAConsReqFinalizeSp2ToSaJWT

            try
            {
                ConsentRequestFinalizeUrlDTO result = apiInstance.FlowConsentRequestFinalize(consentRequestFinalizeBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConsentRequestsApi.FlowConsentRequestFinalize: " + e.Message );
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
 **consentRequestFinalizeBody** | [**ConsentRequestFinalizeBody**](ConsentRequestFinalizeBody.md)| The signed jwt with payload of type SAConsReqFinalizeSp2ToSaJWT | 

### Return type

[**ConsentRequestFinalizeUrlDTO**](ConsentRequestFinalizeUrlDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **401** | Authentication failed |  -  |
| **403** | Authorization failed |  -  |
| **404** | Resource not found |  -  |
| **422** | Actions, resources or conditions are not valid |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="flowconsentrequestinitialize"></a>
# **FlowConsentRequestInitialize**
> ConsentRequestUrlDTO FlowConsentRequestInitialize (ConsentRequestTokenBody consentRequestTokenBody)



Initialize a consent request as the requesting service provider. The information about the request is specified in the request body with a signed JWT which will be verified to be signed by the calling/requesting service provider

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SmartAccess.Api;
using SmartAccess.Client;
using SmartAccess.Model;

namespace Example
{
    public class FlowConsentRequestInitializeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/api/v1";
            var apiInstance = new ConsentRequestsApi(config);
            var consentRequestTokenBody = new ConsentRequestTokenBody(); // ConsentRequestTokenBody | The signed jwt with payload of type SAConsReqInitializeSp1ToSaJWT

            try
            {
                ConsentRequestUrlDTO result = apiInstance.FlowConsentRequestInitialize(consentRequestTokenBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConsentRequestsApi.FlowConsentRequestInitialize: " + e.Message );
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
 **consentRequestTokenBody** | [**ConsentRequestTokenBody**](ConsentRequestTokenBody.md)| The signed jwt with payload of type SAConsReqInitializeSp1ToSaJWT | 

### Return type

[**ConsentRequestUrlDTO**](ConsentRequestUrlDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **401** | Authentication failed |  -  |
| **403** | Authorization failed |  -  |
| **404** | Resource not found |  -  |
| **422** | Actions, resources or conditions are not valid |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconsentrequest"></a>
# **GetConsentRequest**
> ConsentRequestSummaryDTO GetConsentRequest (string consentRequestId)



Fetch information about the given consent request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SmartAccess.Api;
using SmartAccess.Client;
using SmartAccess.Model;

namespace Example
{
    public class GetConsentRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: jwt
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConsentRequestsApi(config);
            var consentRequestId = consentRequestId_example;  // string | The consent request id in UUID format

            try
            {
                ConsentRequestSummaryDTO result = apiInstance.GetConsentRequest(consentRequestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConsentRequestsApi.GetConsentRequest: " + e.Message );
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
 **consentRequestId** | **string**| The consent request id in UUID format | 

### Return type

[**ConsentRequestSummaryDTO**](ConsentRequestSummaryDTO.md)

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
| **403** | Authorization failed |  -  |
| **404** | Resource not found |  -  |
| **422** | Validation failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconsentrequests"></a>
# **GetConsentRequests**
> List&lt;ConsentRequestSummaryDTO&gt; GetConsentRequests (string direction)



Fetch information about all consent requests that the caller is either the requester or consenter for

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SmartAccess.Api;
using SmartAccess.Client;
using SmartAccess.Model;

namespace Example
{
    public class GetConsentRequestsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: jwt
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConsentRequestsApi(config);
            var direction = direction_example;  // string | Either for_me (consenter) or by_me (requester)

            try
            {
                List<ConsentRequestSummaryDTO> result = apiInstance.GetConsentRequests(direction);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConsentRequestsApi.GetConsentRequests: " + e.Message );
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
 **direction** | **string**| Either for_me (consenter) or by_me (requester) | 

### Return type

[**List&lt;ConsentRequestSummaryDTO&gt;**](ConsentRequestSummaryDTO.md)

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
| **422** | Validation failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchconsentrequests"></a>
# **SearchConsentRequests**
> PaginationResultDTOConsentRequestSearchResultDTO SearchConsentRequests (SearchConsentRequestsDTO searchConsentRequestsDTO)



Search for consent requests given some search parameters. See SearchConsentRequestsDTO for details on parameters. Will return a list of matching consent requests

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SmartAccess.Api;
using SmartAccess.Client;
using SmartAccess.Model;

namespace Example
{
    public class SearchConsentRequestsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: jwt
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConsentRequestsApi(config);
            var searchConsentRequestsDTO = new SearchConsentRequestsDTO(); // SearchConsentRequestsDTO | The search parameters

            try
            {
                PaginationResultDTOConsentRequestSearchResultDTO result = apiInstance.SearchConsentRequests(searchConsentRequestsDTO);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConsentRequestsApi.SearchConsentRequests: " + e.Message );
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
 **searchConsentRequestsDTO** | [**SearchConsentRequestsDTO**](SearchConsentRequestsDTO.md)| The search parameters | 

### Return type

[**PaginationResultDTOConsentRequestSearchResultDTO**](PaginationResultDTOConsentRequestSearchResultDTO.md)

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
| **403** | Authorization failed |  -  |
| **422** | Validation failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

