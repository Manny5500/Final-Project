CREATE DATABASE  IF NOT EXISTS `purseshop` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `purseshop`;
-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: purseshop
-- ------------------------------------------------------
-- Server version	8.0.28

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `accounts`
--

DROP TABLE IF EXISTS `accounts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `accounts` (
  `userid` int NOT NULL AUTO_INCREMENT,
  `username` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`userid`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `accounts`
--

LOCK TABLES `accounts` WRITE;
/*!40000 ALTER TABLE `accounts` DISABLE KEYS */;
INSERT INTO `accounts` VALUES (1,'user','user1'),(2,'Haha','Hehe'),(3,'admin','admin'),(4,'user','user'),(5,'user1','user1'),(6,'Sample','Sample'),(7,'Newuser','Newuser'),(8,'New','New'),(9,'user35','user36'),(10,'user44','user');
/*!40000 ALTER TABLE `accounts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customers` (
  `CustomerID` int NOT NULL AUTO_INCREMENT,
  `CustomerName` varchar(250) NOT NULL,
  `Address` varchar(250) DEFAULT NULL,
  `Email` varchar(250) DEFAULT NULL,
  `Cp_No` varchar(11) DEFAULT NULL,
  PRIMARY KEY (`CustomerID`,`CustomerName`),
  UNIQUE KEY `CustomerName` (`CustomerName`),
  KEY `index_customer` (`CustomerName`)
) ENGINE=InnoDB AUTO_INCREMENT=49 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
INSERT INTO `customers` VALUES (10,'Scarlet Malaya','Brgy. Bubukal','scarletmalaya@gmail.com','0911122244'),(11,'Carlita Kalayaan','Brgy. Labuin','carlitakalayaan@gmail.com','09225654654'),(12,'Layla Caspe','Brgy. Duhat','laylacaspe@gmail.com','09335654587'),(22,'Chakay ','Batisan','chakay@gmail.com','0988448785'),(48,'Marlon Victoria','Brgy. Bagumbayan, Santa Cruz, Laguna','marlonvictoria@gmail.com','09229591835');
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `OrderID` int NOT NULL AUTO_INCREMENT,
  `CustomerID` int DEFAULT NULL,
  `ProductID` int DEFAULT NULL,
  `Description` varchar(250) DEFAULT NULL,
  `Quantity` int DEFAULT NULL,
  `DateOrdered` date DEFAULT NULL,
  `DueDate` date DEFAULT NULL,
  `invoice_number` varchar(13) DEFAULT NULL,
  `status` varchar(50) DEFAULT NULL,
  `cashier` varchar(50) DEFAULT NULL,
  `visibility` varchar(50) DEFAULT NULL,
  `price` int DEFAULT NULL,
  `totalprice` int DEFAULT NULL,
  `productname` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`OrderID`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (3,10,4,'1',1,'2022-05-16','2022-04-21','2022000160227','SOLD','admin','SHOW',2500,2500,'Hello Kitty'),(4,22,6,'2',1,'2022-05-16','2022-04-21','2022000160227','SOLD','admin','SHOW',300,300,'Hospital Kit'),(8,11,10,'For ship asap',2,'2022-05-26','2022-05-25','2022000388401','SOLD','admin','SHOW',1000,2000,'Organizer'),(10,11,10,'Pakibilisan',23,'2022-05-26','2022-05-25','2022000367556','SOLD','admin','Hide',1000,23000,'Organizer'),(13,12,10,'',2,'2022-05-26','2022-04-28','2022000078167','SOLD','admin','SHOW',1000,2000,'Organizer'),(14,12,6,'',3,'2022-05-26','2022-04-28','2022000078167','SOLD','admin','SHOW',300,900,'Hospital Kit'),(15,12,5,'afsfds',5,'2022-05-26','2022-04-28','2022000078167','SOLD','admin','SHOW',100,500,'Moana'),(16,10,4,'3',1,'2022-05-26','2022-04-21','2022000027814','SOLD','admin','SHOW',2500,2500,'Hello Kitty'),(17,11,8,'Assorted',2,'2022-05-27','2022-04-21','2022000338475','SOLD','admin','SHOW',120,240,'Ribbon'),(18,11,5,'All Blue',3,'2022-05-27','2022-05-27','2022000338475','SOLD','admin','SHOW',100,300,'Moana'),(20,10,6,'Assorted',4,'2022-05-27','2022-05-28','2022000772706','SOLD','admin','Hide',300,1200,'Hospital Kit'),(21,10,8,'Blue colored',2,'2022-05-27','2022-05-27','2022000772706','SOLD','admin','Hide',120,240,'Ribbon'),(22,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,120,NULL),(23,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,130,NULL),(24,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,140,NULL);
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ordersarchive`
--

