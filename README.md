# 🚀 DevOpsTracker

**DevOpsTracker** is a modular, open-source, cloud-native platform for monitoring and tracking DevOps environments — built with **.NET 9**, **Aspire**, **Docker**, and **Kubernetes**.

> Designed to demonstrate strong backend engineering and real-world DevOps practices — ready for extension, learning, or contribution.

---

## 🧰 Tech Stack

- [.NET 9](https://dotnet.microsoft.com/)
- [Aspire](https://learn.microsoft.com/en-us/dotnet/aspire/)
- **Docker** / **Docker Compose**
- **Kubernetes** + **Helm**
- [YARP](https://github.com/microsoft/reverse-proxy) (Gateway)
- **Serilog**, **Seq** for structured logging
- **GitHub Actions** for CI/CD
- *Planned*: **OpenTelemetry**, **Prometheus**, **Grafana**

---

## 🧱 Architecture Overview

Modular microservices architecture with separation by bounded context.  
Built following **Clean Architecture**, **DDD**, and **Cloud-Native** best practices.

---

## 📁 Project Structure (WIP)

```bash
devops-tracker/
│
├── src/                        # Core application code
│   ├── Services/               # Microservices: Identity, Tracker, Notifications
│   ├── ApiGateways/           # YARP Gateway
│   ├── BuildingBlocks/        # Shared libraries: EventBus, Observability, SharedKernel
│
├── infrastructure/            # Docker, Kubernetes, Helm, Testcontainers setup
├── tests/                     # Unit, Integration, E2E testing
├── .github/workflows/         # GitHub Actions pipelines
├── scripts/                   # Bootstrap and data seeding scripts
├── docs/                      # Diagrams, ADRs, contribution guides
├── DevOpsTracker.sln
└── README.md
````

---

## ⚙️ Getting Started

> Full setup instructions coming soon. For now, you can clone and experiment:

```bash
git clone https://github.com/assafnoor/DevOpsTracker.git
cd DevOpsTracker

# Run using Docker Compose (soon)
# docker-compose up -d

# Or launch services using Aspire
# dotnet run
```

---

## 🧭 Roadmap

* ✅ Identity Service
* ⏳ API Gateway with YARP
* ⏳ Logging with Serilog + Seq
* ⏳ Kubernetes deployment with Helm
* ⏳ GitHub Actions CI/CD for each service
* ⏳ Observability (OpenTelemetry + Grafana + Prometheus)
* ⏳ OAuth2 integration
* ⏳ Public demo and dashboard

---

## 🤝 Contributing

We welcome all kinds of contributions!
Whether you're fixing a bug, improving docs, or building a new feature — your input is valuable.

### 👉 How to Contribute

1. Fork the repository
2. Create a new branch: `git checkout -b feature/your-feature`
3. Commit your changes: `git commit -m "Add your message"`
4. Push to your fork: `git push origin feature/your-feature`
5. Open a **Pull Request**

Please check out the [CONTRIBUTING.md](docs/CONTRIBUTING.md) for more details.

---

## 🛡️ License

This project is licensed under the **MIT License**.
See the [LICENSE](LICENSE) file for more information.

---

## 🙋 About the Author

**Noor Assaf** — Software Engineer, Cloud Native Enthusiast
📍 Based in Russia 🇷🇺
🔗 [LinkedIn](https://www.linkedin.com/in/noor-assaf-0a743228a/)
📫 Contact: `noorassaf331@gmail.com`

---

## ⭐ Support the Project

If you found this project helpful, consider:

* Starring the repo ⭐
* Sharing it with your network 🔗
* Opening an issue or PR 💬

Together, let's build meaningful open-source tools 💙
