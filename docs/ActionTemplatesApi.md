# SmartAccess.Api.ActionTemplatesApi

All URIs are relative to *http://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteActionTemplate**](ActionTemplatesApi.md#deleteactiontemplate) | **DELETE** /actiontemplates/{actionTemplateId} | 
[**GetAllActionTemplatesForSP**](ActionTemplatesApi.md#getallactiontemplatesforsp) | **GET** /actiontemplates/serviceproviderid/{serviceProviderId} | 
[**GetOneActionTemplateById**](ActionTemplatesApi.md#getoneactiontemplatebyid) | **GET** /actiontemplates/id/{actionTemplateId} | 
[**PostActionTemplate**](ActionTemplatesApi.md#postactiontemplate) | **POST** /actiontemplates | 
[**UpdateActionTemplate**](ActionTemplatesApi.md#updateactiontemplate) | **PUT** /actiontemplates/{actionTemplateId} | 


<a name="deleteactiontemplate"></a>
# **DeleteActionTemplate**
> void DeleteActionTemplate (string actionTemplateId)



Deletes a action template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SmartAccess.Api;
using SmartAccess.Client;
using SmartAccess.Model;

namespace Example
{
    public class DeleteActionTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: jwt
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ActionTemplatesApi(config);
            var actionTemplateId = actionTemplateId_example;  // string | The action template id in UUID format

            try
            {
                apiInstance.DeleteActionTemplate(actionTemplateId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActionTemplatesApi.DeleteActionTemplate: " + e.Message );
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
 **actionTemplateId** | **string**| The action template id in UUID format | 

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

<a name="getallactiontemplatesforsp"></a>
# **GetAllActionTemplatesForSP**
> List&lt;ActionTemplateDTO&gt; GetAllActionTemplatesForSP (string serviceProviderId)



Fetch all action template hierarchy's on the given service provider

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SmartAccess.Api;
using SmartAccess.Client;
using SmartAccess.Model;

namespace Example
{
    public class GetAllActionTemplatesForSPExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: jwt
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ActionTemplatesApi(config);
            var serviceProviderId = serviceProviderId_example;  // string | The service provider id in UUID format

            try
            {
                List<ActionTemplateDTO> result = apiInstance.GetAllActionTemplatesForSP(serviceProviderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActionTemplatesApi.GetAllActionTemplatesForSP: " + e.Message );
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

[**List&lt;ActionTemplateDTO&gt;**](ActionTemplateDTO.md)

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

<a name="getoneactiontemplatebyid"></a>
# **GetOneActionTemplateById**
> ActionTemplateDTO GetOneActionTemplateById (string actionTemplateId)



Fetch the action template matching the ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SmartAccess.Api;
using SmartAccess.Client;
using SmartAccess.Model;

namespace Example
{
    public class GetOneActionTemplateByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: jwt
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ActionTemplatesApi(config);
            var actionTemplateId = actionTemplateId_example;  // string | The action template id in UUID format

            try
            {
                ActionTemplateDTO result = apiInstance.GetOneActionTemplateById(actionTemplateId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActionTemplatesApi.GetOneActionTemplateById: " + e.Message );
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
 **actionTemplateId** | **string**| The action template id in UUID format | 

### Return type

[**ActionTemplateDTO**](ActionTemplateDTO.md)

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

<a name="postactiontemplate"></a>
# **PostActionTemplate**
> ActionTemplateDTO PostActionTemplate (CreateActionTemplateDTO createActionTemplateDTO)



Creates a new action template hierarchy on a service provider

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SmartAccess.Api;
using SmartAccess.Client;
using SmartAccess.Model;

namespace Example
{
    public class PostActionTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: jwt
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ActionTemplatesApi(config);
            var createActionTemplateDTO = new CreateActionTemplateDTO(); // CreateActionTemplateDTO | 

            try
            {
                ActionTemplateDTO result = apiInstance.PostActionTemplate(createActionTemplateDTO);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActionTemplatesApi.PostActionTemplate: " + e.Message );
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
 **createActionTemplateDTO** | [**CreateActionTemplateDTO**](CreateActionTemplateDTO.md)|  | 

### Return type

[**ActionTemplateDTO**](ActionTemplateDTO.md)

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

<a name="updateactiontemplate"></a>
# **UpdateActionTemplate**
> ActionTemplateDTO UpdateActionTemplate (string actionTemplateId, CreateActionTemplateDTO createActionTemplateDTO)



Updates a existing action template by replacing it with a new version

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SmartAccess.Api;
using SmartAccess.Client;
using SmartAccess.Model;

namespace Example
{
    public class UpdateActionTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: jwt
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ActionTemplatesApi(config);
            var actionTemplateId = actionTemplateId_example;  // string | The action template id in UUID format
            var createActionTemplateDTO = new CreateActionTemplateDTO(); // CreateActionTemplateDTO | 

            try
            {
                ActionTemplateDTO result = apiInstance.UpdateActionTemplate(actionTemplateId, createActionTemplateDTO);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActionTemplatesApi.UpdateActionTemplate: " + e.Message );
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
 **actionTemplateId** | **string**| The action template id in UUID format | 
 **createActionTemplateDTO** | [**CreateActionTemplateDTO**](CreateActionTemplateDTO.md)|  | 

### Return type

[**ActionTemplateDTO**](ActionTemplateDTO.md)

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

