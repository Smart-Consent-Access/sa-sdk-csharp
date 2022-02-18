# SmartAccess.Api.ConsentsApi

All URIs are relative to *http://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAuthZTicketForConsent**](ConsentsApi.md#createauthzticketforconsent) | **GET** /consents/{consentId}/ticket | 
[**FlowConsentApprovalFinalize**](ConsentsApi.md#flowconsentapprovalfinalize) | **POST** /consents/flow_consent_approval_finalize | 
[**FlowConsentApprovalInitialize**](ConsentsApi.md#flowconsentapprovalinitialize) | **POST** /consents/flow_consent_approval_initialize | 
[**GetConsent**](ConsentsApi.md#getconsent) | **GET** /consents/{consentId} | 


<a name="createauthzticketforconsent"></a>
# **CreateAuthZTicketForConsent**
> AuthTicketDTO CreateAuthZTicketForConsent (string consentId)



Create an authorization ticket for the given consent This ticket can be used against the consenting service provider for further integration to prove that the calling service provider is authorized

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SmartAccess.Api;
using SmartAccess.Client;
using SmartAccess.Model;

namespace Example
{
    public class CreateAuthZTicketForConsentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: jwt
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConsentsApi(config);
            var consentId = consentId_example;  // string | The consent id in UUID format

            try
            {
                AuthTicketDTO result = apiInstance.CreateAuthZTicketForConsent(consentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConsentsApi.CreateAuthZTicketForConsent: " + e.Message );
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
 **consentId** | **string**| The consent id in UUID format | 

### Return type

[**AuthTicketDTO**](AuthTicketDTO.md)

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

<a name="flowconsentapprovalfinalize"></a>
# **FlowConsentApprovalFinalize**
> ApprovalDoneUrlDTO FlowConsentApprovalFinalize (ConsentApprovalFinalizeBody consentApprovalFinalizeBody)



Finalize a consent approval as the requesting service provider. The information about the request to approve is specified in the request body with a signed JWT which will be verified to be signed by the calling/requesting service provider

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SmartAccess.Api;
using SmartAccess.Client;
using SmartAccess.Model;

namespace Example
{
    public class FlowConsentApprovalFinalizeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/api/v1";
            var apiInstance = new ConsentsApi(config);
            var consentApprovalFinalizeBody = new ConsentApprovalFinalizeBody(); // ConsentApprovalFinalizeBody | The signed jwt with payload of type SAConsApprovalFinalizeSp1ToSaJWT

            try
            {
                ApprovalDoneUrlDTO result = apiInstance.FlowConsentApprovalFinalize(consentApprovalFinalizeBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConsentsApi.FlowConsentApprovalFinalize: " + e.Message );
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
 **consentApprovalFinalizeBody** | [**ConsentApprovalFinalizeBody**](ConsentApprovalFinalizeBody.md)| The signed jwt with payload of type SAConsApprovalFinalizeSp1ToSaJWT | 

### Return type

[**ApprovalDoneUrlDTO**](ApprovalDoneUrlDTO.md)

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
| **422** | Validation failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="flowconsentapprovalinitialize"></a>
# **FlowConsentApprovalInitialize**
> ApprovalDoneUrlDTO FlowConsentApprovalInitialize (ConsentApprovalInitializeBody consentApprovalInitializeBody)



Initialize a consent approval as the consenting service provider. The information about the request to approve is specified in the request body with a signed JWT which will be verified to be signed by the calling/consenting service provider

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SmartAccess.Api;
using SmartAccess.Client;
using SmartAccess.Model;

namespace Example
{
    public class FlowConsentApprovalInitializeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/api/v1";
            var apiInstance = new ConsentsApi(config);
            var consentApprovalInitializeBody = new ConsentApprovalInitializeBody(); // ConsentApprovalInitializeBody | The signed jwt with payload of type SAConsApprovalInitializeSp2ToSaJWT

            try
            {
                ApprovalDoneUrlDTO result = apiInstance.FlowConsentApprovalInitialize(consentApprovalInitializeBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConsentsApi.FlowConsentApprovalInitialize: " + e.Message );
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
 **consentApprovalInitializeBody** | [**ConsentApprovalInitializeBody**](ConsentApprovalInitializeBody.md)| The signed jwt with payload of type SAConsApprovalInitializeSp2ToSaJWT | 

### Return type

[**ApprovalDoneUrlDTO**](ApprovalDoneUrlDTO.md)

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
| **422** | Validation failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconsent"></a>
# **GetConsent**
> ConsentDTO GetConsent (string consentId)



Fetch information about the given consent

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SmartAccess.Api;
using SmartAccess.Client;
using SmartAccess.Model;

namespace Example
{
    public class GetConsentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: jwt
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConsentsApi(config);
            var consentId = consentId_example;  // string | The consent id in UUID format

            try
            {
                ConsentDTO result = apiInstance.GetConsent(consentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConsentsApi.GetConsent: " + e.Message );
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
 **consentId** | **string**| The consent id in UUID format | 

### Return type

[**ConsentDTO**](ConsentDTO.md)

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

