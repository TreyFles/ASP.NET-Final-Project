# Final-Project

The Northwind Web site will allow users to broswe products, purchase products, browse ordes and the related order details, log into the users account or create an account that is stored in a database and allow users to look up customers via the Northwind API.

Home page - ( refrence PDF for diagrams that follow these descriptions )
    - Home page will display nav with links to Home, Products, Orders, Register, LogIn , Cart
    - The cart link will be represented with a Cart icon
    - The main display will hold a image of wind representing the Company name
    - there will be an input bar, this bar allows users to either just press enter or enter a country name
    - after hitting enter the page will change to the API page and display all customers or all customers form the inputed country

Products Page - ( refrence PDF for diagrams that follow these descriptions )
    - Products page will display all products for sale from Northwind, reteriving all info from the Northwind database
    - Basic info is displayed Name, stock, id, price and if you press the Add to cart button the item will be added to the cart

Cart Page - ( refrence PDF for diagrams that follow these descriptions )
    - Cart page displays all items that are in the users cart
    - these items are held in a cookie that will expire after a day or so
    - the items are stored in the Cart Model and item detials are stored in the CartItem Model

 Orders Page - ( refrence PDF for diagrams that follow these descriptions )
    - Orders Page displays all orders found in the Northwind database
    - Only the Order ID is displayed and a button to View Order Details
    - If the user clicks the button they will be redirected to the Order Detail page

Order Detail Page - ( refrence PDF for diagrams that follow these descriptions )
    - Order Detail pages displays extra informatiom for only the order the user clicks on
    - Displayed information is Order ID, Date shipped, the shipper, shipping cost, Customer name and their address

Register Page - ( refrence PDF for diagrams that follow these descriptions )
    - Register Page allows users to register for an account at Northwind
    - Users Email and password are stored in a database so they can log back in later

Log in Page - ( refrence PDF for diagrams that follow these descriptions )
    - The Log in page allows users to sign into an account that they have made previously
    - The email and password are check against the sites database for users and only allows them to log in if they have an
        account that matches the databaes records

Unit Tests are implemented in the NorthwindTest Folder and checks to make sure the code is pulling the correct info from the database

The application.log files write the datatime every single time the application is ran and tells the user that the applicaiton has started and is running correctly
