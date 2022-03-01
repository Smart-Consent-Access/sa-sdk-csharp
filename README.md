# Smart Access SDK for C#

##  Install

`dotnet add package SmartAccess.SDK --version 1.0.4`

`using SmartAccess;`

## Usage

Set the following environment variables: 

```
SA_SERVICE_PROVIDER_PRIVATE_KEY_PATH="path_to_private_key.pem"
SA_PUBLIC_KEY_PATH="path_to_public_key.pem"
SA_BASE_URL_API="https://ao.sandbox.smartconsent.se/api/v1"
SA_BASE_URL_WEB="https://ao.sandbox.smartconsent.se"
SA_SERVICE_PROVIDER_ID="your_service_provider_id"
```

`SA SmartAccess = new SA();`

### Classes

SA.serviceProviders -> SA endpoints for service provider

SA.consentRequests -> SA endpoints for consentRequests

SA.consents -> SA endpoints for consents

### Examples

#### Creating a consent request initialization:

```
using SmartAccess;
using SmartAccess.Model;

SA SmartAccess = new SA();

var TokenBody = new {
    goal = "INITIATE",
    type = "CONSENT_REQUEST",
    kind = "FLOW",
    scope = new String[]{"serviceprovider:flow"},
    reqServiceProviderId = "serviceProviderId",
    consServiceProviderId = "consentServiceProviderId",
    reqPrincipalId = "requestPrincipalId",
    reqPrincipalName = "requestPrincipalName",
    actions = new String[]{"actions"},
    resources = new String[]{"resources"},
    conditions = new String[]{"conditions"},
    termsAndConditions = "termsAndConditions"
};

## Create a JWT from TokenBody

ConsentRequestTokenBody token = new ConsentRequestTokenBody(JWTTokenBody);

SmartAccess.ConsentRequests().FlowConsentRequestInitialize(token);
```

#### Creating a auth ticket

`SmartAccess.Consents().CreateAuthZTicketForConsent(ConsentID);`
