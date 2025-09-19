
```markdown
# 🚀 Kavez.PKCE.Api

**Secure PKCE API for OAuth 2.0 flows — built with ASP.NET Core and powered by Kavez.PKCE NuGet package**

---

## 🔐 What is this?

`Kavez.PKCE.Api` is a modular, educational Web API that demonstrates how to implement and test PKCE (Proof Key for Code Exchange) in OAuth 2.0 flows.  
It’s designed for developers, educators, and teams building secure authentication systems across mobile, desktop, CLI, and web platforms.

This API wraps the core functionality of the [`Kavez.PKCE`](https://www.nuget.org/packages/Kavez.PKCE) NuGet package and exposes it via HTTP endpoints.

---

## 📡 API Endpoints

### `GET /api/pkce?method=S256`

Generates a PKCE code verifier and challenge.

**Query Parameters:**
- `method`: `S256` (default) or `plain`

**Response:**
```json
{
  "verifier": "randomly-generated-string",
  "challenge": "base64url-encoded-SHA256",
  "method": "S256"
}
```

---

### `POST /api/pkce/verify`

Verifies that a given `code_verifier` matches the expected `code_challenge`.

**Request Body:**
```json
{
  "verifier": "original-verifier",
  "challenge": "received-challenge",
  "method": "S256"
}
```

**Response:**
```json
{
  "isValid": true
}
```

---

### `POST /api/token/mock`

Simulates token issuance for educational purposes.

**Request Body:**
```json
{
  "code": "auth-code",
  "redirectUri": "https://localhost:5001/callback",
  "clientId": "demo-client",
  "codeVerifier": "original-verifier"
}
```

**Response:**
```json
{
  "access_token": "generated-guid",
  "token_type": "Bearer",
  "expires_in": 3600
}
```

---

### `GET /api/pkce/sample`

Returns a full PKCE flow sample including authorization URL.

**Response:**
```json
{
  "verifier": "...",
  "challenge": "...",
  "redirect_uri": "https://localhost:5001/callback",
  "client_id": "demo-client",
  "authorization_url": "https://auth.example.com/authorize?...params..."
}
```

---

## 🧠 Why use this?

- ✅ Learn how PKCE works in practice
- ✅ Test your OAuth clients with real PKCE values
- ✅ Simulate token flows without needing a full auth server
- ✅ Use as a reference implementation for secure API design

---

## 🛠 How to Run

```bash
git clone https://github.com/mgolikhatir/Kavez.PKCE.Api.git
dotnet restore
dotnet run
```

Open Swagger UI at:  
`https://localhost:5001/swagger`

---

## 📦 Dependencies

- [.NET 8](https://dotnet.microsoft.com/)
- [`Kavez.PKCE`](https://www.nuget.org/packages/Kavez.PKCE)
- `Swashbuckle.AspNetCore` for Swagger UI

---

## 👤 Author & Contact

Developed by [Mohammad Golikhatir](https://www.linkedin.com/in/mgolikhatir/)  
Founder & CEO of [Kavez](https://github.com/mgolikhatir) — building modular, secure, and globally scalable tools for developers, educators, and innovators.

📬 For feedback, collaboration, or workshops:  
Connect via [LinkedIn](https://www.linkedin.com/in/mgolikhatir/) or explore more projects on [GitHub](https://github.com/mgolikhatir)

---

## 📣 License

MIT © Mohammad Golikhatir  
Feel free to use, fork, and contribute.
```
