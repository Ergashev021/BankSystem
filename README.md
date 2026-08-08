# 🏦 Bank System

### Console-based banking application built with C# and .NET

[![C#](https://img.shields.io/badge/C%23-.NET-blue?logo=csharp)](https://dotnet.microsoft.com/)
[![.NET](https://img.shields.io/badge/.NET-10-purple?logo=dotnet)](https://dotnet.microsoft.com/)
[![License](https://img.shields.io/badge/License-MIT-green)](LICENSE)

---

## 📖 About

**Bank System** is a console-based banking application developed with **C# and .NET**.

The application models different types of bank accounts and provides core banking operations such as deposits, withdrawals, balance management, and credit handling.

The project is designed around an **object-oriented architecture**, allowing account-specific business rules to remain separated while sharing common banking functionality.

---

## ⚡ Features

- 🏦 Multiple account types
- 💰 Deposit and withdrawal operations
- 💳 Credit account management
- 📊 Balance tracking
- 🛡️ Transaction validation
- ⚠️ Credit limit validation
- 👤 Account owner management
- 🔄 Account-specific business logic
- 💻 Interactive console interface

---

## 🧱 Architecture

The application follows a simple inheritance-based domain model:


                         ┌──────────────────┐
                         │       Bank       │
                         │     Abstract     │
                         └────────┬─────────┘
                                  │
                    ┌─────────────┴─────────────┐
                    │                           │
          ┌─────────▼─────────┐       ┌─────────▼─────────┐
          │  SavingsAccount   │       │   CreditAccount   │
          └───────────────────┘       └───────────────────┘