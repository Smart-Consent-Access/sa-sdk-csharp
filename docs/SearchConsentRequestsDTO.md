# SmartAccess.Model.SearchConsentRequestsDTO
Specifies the search parameters to use in the search for consent requests

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Skip** | **double** | Pagination: Number of items to skip over in the complete search result (offset). Leave out to start from the first item | [optional] 
**Take** | **double** | Pagination: Number of items to take beginning from skip (0-based index). Leave out to take all | [optional] 
**SearchQuery** | **string** | String to search for in consent requests. The following data will be searched to contain the string - Resources, actions, conditions and legal entity (id and name).  If the string matches any (OR) of these then its a search hit. An empty string matches all. Leave out to only apply the filters (fields) | [optional] 
**Fields** | [**SearchConsentRequestsDTOFields**](SearchConsentRequestsDTOFields.md) |  | 
**Sort** | [**SearchConsentsDTOSort**](SearchConsentsDTOSort.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

