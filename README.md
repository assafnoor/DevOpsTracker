
# DevOpsTracker 🚀

**DevOpsTracker** is an open-source cloud-native platform to **monitor and track DevOps environments** using **.NET 9**, **Aspire**, **Docker**, and **Kubernetes**.

> ⚙️ Built to showcase deep backend skills and real-world DevOps practices.

---

## 🧩 Tech Stack

- [.NET 9](https://dotnet.microsoft.com/)
- [Aspire](https://learn.microsoft.com/en-us/dotnet/aspire/)
- Docker & Docker Compose
- Kubernetes
- YARP (Gateway)
- Serilog, Seq (for Logging)
- GitHub Actions (CI/CD)
- Prometheus + Grafana (Monitoring) *(Planned)*

---

## 📁 Project Structure (WIP)

```bash
devops-tracker/
├── src/                           # Core source code
│   ├── Services/                  # Each microservice lives in its own folder
│   │   ├── IdentityService/
│   │   │   ├── Identity.API/              # ASP.NET Core API layer
│   │   │   ├── Identity.Application/      # Application layer (CQRS, services, handlers)
│   │   │   ├── Identity.Domain/           # Domain models, aggregates, entities, value objects
│   │   │   ├── Identity.Infrastructure/   # Database, external integrations, repository impl
│   │   │   ├── Identity.Contracts/        # Shared contracts (DTOs/events) for communication
│   │   │   └── Identity.Tests/            # 🆕 Unit and Integration Tests
│   │   ├── TrackerService/
│   │   │   ├── Tracker.API/
│   │   │   ├── Tracker.Application/
│   │   │   ├── Tracker.Domain/
│   │   │   ├── Tracker.Infrastructure/
│   │   │   ├── Tracker.Contracts/
│   │   │   └── Tracker.Tests/
│   │   └── NotificationService/
│   │       ├── Notifications.API/
│   │       ├── Notifications.Application/
│   │       ├── Notifications.Domain/
│   │       ├── Notifications.Infrastructure/
│   │       ├── Notifications.Contracts/
│   │       └── Notifications.Tests/
│   ├── ApiGateways/
│   │   └── YarpGateway/                   # YARP-based gateway service
│   │       ├── YarpGateway.API/
│   │       └── YarpGateway.Tests/
│   ├── BuildingBlocks/                   # Reusable components across services
│   │   ├── EventBus/                     # RabbitMQ / Kafka abstractions, producers/consumers
│   │   ├── Observability/                # Logging, tracing (Serilog, OpenTelemetry, etc.)
│   │   ├── SharedKernel/                 # Common value objects, enums, constants
│   │   ├── Core/                         # DDD core interfaces (IRepository, IEntity...)
│   │   └── Secrets/                      # 🆕 Integration with Vault (HashiCorp/Azure)
├── infrastructure/
│   ├── docker/                           # Dockerfiles, Docker Compose, non-root configs
│   ├── helm/                             # Helm charts for Kubernetes deployment
│   ├── k8s/                              # K8s manifests (if not using Helm)
│   └── testcontainers/                   # 🆕 Testcontainers integration (for e2e testing)
├── tests/
│   ├── Unit/                             # Generic unit tests
│   ├── Integration/                      # Integration tests across services
│   ├── EndToEnd/                         # Full flow E2E tests
│   └── TestContainersSamples/           # 🆕 Examples using PostgreSQL, Mongo, RabbitMQ
├── .github/
│   └── workflows/                        # CI/CD GitHub Actions pipelines
│       ├── ci-identity.yml
│       ├── ci-tracker.yml
│       ├── ci-notifications.yml
│       └── deploy.yml
├── scripts/
│   ├── setup.ps1                         # 🆕 PowerShell script to bootstrap local dev
│   └── seed-dev-data.sh                  # 🆕 Seed development database with sample data
├── docs/
│   ├── ADRs/                             # 🆕 Architecture Decision Records (why RabbitMQ? why MongoDB?)
│   ├── diagrams/                         # 🆕 C4, sequence diagrams, system flowcharts
│   ├── README.md
│   └── CONTRIBUTING.md
├── .editorconfig
├── .gitignore
├── docker-compose.yml
├── DevOpsTracker.sln
└── README.md

````

---

## 🛠️ Getting Started (Soon)

> Full installation guide will be available soon.

For now:

```bash
git clone https://github.com/YOUR_USERNAME/DevOpsTracker.git
cd DevOpsTracker
# dotnet run
```

---

## 🗺️ Roadmap (partial)

* [x] Identity Service
* [ ] API Gateway with YARP
* [ ] Logging with Serilog + Seq
* [ ] Full Kubernetes Support
* [ ] CI/CD with GitHub Actions
* [ ] Observability (OpenTelemetry, Grafana, Prometheus)
* [ ] OAuth2 Integration
* [ ] Public Demo

---

## 📄 License

This project is licensed under the **MIT License** — see the [LICENSE](LICENSE.txt) file for details.

---

## 🤝 Contributions

> Contributions, ideas, and feedback are welcome!

Open an issue, suggest a feature, or fork and build!

---

## 🌍 Author

**Muhammad Nour Assaf**
🔗 [LinkedIn](https://www.linkedin.com/in/noor-assaf-0a743228a/)
📫 Contact: noorassaf331@gmail.com

