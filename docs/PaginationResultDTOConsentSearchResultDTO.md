# SmartAccess.Model.PaginationResultDTOConsentSearchResultDTO
Includes search result and info about pagination

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**List** | [**List&lt;ConsentSearchResultDTO&gt;**](ConsentSearchResultDTO.md) | List of search result items. Empty if no items found | 
**TotalCount** | **double** | Total number of items matching the search. Will equal taken if no take was specified in the search parameters. Use this to determine if more items can be fetched with next interval of skip and take | 
**Taken** | **double** | Number of items returned | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

