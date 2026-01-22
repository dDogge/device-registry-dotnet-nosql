# Contributing

Thanks for contributing to **device-registry-dotnet-nosql**!

This repository contains a .NET Web API for device registry/metadata. The goals are clean separation (API/Core/Infrastructure), predictable API contracts, and tests from day 1.

## Changelog and decisions (required)
- **Update `CHANGELOG.md` on every push** (at minimum the `Unreleased` section).
- For major decisions (NoSQL choice, id strategy, API contract changes, architecture patterns), **add/update an ADR** in `docs/decisions/`.

## Prerequisites
- .NET SDK 8.x recommended

## Setup
```bash
dotnet restore
```

## Build
```bash
dotnet build
```

## Run locally
```bash
dotnet run --project src/DeviceRegistry.Api
```

## Testing
```bash
dotnet test
```

## Project conventions

### Solution layout (recommended)
- `src/DeviceRegistry.Api` — HTTP layer, DI, controllers/minimal API
- `src/DeviceRegistry.Core` — domain + interfaces
- `src/DeviceRegistry.Infrastructure` — persistence + external integrations
- `tests/` — xUnit tests

### API design guidelines
- Prefer explicit request/response DTOs.
- Keep contracts stable; document changes in README.
- Use idempotency for registration/update endpoints where it makes sense.

### Persistence approach
- Start with in-memory repository to iterate quickly.
- Add NoSQL (e.g., MongoDB) behind interfaces later.

## Documentation
- Update `README.md` when endpoints/env values change.
- Update `docs/architecture.md` for boundary/flow changes.
- Add ADRs under `docs/decisions/` for major choices.

## Commit message guidelines
Use clear, imperative messages:
- "Add device registration endpoint"
- "Add in-memory repository implementation"
- "Add tests for devices API"

## Pull requests
- Include summary + test steps.
- Add/update tests for behavior changes.
- Keep changes focused and reviewable.
