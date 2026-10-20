# Inception SDK

- Target .NET 10; package `tryAGI.Inception`, namespace `Inception`, client `InceptionClient`.
- Keep all eight operations from the official Inception OpenAPI document public.
- Regenerate with `bash src/libs/Inception/generate.sh`. Never hand-edit `Generated/`.
- The local AutoSDK CLI is pinned in `.config/dotnet-tools.json`.
- `openapi.upstream.json` preserves the raw upstream contract; `scripts/prepare-spec.py`
  promotes inline decision unions to named references without changing the wire format.
  Stop and review if its checked assumptions change.
- Handwritten adapters belong outside `Generated/`. Native streaming exposes diffusion
  replacement frames; the MEAI adapter rejects diffusion mode because its updates append.
- `dotnet test Inception.slnx --filter 'TestCategory!=Live'` runs deterministic protocol checks.
- Live tests in `src/tests/IntegrationTests/Examples/` plus `Tests.Meai.cs` require
  `INCEPTION_API_KEY` (or the shared CI `API_KEY` fallback). Missing/empty keys skip tests.
  Live calls consume provider credits. Never put credentials in tracked files.
- Validate release builds and run `dotnet tool run autosdk -- trim src/libs/Inception/Inception.csproj`.
- Commit scoped paths directly to main and watch triggered CI to completion.
