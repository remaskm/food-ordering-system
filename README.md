# Food Ordering System (C# WinForms + SQL)

This repository contains a **C# WinForms application for a Food Ordering System** backed by a SQL database. It simulates a basic restaurant management system where customers can place orders, make payments, and leave feedback, while admins manage meals and track orders.

## Features

* **User Roles**: Separate access for Customers and Admins.
* **Meal Management**: Admins can add, update, or remove meals with categories, calories, and seasonal availability.
* **Order Processing**: Customers place orders with multiple meals; orders move through statuses: pending, processing, completed.
* **Payment Handling**: Supports cashless payments tied to customer balances.
* **Feedback System**: Customers rate meals (1–5 stars) and optionally leave comments.
* **Analytics Overview**: Admins can see stats on orders, customers, and meals.

## Prerequisites

* Windows OS
* Visual Studio (2019 or newer recommended)
* SQL Server (or compatible) for the database
* .NET Framework compatible with WinForms (typically .NET Framework 4.7+)

## Installation

1. **Clone the repository**:

   ```bash
   git clone https://github.com/your-username/food-ordering-system.git
   ```

2. **Open the solution** in Visual Studio.

3. **Set up the database**:
   * Run 'Database/schema.sql' to create the database schema.
   * Then run 'Database/sample_data.sql' to insert sample data for testing.

4. **Update the database connection string** in the app configuration file to match your setup.

5. **Build and run** the project.

## Usage

Launch the app and log in as either a Customer or Admin.

* **Customers** can browse meals, place orders, pay using their balance, and add feedback.
* **Admins** can manage meals, view all orders, and access analytics.

### Example workflow for a Customer:

1. Select meals and quantities.
2. Submit the order.
3. Make payment from balance.
4. Leave feedback with a star rating and comment.

## Business Logic Highlights

* Customers have balances and can only order if meals are available.
* Admins have full control over meal inventory and system data.
* Seasonal meals appear only during their defined season.
* Feedback requires a rating (1–5 stars) and can be edited or deleted.
* Orders cannot be completed without a valid payment record.

## Project Structure

* **Forms/** – UI components for login, ordering, admin controls, and feedback.
* **Database/** – SQL scripts to create schema and populate sample data:

   * `schema.sql`: Creates all required tables and relations.
   * `sample_data.sql`: Inserts sample meals, users, and orders for testing.
* **Models/** – Classes representing users, meals, orders, feedback.
* **Helpers/** – Utility functions and database connection handling.

## License

This project is for learning and personal use only.
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
