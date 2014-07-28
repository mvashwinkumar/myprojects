CREATE DATABASE  IF NOT EXISTS `basket` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `basket`;
-- MySQL dump 10.13  Distrib 5.6.13, for Win32 (x86)
--
-- Host: 127.0.0.1    Database: basket
-- ------------------------------------------------------
-- Server version	5.6.14

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `customers` (
  `customer_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `gender` varchar(10) DEFAULT NULL,
  `address` varchar(512) DEFAULT NULL,
  `dob` date DEFAULT NULL,
  `username` varchar(100) NOT NULL,
  PRIMARY KEY (`customer_id`),
  KEY `fk_customers_users1_idx` (`username`),
  CONSTRAINT `fk_customers_users1` FOREIGN KEY (`username`) REFERENCES `users` (`username`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
INSERT INTO `customers` VALUES (1,'test','test@me.com','Male','test','2014-01-02','test');
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inventory`
--

DROP TABLE IF EXISTS `inventory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `inventory` (
  `inventory_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `description` varchar(1000) NOT NULL,
  `quantity` int(11) NOT NULL DEFAULT '0',
  `discount` varchar(45) DEFAULT '0',
  `price` double NOT NULL,
  `imgPath` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`inventory_id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventory`
--

LOCK TABLES `inventory` WRITE;
/*!40000 ALTER TABLE `inventory` DISABLE KEYS */;
INSERT INTO `inventory` VALUES (1,'Red Applies',' Apples are often eaten raw, but can also be found in many prepared foods (especially desserts) and drinks. Many beneficial health effects are thought to result from eating apples; however, two forms of allergies are seen to various proteins found in the fruit.',100,'0',0.15,'/BasketApp/images/apple.png'),(2,'Yellow Bell Pepper','Cultivars of the plant produce fruits in different colors, including red, yellow, orange, green, chocolate/brown, vanilla/white, and purple. Bell peppers are sometimes grouped with less pungent pepper varieties as \"sweet peppers\". Peppers are native to Mexico, Central America and northern South America. ',100,'0',0.6,'/BasketApp/images/bell_pepper.png'),(3,'Blue Berries','Blueberries are sold fresh or processed as individually quick frozen (IQF) fruit, purée, juice, or dried or infused berries, which in turn may be used in a variety of consumer goods, such as jellies, jams, blueberry pies, muffins, snack foods and cereals.',500,'0',0.01,'/BasketApp/images/blueberries.png'),(4,'Brocoli','Broccoli is an edible green plant in the cabbage family, whose large flower head is used as a vegetable. The word broccoli, from the Italian plural of broccolo, refers to \"the flowering top of a cabbage\".Broccoli is often boiled or steamed but may be eaten raw.',200,'0',1.5,'/BasketApp/images/broccoli.png'),(5,'Carrot','Carrots can be eaten in a variety of ways. Only 3% of the beta-carotene in raw carrots is released during digestion: this can be improved to 39% by pulping, cooking and adding cooking oil. Alternatively they may be chopped and boiled, fried or steamed, and cooked in soups and stews, as well as baby and pet foods. A well-known dish is carrots julienne.',500,'0',0.5,'/BasketApp/images/carrot.png'),(6,'Celery','Celery is used in weight-loss diets, where it provides low-calorie dietary fibre bulk. Celery is often incorrectly purported to be a \"negative calorie food\" based on the idea that the body will burn more calories during the digestion of the food than the body can extract from the food itself. ',100,'0',1.5,'/BasketApp/images/celery.png'),(7,'Chilli','The chili pepper (also chile pepper or chilli pepper, from Nahuatl chīlli is the fruit of plants from the genus Capsicum, members of the nightshade family, Solanaceae. The term in British English and in Australia, New Zealand, India, Malaysia and other Asian countries is just chilli without \"pepper\".',500,'0',1,'/BasketApp/images/chili_pepper.png'),(9,'Corn','Maize and cornmeal (ground dried maize) constitute a staple food in many regions of the world. Maize is central to Mexican food. Virtually every dish in Mexican cuisine uses maize. On form of grain or cornmeal, maize is the main ingredient of tortillas, tamales, pozole, atole and all the dishes based on them, like tacos, quesadillas, chilaquiles, enchiladas, tostadas and many more. In Mexico even a fungus of maize, known as huitlacoche is considered a delicacy.',500,'0',2,'/BasketApp/images/corn.png'),(10,'Eggplant','Eggplant (Solanum melongena) is a species of nightshade commonly known in British English as aubergine and also known as melongene, garden egg, or guinea squash. It bears a fruit of the same name (commonly either \"eggplant\" in American and Australian English or \"aubergine\" in British English) that is widely used in cooking, most notably as an important ingredient in dishes such as moussaka and ratatouille. As a member of the genus Solanum, it is related to both the tomato and the potato.',500,'0',2.5,'/BasketApp/images/eggplant.png'),(11,'Lettuce','Lettuce (Lactuca sativa) is an annual plant of the aster or sunflower family Asteraceae. It is most often grown as a leaf vegetable, but sometimes for its stem and seeds. Lettuce was first cultivated by the ancient Egyptians who turned it from a weed, whose seeds were used to produce oil, into a plant grown for its leaves. Lettuce spread to the Greeks and Romans, the latter of whom gave it the name \"lactuca\", from which the English \"lettuce\" is ultimately derived. By 50 AD, multiple types were described, and lettuce appeared often in medieval writings, including several herbals.',500,'0',1.8,'/BasketApp/images/lettuce.png'),(12,'Mushroom','A mushroom (or toadstool) is the fleshy, spore-bearing fruiting body of a fungus, typically produced above ground on soil or on its food source. The standard for the name \"mushroom\" is the cultivated white button mushroom, Agaricus bisporus; hence the word \"mushroom\" is most often applied to those fungi (Basidiomycota, Agaricomycetes) that have a stem (stipe), a cap (pileus), and gills (lamellae, sing. lamella) or pores on the underside of the cap.',1000,'0',0.5,'/BasketApp/images/mushroom.png');
/*!40000 ALTER TABLE `inventory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order_item`
--

DROP TABLE IF EXISTS `order_item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `order_item` (
  `item_id` int(11) NOT NULL AUTO_INCREMENT,
  `inventory_id` int(11) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `discount` decimal(10,0) DEFAULT NULL,
  `order_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`item_id`),
  KEY `fk_order_item_inventory1_idx` (`inventory_id`),
  KEY `fk_order_item_orders1_idx` (`order_id`),
  CONSTRAINT `fk_order_item_inventory1` FOREIGN KEY (`inventory_id`) REFERENCES `inventory` (`inventory_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_order_item_orders1` FOREIGN KEY (`order_id`) REFERENCES `orders` (`order_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order_item`
--

LOCK TABLES `order_item` WRITE;
/*!40000 ALTER TABLE `order_item` DISABLE KEYS */;
/*!40000 ALTER TABLE `order_item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `orders` (
  `order_id` int(11) NOT NULL AUTO_INCREMENT,
  `customer_id` int(11) DEFAULT NULL,
  `order_date` date DEFAULT NULL,
  `customers_customer_id` int(11) NOT NULL,
  PRIMARY KEY (`order_id`),
  KEY `fk_orders_customers1_idx` (`customers_customer_id`),
  CONSTRAINT `fk_orders_customers1` FOREIGN KEY (`customers_customer_id`) REFERENCES `customers` (`customer_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `remember_check`
--

DROP TABLE IF EXISTS `remember_check`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `remember_check` (
  `uuid` varchar(50) NOT NULL,
  `username` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`uuid`),
  KEY `fk_remember_check_users1_idx` (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `remember_check`
--

LOCK TABLES `remember_check` WRITE;
/*!40000 ALTER TABLE `remember_check` DISABLE KEYS */;
INSERT INTO `remember_check` VALUES ('dd08e649-5a36-4181-a41a-4cd7189e693d','admin');
/*!40000 ALTER TABLE `remember_check` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subscription`
--

DROP TABLE IF EXISTS `subscription`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `subscription` (
  `subscription_id` int(11) NOT NULL,
  `customer_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`subscription_id`),
  KEY `fk_subscription_customers1_idx` (`customer_id`),
  CONSTRAINT `fk_subscription_customers1` FOREIGN KEY (`customer_id`) REFERENCES `customers` (`customer_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subscription`
--

LOCK TABLES `subscription` WRITE;
/*!40000 ALTER TABLE `subscription` DISABLE KEYS */;
/*!40000 ALTER TABLE `subscription` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subscription_item`
--

DROP TABLE IF EXISTS `subscription_item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `subscription_item` (
  `subscription_item_id` int(11) NOT NULL AUTO_INCREMENT,
  `inventory_id` int(11) DEFAULT NULL,
  `subscription_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`subscription_item_id`),
  KEY `fk_subscription_item_subscription1_idx` (`subscription_id`),
  KEY `fk_subscription_item_inventory1_idx` (`inventory_id`),
  CONSTRAINT `fk_subscription_item_inventory1` FOREIGN KEY (`inventory_id`) REFERENCES `inventory` (`inventory_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_subscription_item_subscription1` FOREIGN KEY (`subscription_id`) REFERENCES `subscription` (`subscription_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subscription_item`
--

LOCK TABLES `subscription_item` WRITE;
/*!40000 ALTER TABLE `subscription_item` DISABLE KEYS */;
/*!40000 ALTER TABLE `subscription_item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `username` varchar(100) NOT NULL DEFAULT '',
  `password` varchar(255) DEFAULT NULL,
  `role` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`username`),
  CONSTRAINT `fk_users_users_groups1` FOREIGN KEY (`username`) REFERENCES `users_groups` (`username`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES ('abc','admin',NULL),('admin','admin',NULL),('efg','admin',NULL),('test','test',NULL);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users_groups`
--

DROP TABLE IF EXISTS `users_groups`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users_groups` (
  `group_id` varchar(100) NOT NULL,
  `username` varchar(100) NOT NULL,
  PRIMARY KEY (`username`),
  KEY `fk_users_groups_users1_idx` (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users_groups`
--

LOCK TABLES `users_groups` WRITE;
/*!40000 ALTER TABLE `users_groups` DISABLE KEYS */;
INSERT INTO `users_groups` VALUES ('admin','abc'),('admin','admin'),('admin','efg'),('user','test');
/*!40000 ALTER TABLE `users_groups` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'basket'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2014-02-03 14:20:49
