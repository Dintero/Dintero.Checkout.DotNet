#!/bin/bash

docker run --rm -v "${PWD}:/local" openapitools/openapi-generator-cli generate \
    -i https://docs.dintero.com/specs/spec-checkout.yaml \
    -g csharp-netcore \
    -o /local/generated/checkout \
    -c /local/config.json \
    --additional-properties=targetFramework=netcoreapp3.1 \
    --package-name Dintero.OpenApiClient.Checkout  > generated/checkout.log


docker run --rm -v "${PWD}:/local" openapitools/openapi-generator-cli generate \
    -i https://docs.dintero.com/specs/spec-management-auth.yaml \
    -g csharp-netcore \
    -o /local/generated/auth \
    -c /local/config.json \
    --additional-properties=targetFramework=netcoreapp3.1 \
    --package-name Dintero.OpenApiClient.Auth > generated/auth.log

