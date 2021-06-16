# Dintero.OpenApiClient.Auth.Model.InlineResponse2002

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PublicUrl** | **string** | The public URL the asset will be made available from after the upload has completed.  | [optional] 
**UploadUrl** | **string** | An URL to upload the asset to.  - The content type header value must be the same as the &#x60;mime_type&#x60; - The content length header value must be the same as the size of   the file and the &#x60;size_bytes&#x60;.  **Upload example** &#x60;&#x60;&#x60; curl -X PUT   -H &#39;Content-Type: {mime_type}&#39; \\   -H &#39;Content-Length: {size_bytes}&#39; \\   - -upload-file &lt;file&gt; \\   {upload_url} &#x60;&#x60;&#x60;  | [optional] 
**UploadExpiresIn** | **int** | The number of seconds until the upload url is no longer valid  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

