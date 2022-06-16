# SmartAccess.Model.ConsentDTO
An approved consent, given by the person referenced by Legal Entity. Points to the corresponding (Authorization) Policy that this consent gives right to.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**Type** | **ConsentType** |  | 
**LegalEntity** | [**LegalEntityDTO**](LegalEntityDTO.md) |  | [optional] 
**Policy** | [**List&lt;PolicyDTO&gt;**](PolicyDTO.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

