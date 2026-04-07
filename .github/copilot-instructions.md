# Copilot instructions for CoworkingReservations

## Architecture
- Keep a clean layered architecture: API -> Application -> Domain and Infrastructure supports Application/Domain.
- Do not place domain rules in API or Infrastructure.
- Prefer explicit use cases in Application over fat controllers.

## Coding rules
- Use clear names in English for code symbols.
- Keep methods focused and small.
- Add tests for new business rules when test projects exist.

## Commit hygiene
- Never edit or commit generated outputs: `bin/`, `obj/`, `TestResults/`, `coverage/`.
- Avoid IDE metadata in commits (`.idea/`, `.vs/`).
- Keep app secrets out of source control; use environment variables or user secrets.

