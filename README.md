
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
├── src/                           # الكود الأساسي
│   ├── Services/                 # كل Microservice بوحدة مستقلة
│   │   ├── IdentityService/
│   │   │   ├── Identity.API/
│   │   │   ├── Identity.Application/
│   │   │   ├── Identity.Domain/
│   │   │   ├── Identity.Infrastructure/
│   │   │   ├── Identity.Contracts/
│   │   │   └── Identity.Tests/                # 🆕 Unit/Integration Tests
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
│   │   └── YarpGateway/
│   │       ├── YarpGateway.API/
│   │       └── YarpGateway.Tests/
│   ├── BuildingBlocks/           # أجزاء مشتركة بين الخدمات
│   │   ├── EventBus/             # RabbitMQ / Kafka abstractions + consumers/producers
│   │   ├── Observability/        # Serilog, OpenTelemetry, Jaeger Exporter
│   │   ├── SharedKernel/         # ValueObjects, Enums, Constants
│   │   ├── Core/                 # مكونات DDD مشتركة
│   │   └── Secrets/              # 🆕 Integration with HashiCorp Vault or Azure Key Vault
├── infrastructure/
│   ├── docker/                   # Dockerfiles (multi-stage, non-root) + compose.yml
│   ├── helm/                     # Helm charts لكل خدمة
│   ├── k8s/                      # K8s manifests (optional)
│   └── testcontainers/           # 🆕 دعم اختبار الخدمات باستخدام Testcontainers
├── tests/
│   ├── Unit/
│   ├── Integration/
│   ├── EndToEnd/
│   └── TestContainersSamples/   # 🆕 Integration with PostgreSQL, Mongo, Rabbit
├── .github/
│   └── workflows/                # CI/CD لكل خدمة + lint/test/build/deploy
│       ├── ci-identity.yml
│       ├── ci-tracker.yml
│       ├── ci-notifications.yml
│       └── deploy.yml
├── scripts/
│   ├── setup.ps1                # 🆕 سكربت أوتوماتيكي لإنشاء البيئة محليًا
│   └── seed-dev-data.sh         # 🆕 لإضافة بيانات مبدئية
├── docs/
│   ├── ADRs/                    # 🆕 Architecture Decision Records (لماذا Rabbit؟ لماذا Mongo؟...)
│   ├── diagrams/                # 🆕 C4 / Sequence / Flowcharts
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
# run docker-compose or Aspire commands
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

This project is licensed under the **MIT License** — see the [LICENSE](LICENSE) file for details.

---

## 🤝 Contributions

> Contributions, ideas, and feedback are welcome!

Open an issue, suggest a feature, or fork and build!

---

## 🌍 Author

**Muhammad Nour Assaf**
🔗 [LinkedIn](https://www.linkedin.com/in/noor-assaf-0a743228a/)
📫 Contact: noorassaf331@gmail.com

