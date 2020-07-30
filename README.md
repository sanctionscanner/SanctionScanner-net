# General Informations

You can integrate Sanction Scanner APIs on web and mobile devices in a world-class structure. Our APIs are developed in a stateless and service-oriented architecture. On the following pages you will find details of service methods, input and output parameters and their descriptions.


## Beginning

You can quickly integrate and perform AML queries by sending data to the detective services in JSON format and responding to service responses in JSON format. With this guide, you will be able to easily perform integration steps in any language of software. You will soon be able to access sample projects through our github account very soon.


## API Base Endpoint Addresses


Service Name        	        | Service Type   	      | Address|
------------------	        |----------------       |-----	|
 Sanction Scanner's Services 	| REST| https://api.sanctionscanner.com/	


## Services

Service Name|Service Type| Root Address|Description|
-|-|-|-|
Search|REST|https://api.sanctionscanner.com/api/Search|This service is used to perform search on the system.|
Operations|REST|https://api.sanctionscanner.com/api/Operations	|This service allows some operations to be performed on search. For example, assigning users to a search or determining the risk level of the search.|
LocalList|REST|https://api.sanctionscanner.com/api/LocalList|This service is used for local blacklist management.|
GeneralWhiteList|REST|https://api.sanctionscanner.com/api/GeneralWhiteList|This service is used for general whitelist management.|
Retrieving|REST|https://api.sanctionscanner.com/api/Retrieving|This service is used to access details of past transactions.|
Reports|REST|https://api.sanctionscanner.com/api/Reports|This service allows you to view the statistics of previous searches.|


## API Security

Sanction Scanner APIs is use Simple Basic authentication for API security. Authentication information must be sent on the Get/Post header. You can find in below the necessary information to create the authentication key;

AuthenticationKey = ConvertToBase64(username+":"+password)

Authentication should be sent on the header as follows;

Authorization: Basic AuthenticationKey

*You can find your API keys in API User Info page after signed in.

## API Collection

If you wish, you can download the API collection by clicking [here](http://developer.sanctionscanner.com/Assets/API_Collection.json).

## Sanction Scanner

[Sanction Scanner](https://sanctionscanner.com/)
