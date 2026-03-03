# 🔗 API-to-API Communication using ASP.NET Core

## 📌 Overview

This project demonstrates a microservice-style architecture where one ASP.NET Core Web API consumes another Web API as its data source instead of connecting directly to a database.

The system includes:

- API 1 – Data Provider API
- API 2 – Consumer API (uses API 1 via HttpClient)
- Network-based access configuration
- IP-restricted access control
- Clean dependency injection using IHttpClientFactory

This project simulates real-world backend service communication used in distributed systems.

---

## 🏗 Architecture

Client  
   ↓  
API 2 (Gateway / Consumer API)  
   ↓  
API 1 (Data API)  
   ↓  
Data Source  

API 2 fetches data from API 1, applies business logic, and returns the processed response.

---

## 🚀 Technologies Used

- .NET 8 / .NET 9
- ASP.NET Core Web API
- IHttpClientFactory
- Dependency Injection
- RESTful APIs
- Network Binding (0.0.0.0 vs localhost)
- IP-based Access Control
- Swagger / Scalar API UI

---

## 🔥 Key Features

- API-to-API communication
- Clean layered architecture
- HttpClient service abstraction
- Configurable BaseAddress
- Secure access using:
  - IP-based firewall restriction
  - Optional API key validation
- Network testing across multiple machines

---

## 📂 Project Structure

### API 1 (Data API)


Controllers/
Models/
Program.cs


Provides product data via REST endpoints.

---

### API 2 (Consumer API)


Controllers/
Services/
Models/
Program.cs


Uses HttpClient to consume API 1.

---

## ⚙️ Configuration

### Server Binding

To allow network access:

```json
"applicationUrl": "http://0.0.0.0:5099"

To restrict local-only access:

"applicationUrl": "http://localhost:5099"
🔐 Access Control Options
Option 1: IP Restriction (Firewall)

Allow only specific client IP to access API port.

Option 2: API Key Authentication

Add custom header validation:

X-API-KEY: your-secret-key
🧠 Learning Outcomes

Understanding difference between:

localhost

0.0.0.0

private IP addresses

Service-to-service communication

HttpClient best practices

Debugging cross-machine API connectivity

Handling network-based deployment issues

🧪 Testing

Run both APIs and ensure:

Both machines are on same network

Correct port is used

Firewall allows access

API 1 is running before API 2

🎯 Future Improvements

JWT authentication between services

Docker containerization

Reverse proxy (NGINX)

API Gateway integration

Deployment to Azure / AWS

Retry policies using Polly

Logging and distributed tracing

📌 Author

Built as a backend architecture practice project to understand distributed API communication and secure service exposure in ASP.NET Core.


---

# 💪 Why This Is Strong For Your Profile

This project shows:

- Real backend understanding
- Networking knowledge
- Microservice thinking
- HttpClientFactory usage
- Security awareness

This is way stronger than a basic CRUD API.

---

If you want, I can also give:
- Resume bullet points version
- LinkedIn project description
- Interview explanation answer for this project  
- System design explanation for this architecture 🚀
