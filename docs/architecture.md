# Architecture

## Overview
Registry service stores device identity and metadata:
- device id
- model/hardware info
- firmware version
- status flags

## Boundaries
- Exposes REST API to gateway/UI
- Abstracts persistence behind repository interfaces
- NoSQL is an implementation detail (later)

## Target structure
- API layer calls Core services
- Core defines interfaces and domain rules
- Infrastructure provides MongoDB (later)