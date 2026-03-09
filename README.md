<div align="center">

# 🏍️ TodorovNET

**Live timing & results platform for enduro motorcycle racing**

![Status](https://img.shields.io/badge/status-active-brightgreen)
![Platform](https://img.shields.io/badge/.NET-9-512BD4?logo=dotnet)
![Database](https://img.shields.io/badge/PostgreSQL-4169E1?logo=postgresql&logoColor=white)
![Frontend](https://img.shields.io/badge/Vanilla%20JS-F7DF1E?logo=javascript&logoColor=black)
![SignalR](https://img.shields.io/badge/SignalR-real--time-blue)
![JWT](https://img.shields.io/badge/Auth-JWT-orange)

</div>

---

## What is TodorovNET?

A real-time web platform for managing and broadcasting enduro race results. Timers enter results as riders cross the finish line — spectators see live standings instantly from any device, no app required.

---

## ✨ Features

### 🏆 Public Standings Page
Live leaderboard with automatic refresh, filtering by rider class, event schedule, and race statistics — accessible from any phone or browser without login.

### ⚙️ Admin Panel
Full race management: real-time result entry by race number, bulk participant import from Excel, class management, time penalties, and event scheduling.

### 👥 Role-Based Access
Three access levels to keep operations clean on race day:

| Role | Access |
|------|--------|
| ⭐ Super Admin | Full access to everything |
| 🗂️ Organizer | Manages their assigned event only |
| ⏱️ Timer | Result entry only |

### 📥 Excel / CSV Import
Bulk import participants with automatic class assignment — no manual entry needed for large fields.

---

## 🛠️ Built With

**Backend**
- ASP.NET Core 9
- Entity Framework Core
- PostgreSQL
- SignalR (real-time push)
- JWT authentication

**Frontend**
- Vanilla JavaScript
- HTML / CSS
- No frameworks — fast on mobile

---

## 🧪 Tested For

- 50+ simultaneous spectator connections
- Concurrent timer submissions without race conditions
- Bulk import of 375+ participants with class assignment
- Optimised API responses (~120 bytes per result submission)

---

<div align="center">

*Built for the Bulgarian enduro community 🇧🇬*

</div>
