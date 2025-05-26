# Food Ordering System

This repository contains a **C# WinForms application for a Food Ordering System** backed by a SQL database. It simulates a basic restaurant management system where customers can place orders, make payments, and leave feedback, while admins manage meals and track orders.

## Features

* **User Roles**: Separate access for Customers and Admins.
* **Meal Management**: Admins can add, update, or remove meals with categories, calories, and seasonal availability.
* **Order Processing**: Customers place orders with multiple meals; orders move through statuses: *pending* and *completed*.
* **Payment Handling**: Customers can pay using **cash, credit, or loyalty points**, which are earned from previous orders.
* **Feedback System**: Customers rate meals (1–5 stars) and optionally leave comments.
* **Analytics Overview**: Admins can view basic analytics on orders, meals, and customer activity.

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

   * Run [Database/schema.sql](Database/schema.sql) to create the database schema.
   * Then run [Database/sample_data.sql](Database/sample_data.sql) to insert sample data for testing.

4. **Update the database connection string** in the app configuration file to match your setup.

5. **Build and run** the project.

## Usage

Launch the app and log in as either a Customer or Admin.

* **Customers** can browse meals, place orders, pay using available payment options (including points), and leave feedback.
* **Admins** can manage meals, view orders, and access system analytics.

### Example workflow for a Customer:

1. Select meals and quantities.
2. Submit the order.
3. Choose a payment method: **cash, credit, or points**.
4. Receive an order receipt.
5. Leave feedback with a star rating and optional comment.

## Business Logic Highlights

* Customers can only order available meals and must complete payment to finalize orders.
* Loyalty points are earned with completed orders and can be redeemed on future purchases.
* Admins have full control over meal data and visibility.
* Seasonal meals are only shown during their defined season.
* Feedback requires a rating (1–5 stars) and can be edited or deleted.
* Orders require valid payment to transition to the *completed* status.

## Project Structure

* **Forms/** – UI components for login, ordering, admin control, payment, and feedback.
* **Database/** – SQL scripts to create and populate the database:

  * `schema.sql`: Defines tables, relationships, and constraints.
  * `sample_data.sql`: Adds sample meals, users, and orders.
* **Models/** – Class definitions for users, meals, orders, feedback, and more.
* **Helpers/** – Utility methods for database operations and shared logic.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
