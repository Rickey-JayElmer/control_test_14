# Control Test 14

A single C# ASP.NET Core 9 API exposing **10 resource families** whose
fields mirror **every `fieldName` in the `generator-golden-v1` dataset**
(305 distinct fields, with `auth_code` reused across two categories).
Each field uses its **exact wire name from the dataset** —
mixed `snake_case` and `camelCase` are preserved via per-property
`[JsonPropertyName]` attributes.

No authentication or authorization. Storage is in-memory
(`ConcurrentDictionary`) — no database required.

## Architecture

```
control_test_14/
├── Control14_Test_Api.sln
├── global.json
└── src/
    ├── Control14.Domain/          # Entities (private ctor + Create/Update)
    ├── Control14.Application/     # CQRS handlers (MediatR), DTOs, interfaces
    ├── Control14.Infrastructure/  # In-memory repositories
    └── Control14.Api/             # Controllers, Program.cs, settings
```

## Resources

| Controller              | Entity                     | Route stem            | Fields |
|-------------------------|----------------------------|-----------------------|-------:|
| `AiController`          | `AiInferenceRecord`        | `ai-record(s)`        |  8 |
| `DeviceController`      | `DeviceTelemetryRecord`    | `device-record(s)`    |  9 |
| `FinancialController`   | `FinancialPaymentRecord`   | `financial-payment(s)`| 47 |
| `GeolocationController` | `GeolocationRecord`        | `geolocation-record(s)`|  9 |
| `HrController`          | `HrRecord`                 | `hr-record(s)`        | 13 |
| `LegalController`       | `LegalRecord`              | `legal-record(s)`     | 11 |
| `NetworkController`     | `NetworkRequestRecord`     | `network-request(s)`  | 13 |
| `OrganizationController`| `OrganizationRecord`       | `organization-record(s)`| 27 |
| `PersonalController`    | `PersonalRecord`           | `personal-record(s)`  | 125 |
| `SecurityController`    | `SecurityRecord`           | `security-record(s)`  | 44 |

Total: **306 properties** across 10 entities (305 distinct fieldNames; `auth_code` exists in both `Financial` and `Security`).

Categorisation rule: every case is placed under the prefix of its primary
`expectedClassifications[0].tagsUsed[0]` tag. "No-tag" synonym cases
(e.g. `creditCardNumber` ≡ `card_pan`) are placed under the same
controller as the canonical concept they map to.

## API endpoints

For every resource (`<e>` = route stem above):

| Method | Route                          | Response                            |
|--------|--------------------------------|-------------------------------------|
| GET    | `/api/v1/<e>s`                 | 200 — list                          |
| GET    | `/api/v1/<e>/{id:guid}`        | 200 / 404                           |
| POST   | `/api/v1/<e>s`                 | 201 + `X-<Entity>-Id` header        |
| PUT    | `/api/v1/<e>/{id:guid}`        | 200 / 404                           |
| DELETE | `/api/v1/<e>/{id:guid}`        | 204 / 404                           |

Total: **50 endpoints** across 10 controllers.

## Wire format

`Program.cs` configures `JsonNamingPolicy.CamelCase` as the default
(applies only to `Id`), and every field carries an explicit
`[property: JsonPropertyName("<exact-fieldName>")]` attribute. This
preserves the dataset's mixed naming convention verbatim:

- snake_case fields stay snake_case: `bank_account_number`, `card_pan`,
  `tax_amount`, `model_id`, `client_ip`, …
- camelCase fields stay camelCase: `creditCardNumber`, `expMonth`,
  `paymentMethodToken`, `txnId`, `nameOnCard`, `birthDate`, `idfa`, …

## Tech stack

| Layer           | Choice                                              |
|-----------------|-----------------------------------------------------|
| Runtime         | .NET 9 (SDK pinned via `global.json`)               |
| Web framework   | ASP.NET Core controllers                            |
| Mediator        | MediatR 14.1.0                                      |
| API docs        | Swashbuckle.AspNetCore 10.1.7                       |
| JSON naming     | `JsonNamingPolicy.CamelCase` default + per-property `[JsonPropertyName]` |
| Persistence     | In-memory `ConcurrentDictionary` (singleton repos)  |

## Field types

- `Id` is always `Guid`.
- `tcp_port` is `int`.
- Amounts / scores / rates / counts / `latitude` / `eval_metric_score` /
  `cumulative_gpa` / `age` / `tuition_fee` / `scholarship_award` and
  similar are `double`.
- All other fields are `string` (including timestamps/dates and JSON
  blob fields like `customer_profile_json`, `payment_receipt_json`,
  `saml_response_xml`, etc. — they ride as opaque strings).

## Running

```bash
cd control_test_14
dotnet run --project src/Control14.Api
```

API: `http://localhost:5014` — Swagger UI at `/swagger`.

## Example

```bash
curl -i -X POST http://localhost:5014/api/v1/financial-payments \
  -H 'Content-Type: application/json' \
  -d '{
    "bank_account_number": "12345678",
    "iban": "GB29NWBK60161331926819",
    "card_pan": "4111111111111111",
    "creditCardNumber": "5555555555554444",
    "expMonth": "12",
    "paymentMethodToken": "tok_test_abc123",
    "tax_amount": 19.99,
    "iso_currency": "GBP"
  }'
```

(Other fields default to empty strings / 0.) Response: `201 Created`,
`X-FinancialPaymentRecord-Id: <guid>`,
`Location: /api/v1/financial-payment/<guid>`.

```bash
curl -s http://localhost:5014/api/v1/financial-payments | jq
```

Returns an array of records with all 47 financial fields in their
original dataset wire format.
