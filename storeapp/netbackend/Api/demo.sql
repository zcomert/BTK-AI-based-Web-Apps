CREATE TABLE "Products" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Products" PRIMARY KEY AUTOINCREMENT,
    "Name" TEXT NOT NULL,
    "Price" TEXT NOT NULL,
    "ImageURL" TEXT NULL DEFAULT '/images/default.jpg',
    "AtCreatedDate" TEXT NOT NULL
);


INSERT INTO "Products" ("Id", "AtCreatedDate", "ImageURL", "Name", "Price")
VALUES (1, '2024-01-06 12:16:21.0312838', '/images/1.jpg', 'Laptop', '1500.0');


INSERT INTO "Products" ("Id", "AtCreatedDate", "ImageURL", "Name", "Price")
VALUES (2, '2024-01-06 12:16:21.0312852', '/images/2.jpg', 'Smartphone', '800.0');


INSERT INTO "Products" ("Id", "AtCreatedDate", "ImageURL", "Name", "Price")
VALUES (3, '2024-01-06 12:16:21.0312853', '/images/3.jpg', 'Headphones', '100.0');


INSERT INTO "Products" ("Id", "AtCreatedDate", "ImageURL", "Name", "Price")
VALUES (4, '2024-01-06 12:16:21.0312854', '/images/4.jpg', 'Tablet', '600.0');


INSERT INTO "Products" ("Id", "AtCreatedDate", "ImageURL", "Name", "Price")
VALUES (5, '2024-01-06 12:16:21.0312855', '/images/5.jpg', 'Smartwatch', '300.0');


