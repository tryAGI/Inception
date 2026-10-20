#!/usr/bin/env bash
set -euo pipefail
cd "$(dirname "$0")"
dotnet tool restore
spec_file=$(mktemp)
trap 'rm -f "$spec_file"' EXIT
curl --fail --silent --show-error --location --retry 5 --retry-delay 5 \
  --connect-timeout 30 --max-time 300 \
  https://api.inceptionlabs.ai/openapi.json -o "$spec_file"
mv "$spec_file" openapi.upstream.json
python3 ../../../scripts/prepare-spec.py openapi.upstream.json openapi.yaml
rm -rf -- Generated
dotnet tool run autosdk -- generate openapi.yaml \
  --namespace Inception \
  --clientClassName InceptionClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer
