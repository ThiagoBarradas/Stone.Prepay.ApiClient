[![Build status](https://ci.appveyor.com/api/projects/status/prh8a0nhwblycv8f?svg=true)](https://ci.appveyor.com/project/MundiPagg/stone-prepay-apiclient)

# Stone.Prepay.ApiClient
Client to Stone Prepayment Public API

# Using

```csharp

// Init client 
IPrepayApiClient client = new PrepayApiClient("http://prepaypublicapi.apphb.com/");

// Example with timely receivable advandce details
var receivableAdvanceResume = client.TimelyReceivableAdvance.Get("proposalId_here");

// Example with merchant configuration
var merchantConfig = client.MerchantConfiguration.Get("affiliationKey_here");

```

# API Documentation
http://prepaypublicapi.apphb.com/Help
