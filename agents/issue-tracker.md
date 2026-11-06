# Issue tracker: GitHub

Issues and specs live in ringcentral/RingCentral.Net.
Use the gh CLI for issue operations.

## Conventions

- Read tickets with their full bodies and comments.
- Publish specs and tickets as GitHub issues.
- Write multiline bodies to a file and pass --body-file.
- Use native GitHub sub-issue relationships for parents.
- Use native GitHub blocked-by relationships for dependencies.
- Relationship API calls require numeric issue database IDs,
  not issue numbers or node IDs.
- A blocker is satisfied when its issue is closed.
- If native relationships are unavailable, retain explicit
  parent and blocker references in the issue body.

## Pull requests as a triage surface

PRs as a request surface: no.
