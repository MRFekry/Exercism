# Exercism Solutions

[![Exercism Profile](https://img.shields.io/badge/Exercism-Profile-blueviolet?style=flat-square&logo=exercism)](https://exercism.org/profiles/YOUR_EXERCISM_USERNAME)
[![Sync Status](https://img.shields.io/badge/Syncing-Automated-success?style=flat-square&logo=githubactions)](https://exercism.org/settings/applications)

A centralized repository containing my code solutions for various track challenges on [Exercism](https://exercism.org). 

This repository is automatically updated via the **Exercism GitHub Integration**, which natively pushes completed exercise iterations directly into this codebase.

---

## 🤖 How the Syncer Tool Works

This repo requires zero manual command-line pushing. The execution workflow follows this automated pipeline:

1. **Solve:** An exercise is completed and submitted either via the Exercism CLI or online editor.
2. **Sync:** Once the solution passes all automated test suites and is marked as complete, the `exercism-solutions-syncer[bot]` triggers an update.
3. **Commit:** The bot pushes a clean, structured commit or PR labeled `[Sync Iteration] <track>/<exercise>` directly into this repository.

---

## 📂 Repository Structure

The syncer tool structures code folders neatly by language track and problem names:

```text
├── .gitignore
├── README.md
├── csharp/
│   ├── lucas-lasagna/
│   └── remote-control-cars/
└── typescript/
    └── resistor-color/
