# Desktop-ECommerce-MVC

This repository includes a desktop application, an MVC-based e-commerce website, and a fake bank API. It allows users to browse products locally, shop online, and simulate payment transactions.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)

## Introduction

This project consists of three main components:
1. **Desktop Application**: Allows users to browse products and manage orders locally.
2. **MVC E-commerce Website**: Provides an online shopping experience.
3. **Fake Bank API**: Simulates payment transactions for testing purposes.

## Features

- **Desktop Application**:
  - Product browsing
  - Order management

- **MVC E-commerce Website**:
  - User registration and login
  - Product catalog and search
  - Shopping cart and checkout

- **Fake Bank API**:
  - Query payment status (GET method)

## Installation

### Prerequisites

- [.NET Framework](https://dotnet.microsoft.com/download) (for Desktop Application and MVC E-commerce Website)

### Steps

1. **Clone the repository**:
    ```bash
    git clone https://github.com/yourusername/yourrepository.git
    cd yourrepository
    ```

2. **Build and run the Desktop Application**:
    - Open the project in Visual Studio and build the solution.
    - Run the application.

3. **Set up the MVC E-commerce Website**:
    - Open the project in Visual Studio and build the solution.
    - Configure the database connection string in `appsettings.json`.
    - Run the application.

4. **Run the Fake Bank API**:
    - Open the Fake Bank API project in Visual Studio and build the solution.
    - Run the application.

## Usage

### Desktop Application

1. Launch the application.
2. Browse products and manage orders.

### MVC E-commerce Website

1. Start the website server in Visual Studio.
2. Open your browser and navigate to the provided URL.
3. Register or log in to start shopping.

### Fake Bank API

The API runs at `https://localhost:44394`. It can be used to query payment transactions.
## API Documentation

The Fake Bank API exposes the following endpoint:

- `GET /api/payment/{id}`: Get payment status
