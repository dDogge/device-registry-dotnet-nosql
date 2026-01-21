# Architecture

## Overview
This service provides read models / aggregates for dashboards and analytics.

## Responsibilities
- Receive events (later: from gateway/queue)
- Store raw events (optional)
- Compute aggregates (time windows, device summaries)
- Expose query endpoints for the UI

## Internal structure (suggested)
- `app/api` – routes + dependencies
- `app/services` – aggregation logic
- `app/repositories` – storage abstraction (SQLite first)
- `app/core` – config + logging