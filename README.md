# 🗄️ Base de Datos I — 2C 2026

[![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)](https://www.microsoft.com/sql-server)
[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)](https://learn.microsoft.com/dotnet/csharp/)
[![Visual Studio](https://img.shields.io/badge/Visual%20Studio-2022-5C2D91?style=for-the-badge&logo=visualstudio&logoColor=white)](https://visualstudio.microsoft.com/)
[![Windows](https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white)](#-requisitos)
[![Cursada](https://img.shields.io/badge/Cursada-2C%202026-blue?style=for-the-badge)](#)

**Material, ejercicios, trabajos prácticos y proyectos de la materia Base de Datos I: modelado relacional, consultas en SQL Server y aplicaciones de escritorio en C# conectadas a bases de datos.**

---

## 📋 Descripción

Este repositorio reúne **todo lo trabajado durante la cursada de Base de Datos I (2.º cuatrimestre 2026)**: teoría, guías de ejercicios, scripts SQL, trabajos prácticos y proyectos que integran **SQL Server** con aplicaciones de escritorio desarrolladas en **C#**.

Está pensado como:

- 📚 **Material de estudio**, con apuntes, guías y chuletas de SQL listos para consultar.
- 🧪 **Registro de práctica**, con ejercicios y evaluaciones resueltas en SQL.
- 🖥️ **Proyectos integradores**, que conectan una base de datos con interfaces gráficas de escritorio.

---

## ✨ Contenidos de la cursada

|                                        |                                                                                  |
| -------------------------------------- | -------------------------------------------------------------------------------- |
| 🛠️ **Instalación del entorno**          | Visual Studio Community 2022 y SQL Server paso a paso                            |
| 📐 **Teoría de bases de datos**         | Conceptos fundamentales, modelo relacional y diseño                              |
| 🔎 **Consultas SQL**                    | `SELECT`, filtros, agrupaciones, joins y subconsultas                            |
| 🏗️ **DDL y Constraints**                | Creación de tablas, claves primarias y foráneas, `CHECK`, `UNIQUE`, `DEFAULT`    |
| 🧪 **Ejercicios prácticos**             | Bases de ejemplo (Northwind y Jugadores) con guías de ejercicios                 |
| 🖥️ **C# de escritorio**                 | Controles, eventos y funciones con Windows Forms                                 |
| 🔗 **Integración BD + C#**              | Aplicaciones de escritorio conectadas a SQL Server                               |
| 📝 **Evaluaciones**                     | Examen parcial y evaluación práctica de SQL                                      |

---

## 📂 Estructura del repositorio

### 📁 Carpetas

| Carpeta                  | Contenido                                                   |
| ------------------------ | ----------------------------------------------------------- |
| `Clase SQL`              | 🔎 Material y ejercicios de las clases de SQL                |
| `Clase11`                | 🧪 Práctica correspondiente a la clase 11                    |
| `HolaMundo en C#`        | 👋 Primer programa en C#                                     |
| `masControles`           | 🎛️ Práctica con más controles de Windows Forms               |
| `Proyecto EscritorioGU`  | 🖥️ Proyecto de aplicación de escritorio con interfaz gráfica |
| `TP1-BD1-GRUPO6`         | 📝 Trabajo práctico 1 (Grupo 6)                              |
| `Proyecto Final`         | 🚀 Proyecto final de la materia                              |

### 📚 Material teórico y guías (PDF)

| Archivo                                                              | Descripción                                    |
| -------------------------------------------------------------------- | ---------------------------------------------- |
| `1a- Cómo instalar Visual Studio Community 2022-PES.pdf`             | Instalación de Visual Studio                   |
| `1b- InstalacionSQLSERVER_pes.pdf`                                   | Instalación de SQL Server                      |
| `2a- base_datos_PES_teoria.pdf`                                      | Teoría de bases de datos                       |
| `2b- BASES-DE-DATOS.pdf`                                             | Apunte complementario de bases de datos        |
| `Curso de SQL_PES_SQL_SERVER.pdf`                                    | Curso de SQL con SQL Server                    |
| `elementosSQL_PES.pdf`                                               | Elementos del lenguaje SQL                     |
| `CHULETA SQL.pdf`                                                    | 📌 Chuleta de consulta rápida                  |
| `Constraints_SQL_Server.pdf`                                         | Restricciones en SQL Server                    |
| `Guia_Practica_SQL_Server_DDL_Constraints.pdf`                       | Guía práctica de DDL y constraints             |
| `GUÍA DE EJERCICIOS Jugadores DE CONSULTAS EN SQL SERVER.pdf`        | Guía de ejercicios de consultas                |
| `codigoCSHARP.pdf`                                                   | Código de referencia en C#                     |

### 🧾 Scripts SQL y datos

| Archivo                       | Descripción                                          |
| ----------------------------- | ---------------------------------------------------- |
| `EjerciciosNorthing.sql`      | Ejercicios sobre la base de datos Northwind          |
| `JugadoresSQL.sql`            | Base de datos y consultas de la práctica Jugadores   |
| `players_description.csv`     | Datos de los jugadores utilizados en los ejercicios  |
| `SQLQueryEjercicio.sql`       | Ejercicios de consultas SQL                          |
| `EvaluaciónPracticaSQL.sql`   | Evaluación práctica de SQL                           |
| `SQLTikinidas.sql`            | Scripts SQL propios                                  |

### 📝 Trabajos y evaluaciones

| Archivo                                                      | Descripción                                             |
| ------------------------------------------------------------ | ------------------------------------------------------- |
| `Elias Tiquicala -Tp1 Controles y funciones C# escritorio.pdf` | Informe del TP1: controles y funciones en C# escritorio |
| `Tp1ControlesYFunciones con IA (1).zip`                      | Proyecto del TP1 de controles y funciones               |
| `TP1-BD1-GRUPO6.rar`                                         | Trabajo práctico grupal (comprimido)                    |
| `Proyecto Final.zip`                                         | Proyecto final (comprimido)                             |
| `Examen Parcial de Bases de Datos 1.pdf`                     | Examen parcial                                          |

```
Base-de-datos-I-2C-2026/
├── Clase SQL/
├── Clase11/
├── HolaMundo en C#/
├── masControles/
├── Proyecto EscritorioGU/
├── Proyecto Final/
├── TP1-BD1-GRUPO6/
├── *.pdf                    # Teoría, guías, chuletas y evaluaciones
├── *.sql                    # Scripts y ejercicios de SQL Server
├── players_description.csv  # Datos de práctica
├── *.zip / *.rar            # Trabajos y proyectos comprimidos
├── .gitattributes
└── README.md
```

---

## 🚀 Requisitos

- **Sistema operativo:** Windows 10 u 11.
- **Base de datos:** SQL Server (Express, Developer o superior) junto con **SQL Server Management Studio (SSMS)**.
- **IDE:** Visual Studio Community 2022 con la carga de trabajo **"Desarrollo de escritorio con .NET"**.
- **Git** para clonar el repositorio.

> 💡 Las guías `1a` y `1b` incluidas en el repositorio explican paso a paso cómo instalar Visual Studio y SQL Server.

---

## 📥 Cómo usarlo

### 1. Clonar el repositorio

```
git clone https://github.com/EliasTiki951/Base-de-datos-I-2C-2026.git
cd Base-de-datos-I-2C-2026
```

### 2. Ejecutar los scripts SQL

1. Abrí **SQL Server Management Studio** y conectate a tu instancia.
2. Abrí el archivo `.sql` que quieras probar (por ejemplo `JugadoresSQL.sql`).
3. Ejecutalo con **F5**.

### 3. Abrir los proyectos en C#

1. Descomprimí el `.zip` o `.rar` si el proyecto está comprimido.
2. Abrí el archivo `.sln` con **Visual Studio 2022**.
3. Revisá la **cadena de conexión** y ajustala a tu instancia de SQL Server.
4. Ejecutá con **F5**.

---

## 🎯 Objetivos de aprendizaje

- Comprender los fundamentos del **modelo relacional**.
- Escribir **consultas SQL** de complejidad creciente.
- Diseñar tablas aplicando **claves y restricciones** (`PRIMARY KEY`, `FOREIGN KEY`, `CHECK`, `UNIQUE`, `DEFAULT`).
- Desarrollar **aplicaciones de escritorio en C#** con Windows Forms.
- **Conectar aplicaciones con SQL Server** y persistir datos.
- Integrar todo en un **proyecto final**.

---

## ⚠️ Aviso

Este repositorio tiene **fines exclusivamente educativos**. Contiene material de cátedra y trabajos desarrollados durante la cursada. Si lo usás como referencia, intentá resolver primero los ejercicios por tu cuenta. 😉

---

## 🤝 Contribuciones

Este es un repositorio académico personal, pero las sugerencias son bienvenidas:

1. Hacé un **Fork** del repositorio.
2. Creá una rama (`git checkout -b feature/mejora`).
3. Hacé commit de tus cambios (`git commit -m 'Agrega mejora'`).
4. Hacé push a la rama (`git push origin feature/mejora`).
5. Abrí un **Pull Request**.

---

## 👨‍💻 Autor

**Elias Tiquicala** (EliasTiki951)

[![GitHub](https://img.shields.io/badge/GitHub-100000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/EliasTiki951)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/elias-tiquicala-7672701b6/)

---

## 📞 Soporte

Si encontrás algún problema o tenés sugerencias:

- Abrí un [Issue](https://github.com/EliasTiki951/Base-de-datos-I-2C-2026/issues)
- Contactame directamente

---

**¡No olvides dejar una ⭐ si te fue útil!**
