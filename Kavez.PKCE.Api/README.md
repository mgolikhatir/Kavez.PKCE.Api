
```markdown
# 🚀 Kavez.PKCE.Api

**Secure PKCE API for OAuth 2.0 flows — powered by ASP.NET Core and Kavez.PKCE NuGet package**

---

## 🔐 What is this?

`Kavez.PKCE.Api` is a lightweight RESTful API built with ASP.NET Core that generates PKCE code verifiers and challenges. It’s designed to support OAuth 2.0 authorization flows across mobile, desktop, CLI, and web platforms.

This API wraps the core functionality of the [`Kavez.PKCE`](https://www.nuget.org/packages/Kavez.PKCE) NuGet package and exposes it via HTTP endpoints.

---

## 🚀 How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/mgolikhatir/Kavez.PKCE.Api.git
   ```

2. Restore dependencies:
   ```bash
   dotnet restore
   ```

3. Run the project:
   ```bash
   dotnet run
   ```

4. Open Swagger UI:
   ```
   https://localhost:5001/swagger
   ```

---

## 📡 API Endpoint

### `GET /api/pkce?method=S256`

Returns a PKCE code verifier and challenge.

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

## 📦 Dependencies

- [.NET 8](https://dotnet.microsoft.com/)
- [`Kavez.PKCE`](https://www.nuget.org/packages/Kavez.PKCE)

---

## 🧠 About Kavez

This project is part of the [Kavez](https://github.com/mgolikhatir) initiative to build modular, secure, and globally accessible tools for developers. It’s designed with clarity, reproducibility, and scalability in mind.

---

## 👤 Author & Contact

Developed by [Mohammad Golikhatir](https://www.linkedin.com/in/mgolikhatir/)  
Founder & CEO of [Kavez](https://github.com/mgolikhatir) — building modular, secure, and globally scalable tools for developers, educators, and innovators.

📬 For collaboration, feedback, or technical inquiries:  
Feel free to connect via [LinkedIn](https://www.linkedin.com/in/mgolikhatir/) or explore more projects on [GitHub](https://github.com/mgolikhatir).

---

## 📣 License

MIT © Mohammad Golikhatir  
Feel free to use, fork, and contribute.
```