DROP TABLE IF EXISTS `ordersarchive`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ordersarchive` (
  `Invoice_number` varchar(13) DEFAULT NULL,
  `customerid` int DEFAULT NULL,
  `productid` int DEFAULT NULL,
  `quantity` int DEFAULT NULL,
  `dateordered` date DEFAULT NULL,
  `duedate` date DEFAULT NULL,
  `deletedAt` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `cashier` varchar(50) DEFAULT NULL,
  `totalprice` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ordersarchive`
--

LOCK TABLES `ordersarchive` WRITE;
/*!40000 ALTER TABLE `ordersarchive` DISABLE KEYS */;
INSERT INTO `ordersarchive` VALUES ('2022000482137',10,1,1,'2022-05-11','2022-04-21','2022-05-27 07:17:47','user',255),('2022000160227',22,9,25,'2022-05-16','2022-04-29','2022-05-27 07:21:30','admin',6000),('2022000160227',12,6,25,'2022-05-16','2022-04-29','2022-05-27 07:21:30','admin',7500),('2022000800747',22,5,25,'2022-05-26','2022-05-31','2022-05-27 07:21:30','admin',2500),('2022000800747',22,7,25,'2022-05-26','2022-05-31','2022-05-27 07:21:30','admin',3000),('2022000482137',10,1,22,'2022-05-11','2022-04-21','2022-05-27 10:46:03','user',5610),('2022000388401',11,9,5,'2022-05-26','2022-05-26','2022-05-27 10:50:33','admin',1200);
/*!40000 ALTER TABLE `ordersarchive` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `products` (
  `Price` int DEFAULT NULL,
  `ProductName` varchar(50) DEFAULT NULL,
  `Description` varchar(250) DEFAULT NULL,
  `productid` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`productid`),
  KEY `index_product` (`ProductName`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` VALUES (2500,'Hello Kitty','20 x 20',4),(100,'Moana','10 x 10 ',5),(300,'Hospital Kit','50 x 50',6),(120,'Bangka ','10 x 10 boat shaped coin purse',7),(120,'Ribbon','12 x 12 ribbon shaped coin purse',8),(240,'Manicure purse','20 x 20 assorted',9),(1000,'Organizer','Transparent and Straps',10),(120,'L purse','12 x 12 L-shaped',11),(120,'Spongebob','12 x 12',12),(240,'Dollar design','Dollar design 12 x 12',13);
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `taskhistory`
--

DROP TABLE IF EXISTS `taskhistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `taskhistory` (
  `taskid` int NOT NULL,
  `workername` varchar(250) DEFAULT NULL,
  `productname` varchar(250) DEFAULT NULL,
  `salary` int DEFAULT NULL,
  `deductions` int DEFAULT NULL,
  `totalsalary` int DEFAULT NULL,
  `duedate` date DEFAULT NULL,
  `quantity` int DEFAULT NULL,
  `DeletedAt` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`taskid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `taskhistory`
--

LOCK TABLES `taskhistory` WRITE;
/*!40000 ALTER TABLE `taskhistory` DISABLE KEYS */;
INSERT INTO `taskhistory` VALUES (1,'asdds','Hello Kitty',2222,2222,0,'2022-05-11',222,'2022-05-27 08:31:12'),(7,'Rey Rey','Hospital Kit',2500,1000,1500,'2022-05-27',250,'2022-05-27 10:52:23');
/*!40000 ALTER TABLE `taskhistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tasks`
--

DROP TABLE IF EXISTS `tasks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tasks` (
  `TaskID` int NOT NULL AUTO_INCREMENT,
  `WorkerName` varchar(250) DEFAULT NULL,
  `ProductName` varchar(250) DEFAULT NULL,
  `Salary` int DEFAULT NULL,
  `Deductions` int DEFAULT NULL,
  `TotalSalary` int DEFAULT NULL,
  `DueDate` date DEFAULT NULL,
  `quantity` int DEFAULT NULL,
  `dateprocessed` date DEFAULT NULL,
  `visibility` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`TaskID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tasks`
--

LOCK TABLES `tasks` WRITE;
/*!40000 ALTER TABLE `tasks` DISABLE KEYS */;
INSERT INTO `tasks` VALUES (2,'Scarlet Kalayaan','Hello Kitty',250,NULL,250,'2022-05-16',1,'2022-05-16','Show'),(3,'Mark Lee','Spongebob',25000,10000,15000,'2022-05-26',250,'2022-05-26','Hide'),(4,'Mark Lee','Hello Kitty',1000,500,500,'2022-05-26',25,'2022-05-26','Hide'),(5,'ABCDd','Bangka ',250,200,50,'2022-05-26',25,'2022-05-26','Hide'),(6,'Mae','Hospital Kit',250,200,50,'2022-05-27',25,'2022-05-27','Hide'),(8,'Rey Calahati','Ribbon',2500,1000,1500,'2022-05-28',25,'2022-05-28','Hide');
/*!40000 ALTER TABLE `tasks` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tempinvoice`
--

DROP TABLE IF EXISTS `tempinvoice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tempinvoice` (
  `invoice_number` varchar(13) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tempinvoice`
--

LOCK TABLES `tempinvoice` WRITE;
/*!40000 ALTER TABLE `tempinvoice` DISABLE KEYS */;
/*!40000 ALTER TABLE `tempinvoice` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `temporders`
--

DROP TABLE IF EXISTS `temporders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `temporders` (
  `OrderID` int NOT NULL AUTO_INCREMENT,
  `CustomerID` int DEFAULT NULL,
  `ProductID` int DEFAULT NULL,
  `Description` varchar(250) DEFAULT NULL,
  `Quantity` int DEFAULT NULL,
  `DateOrdered` date DEFAULT NULL,
  `DueDate` date DEFAULT NULL,
  `invoice_number` varchar(13) DEFAULT NULL,
  `productname` varchar(250) DEFAULT NULL,
  `status` varchar(50) DEFAULT NULL,
  `cashier` varchar(50) DEFAULT NULL,
  `visibility` varchar(50) DEFAULT NULL,
  `price` int DEFAULT NULL,
  `totalprice` int DEFAULT NULL,
  PRIMARY KEY (`OrderID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `temporders`
--

LOCK TABLES `temporders` WRITE;
/*!40000 ALTER TABLE `temporders` DISABLE KEYS */;
/*!40000 ALTER TABLE `temporders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `workers`
--

DROP TABLE IF EXISTS `workers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `workers` (
  `WorkerID` int NOT NULL AUTO_INCREMENT,
  `WorkerName` varchar(250) DEFAULT NULL,
  `Address` varchar(250) DEFAULT NULL,
  `email` varchar(250) DEFAULT NULL,
  `Cp_No` varchar(11) DEFAULT NULL,
  PRIMARY KEY (`WorkerID`),
  KEY `index_worker` (`WorkerName`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `workers`
--

LOCK TABLES `workers` WRITE;
/*!40000 ALTER TABLE `workers` DISABLE KEYS */;
INSERT INTO `workers` VALUES (1,'asdds','afdsafsd','afsddfs','fadsdfs'),(2,'Scarlet Kalayaan','Butuanan','scarlet Kalayaan @gmail.com','1566626'),(3,'Mark Lee','Pila Laguna','marklee@gmail.com','09999999'),(4,'Mark Lee','Pila Laguna','marklee@gmail.com','09999999'),(5,'ABCDd','fasddafs','adfadfs','sdsaffds'),(6,'Mae','Brgy. Bubukal SCL','maemae@gmail.com','093333333'),(7,'Rey Rey','Brgy. Patimbao Santa Cruz Lagunsa','reyrey@yahoo.com','0933333333'),(8,'Rey Calahati','Brgy. Sampalok ','reycalahati@gmail.com','0966592956');
/*!40000 ALTER TABLE `workers` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-06-01 17:06:12
