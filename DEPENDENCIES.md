# Dependency accounting

## Consumer runtime (.NET 10)

- `Microsoft.Extensions.AI.Abstractions` 10.11.0: official Microsoft unified chat
  interfaces and content/tool abstractions. The restored net10.0 graph contains
  no additional transitive NuGet packages.
- JSON, HTTP, SSE, and the generated transport use the .NET 10 platform.
- There is no OpenAI SDK dependency and no packaged native runtime binary.

## Generation and build tooling

- `autosdk.cli` 0.35.0-preview.2.75: first-party tryAGI generator, pinned in
  `.config/dotnet-tools.json`; its dependencies execute during development only.
- `MinVer` 7.0.0: Git-tag versioning; private build dependency.
- `DotNet.ReproducibleBuilds` 2.0.2: deterministic build/Source Link configuration;
  private build dependency.

## Test tooling

- Microsoft.NET.Test.Sdk 18.11.0 and MSTest adapter/framework 4.5.1: Microsoft tests.
- AwesomeAssertions 9.6.0: existing workspace assertion tooling.
- GitHubActionsTestLogger 3.0.5: existing workspace CI test-output tooling.

The build/test tooling graph is separate from the consumer runtime graph.
No claim of a complete build-tool supply-chain audit is made here.

## Verification

```sh
dotnet restore Inception.slnx --force-evaluate
dotnet list src/libs/Inception/Inception.csproj package --include-transitive
dotnet pack src/libs/Inception/Inception.csproj -c Release
```

Inspect the resulting package's nuspec dependency group and `lib/net10.0` assets.
The upstream API document is preserved with its provider metadata and terms;
`prepare-spec.py` only promotes two equivalent Decisions union definitions to
named references before code generation.
