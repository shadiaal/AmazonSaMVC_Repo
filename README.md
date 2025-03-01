# Amazon.sa Web Application

## A simple web application built using ASP.NET Core MVC to display products, place orders, and view order history.

### Setup Instructions

#### Requirements:
1. .NET Core 8 or 9
2. Visual Studio or Visual Studio Code

#### Setup Steps:
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/AmazonSaMVC_Repo.git
2. Navigate into the project directory:
   `cd AmazonSaMVC_Repo`
3. Restore dependencies:
    `dotnet restore`
4- Build and run the application:
    `dotnet run`
`The application will be available at http://localhost:5209`

#### Features
1. MVC Architecture:
* Models: User, Product, Order, OrderDetails.
* Views:
** Product List View.
** Order Form.
** Order History View.
* Controllers:
** ProductController: Handles displaying products.
** OrderController: Handles order placement and displaying order history.

2. Routing & User Input Handling:
* GET /Products: Display all products.
* GET /Orders/{userId}: Display the order history for the specified user.
* Input validation to ensure user-provided data is correct.

4. Bonus (Optional):
* Session management for keeping users logged in.
* Styled with Bootstrap for improved UI design.


#### Usage:
* Product List: Navigate to /Products.
* Place Order: Navigate to /Orders to select products and place an order.
* Order History: Navigate to /Orders/{userId} to view the user's order history.



