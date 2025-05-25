-- Sample Data

-- USER
INSERT INTO "USER" (USER_ID, USER_NAME, PHONE, ROLE, BALANCE) VALUES
(1, 'Ali Ahmed', 201010101010, 'Customer', 150.0),
(2, 'Sara Mostafa', 201020202020, 'Customer', 200.0),
(3, 'Omar Youssef', 201030303030, 'Admin', NULL),
(4, 'Laila Hossam', 201040404040, 'Customer', 300.0),
(5, 'Mona Tamer', 201050505050, 'Customer', 180.5),
(6, 'Khaled Fathy', 201060606060, 'Customer', 95.0),
(7, 'Dina Magdy', 201070707070, 'Customer', 50.5),
(8, 'Tarek Anwar', 201080808080, 'Customer', 1000.0),
(9, 'Rania Saeed', 201090909090, 'Customer', 300.0),
(10, 'Hassan Younes', 201101010101, 'Customer', 10.0);

go

-- MEAL
INSERT INTO MEAL (MEAL_NAME, CATEGORY, PRICE, DESCRIPTION, CALORIES, AVAILABILITY, SEASON) VALUES
('Spring Rolls', 'Appetizers', 45.0, 'Crispy vegetarian rolls', '150', 1, 'Winter'),
('Grilled Chicken', 'Main Course', 120.0, 'Spicy grilled chicken breast', '450', 1, 'All Seasons'),
('French Fries', 'Side Dishes', 30.0, 'Golden crispy fries', '350', 1, 'All Seasons'),
('Greek Salad', 'Salads', 55.0, 'Fresh salad with feta cheese', '200', 1, 'Summer'),
('Chocolate Cake', 'Desserts', 60.0, 'Rich chocolate cake', '500', 1, 'All Seasons'),
('Tomato Soup', 'Soup', 35.0, 'Warm and creamy tomato soup', '180', 1, 'Winter'),
('Club Sandwich', 'Sandwiches and Wraps', 65.0, 'Layered sandwich with chicken', '550', 1, 'All Seasons'),
('Mango Juice', 'Beverages', 25.0, 'Freshly squeezed mango', '130', 1, 'Summer'),
('Fettuccine Alfredo', 'Main Course', 110.0, 'Creamy pasta with mushrooms', '600', 1, 'All Seasons'),
('Garlic Bread', 'Side Dishes', 20.0, 'Toasted bread with garlic butter', '250', 1, 'All Seasons');
go

-- ORDER
INSERT INTO "ORDER" (USER_ID, ORDER_DATE, STATUS) VALUES
(1, GETDATE(), 'Completed'),                         
(2, DATEADD(month, -1, GETDATE()), 'Completed'),  
(3, DATEADD(month, -2, GETDATE()), 'Completed'),  
(4, DATEADD(month, -3, GETDATE()), 'Completed'),  
(5, DATEADD(day, -15, GETDATE()), 'Completed'),   
(6, DATEADD(day, -45, GETDATE()), 'Completed'),
(7, DATEADD(day, -75, GETDATE()), 'Completed'),
(8, GETDATE(), 'Completed'),
(9, DATEADD(month, -1, GETDATE()), 'Completed'),
(10, DATEADD(month, -2, GETDATE()), 'Completed');
go

-- PAYMENT
INSERT INTO PAYMENT (ORDER_ID, AMOUNT, METHOD, PAYMENTDATE) VALUES
(1, 210.0, 'Credit Card', GETDATE()),
(2, 150.0, 'Cash', DATEADD(month, -1, GETDATE())),
(3, 115.0, 'Credit Card', DATEADD(month, -2, GETDATE())),
(4, 180.0, 'Cash', DATEADD(month, -3, GETDATE())),
(5, 175.0, 'Credit Card', DATEADD(day, -15, GETDATE())),
(6, 75.0, 'Cash', DATEADD(day, -45, GETDATE())),
(7, 155.0, 'Credit Card', DATEADD(day, -75, GETDATE())),
(8, 75.0, 'Cash', GETDATE()),
(9, 130.0, 'Credit Card', DATEADD(month, -1, GETDATE())),
(10, 60.0, 'Cash', DATEADD(month, -2, GETDATE()));
go

-- Update ORDER with PAYMENTID
UPDATE "ORDER" SET PAYMENTID = 1 WHERE ORDER_ID = 1;
UPDATE "ORDER" SET PAYMENTID = 2 WHERE ORDER_ID = 2;
UPDATE "ORDER" SET PAYMENTID = 3 WHERE ORDER_ID = 3;
UPDATE "ORDER" SET PAYMENTID = 4 WHERE ORDER_ID = 4;
UPDATE "ORDER" SET PAYMENTID = 5 WHERE ORDER_ID = 5;
UPDATE "ORDER" SET PAYMENTID = 6 WHERE ORDER_ID = 6;
UPDATE "ORDER" SET PAYMENTID = 7 WHERE ORDER_ID = 7;
UPDATE "ORDER" SET PAYMENTID = 8 WHERE ORDER_ID = 8;
UPDATE "ORDER" SET PAYMENTID = 9 WHERE ORDER_ID = 9;
UPDATE "ORDER" SET PAYMENTID = 10 WHERE ORDER_ID = 10;
go

-- FEEDBACK
INSERT INTO FEEDBACK (user_id, meal_name, rating, comment, feedbackDate) VALUES
(1, 'Spring Rolls', 5, 'Crispy and delicious!', '2025-05-01'),
(2, 'Grilled Chicken', 4, 'Well cooked but a bit spicy', '2025-05-02'),
(3, 'French Fries', 3, 'Tasty but a little cold', '2025-05-03'),
(4, 'Greek Salad', 5, 'Fresh and refreshing', '2025-05-04'),
(5, 'Chocolate Cake', 5, 'Heavenly dessert, loved it!', '2025-05-05'),
(6, 'French Fries', 4, 'Crispy and perfectly salted!', '2025-05-06'),
(7, 'Club Sandwich', 3, 'Good but too much mayo', '2025-05-07'),
(8, 'Mango Juice', 5, 'Fresh and sweet!', '2025-05-08'),
(9, 'Fettuccine Alfredo', 4, 'Creamy and filling', '2025-05-09'),
(10, 'Garlic Bread', 2, 'Could be more crispy', '2025-05-10');
go


-- ORDER_DETAILS
INSERT INTO ORDER_DETAILS (order_id, meal_name, quantity) VALUES
(1, 'Spring Rolls', 2),
(1, 'Grilled Chicken', 1),
(2, 'French Fries', 3),
(2, 'Garlic Bread', 2),
(3, 'Greek Salad', 1),
(3, 'Mango Juice', 2),
(4, 'Chocolate Cake', 2),
(4, 'Tomato Soup', 1),
(5, 'Club Sandwich', 1),
(5, 'Fettuccine Alfredo', 1),
(6, 'French Fries', 1),
(6, 'Spring Rolls', 1),
(7, 'Club Sandwich', 2),
(7, 'Mango Juice', 1),
(8, 'Mango Juice', 3),
(9, 'Fettuccine Alfredo', 1),
(9, 'Garlic Bread', 1),
(10, 'Garlic Bread', 3);
go
