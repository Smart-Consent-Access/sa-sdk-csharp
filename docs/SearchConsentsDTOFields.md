# SmartAccess.Model.SearchConsentsDTOFields
Fields to filter on in the search. Atleast reqServiceProviderId or consServiceProviderId or both is required and the searching serviceprovider (caller) must be one of them. The other fields are optional. It is a search hit if all fields matches a consent request (AND)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConsentRequestId** | **string** | Only take consents for consent request of id | [optional] 
**StopCreatedAt** | **string** | Only take consents created before or equal to this timestamp. | [optional] 
**StartCreatedAt** | **string** | Only take consents created after or equal to this timestamp. Will be passed to JavaScripts Date constructor so must be a valid time-string that is accepted. The database stores dates without timezone (UTC) and the comparison is done without timezone | [optional] 
**Status** | **string** | Consent status, for example \&quot;INITIALIZED\&quot;, \&quot;FINALIZED\&quot; or \&quot;INACTIVE\&quot; | [optional] 
**ConsServiceProviderId** | **string** | The serviceprovider that consented (approval) | [optional] 
**ReqServiceProviderId** | **string** | The serviceprovider that requested the consent (consent request) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

