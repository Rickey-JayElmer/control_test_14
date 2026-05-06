# Control Test 14

A single C# ASP.NET Core 9 API exposing five resource families whose
fields mirror the `generator-golden-v1` data-classification dataset
(AI, device, geolocation, network, financial). Field names on the wire
use the dataset's exact `snake_case` form.

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

| Controller            | Entity                    | Route stem            |
|-----------------------|---------------------------|-----------------------|
| `AiController`        | `AiInferenceRecord`       | `ai-record(s)`        |
| `DeviceController`    | `DeviceTelemetryRecord`   | `device-record(s)`    |
| `GeolocationController` | `GeolocationRecord`     | `geolocation-record(s)` |
| `NetworkController`   | `NetworkRequestRecord`    | `network-request(s)`  |
| `FinancialController` | `FinancialPaymentRecord`  | `financial-payment(s)`|

### Field sets (snake_case on the wire)

**AI** — `model_id`, `model_version`, `ai_risk_category`,
`eval_metric_score` (number), `inference_output`, `training_example`,
`training_corpus_ref`, `user_prompt`.

**Device** — `device_profile`, `advertising_id`, `device_serial_number`,
`user_agent`, `device_fingerprint_hash`, `session_cookie_id`,
`utm_campaign_id`.

**Geolocation** — `location_data`, `gps_reading`, `home_location_area`,
`checkin_place`, `latitude` (number), `location_history_trail`,
`geofence_entry_event`, `region_code`.

**Network** — `network_request_info`, `client_ip`, `server_ip`,
`mac_address`, `fqdn_host`, `tcp_port` (number), `nic_id`, `origin_asn`,
`request_headers`, `response_headers`.

**Financial** — `bank_account_number`, `sort_code`, `iban`, `swift_bic`,
`card_pan`, `card_expiry`, `card_cvv`, `cardholder_name`, `card_token`.

## API endpoints

For every resource (`<e>` = route stem above):

| Method | Route                          | Response                            |
|--------|--------------------------------|-------------------------------------|
| GET    | `/api/v1/<e>s`                 | 200 — list                          |
| GET    | `/api/v1/<e>/{id:guid}`        | 200 / 404                           |
| POST   | `/api/v1/<e>s`                 | 201 + `X-<Entity>-Id` header        |
| PUT    | `/api/v1/<e>/{id:guid}`        | 200 / 404                           |
| DELETE | `/api/v1/<e>/{id:guid}`        | 204 / 404                           |

Total: 25 endpoints across 5 controllers.

## Tech stack

| Layer           | Choice                              |
|-----------------|-------------------------------------|
| Runtime         | .NET 9 (SDK pinned via `global.json`) |
| Web framework   | ASP.NET Core controllers            |
| Mediator        | MediatR 14.1.0                      |
| API docs        | Swashbuckle.AspNetCore 10.1.7       |
| JSON naming     | `JsonNamingPolicy.SnakeCaseLower` (System.Text.Json) |
| Persistence     | In-memory `ConcurrentDictionary` (singleton repositories) |

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
    "sort_code": "20-00-00",
    "iban": "GB29NWBK60161331926819",
    "swift_bic": "NWBKGB2L",
    "card_pan": "4111111111111111",
    "card_expiry": "12/30",
    "card_cvv": "123",
    "cardholder_name": "Jane Doe",
    "card_token": "tok_test_abc123"
  }'
```

Response: `201 Created`, `X-FinancialPaymentRecord-Id: <guid>`,
`Location: /api/v1/financial-payment/<guid>`.

```bash
curl -s http://localhost:5014/api/v1/financial-payments | jq
```

Returns an array of records with snake_case keys exactly matching the
request shape.
