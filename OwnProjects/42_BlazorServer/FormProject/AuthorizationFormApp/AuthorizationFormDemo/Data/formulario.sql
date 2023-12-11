-- MySQL dump 10.13  Distrib 8.0.29, for Win64 (x86_64)
--
-- Host: localhost    Database: formularioautorizacion
-- ------------------------------------------------------
-- Server version	8.0.29

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
-- Table structure for table `agencias`
--

DROP TABLE IF EXISTS `agencias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `agencias` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `NombreAgencia` varchar(45) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `idAgencias_UNIQUE` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `agencias`
--

LOCK TABLES `agencias` WRITE;
/*!40000 ALTER TABLE `agencias` DISABLE KEYS */;
INSERT INTO `agencias` VALUES (1,'PASTO'),(2,'SANDONA'),(3,'IPIALES'),(4,'CONSACÁ'),(5,'BUESACO'),(6,'TAMINANGO'),(7,'LA UNION'),(8,'TUMACO');
/*!40000 ALTER TABLE `agencias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `asociado`
--

DROP TABLE IF EXISTS `asociado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `asociado` (
  `idAsociado` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(200) NOT NULL,
  `Apellido` varchar(200) NOT NULL,
  `Cedula` varchar(200) NOT NULL,
  `Celular` varchar(45) DEFAULT NULL,
  `Agencia` varchar(200) DEFAULT NULL,
  `Canales` varchar(1000) DEFAULT NULL,
  `EsAutorizado` tinyint DEFAULT NULL,
  `FechaRegistro` datetime DEFAULT NULL,
  `IP` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`idAsociado`),
  UNIQUE KEY `idAsociado_UNIQUE` (`idAsociado`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asociado`
--

LOCK TABLES `asociado` WRITE;
/*!40000 ALTER TABLE `asociado` DISABLE KEYS */;
INSERT INTO `asociado` VALUES (1,'Juan','Figueroa','123188475',NULL,'IPIALES','Correo,Visita Personal',1,'2023-10-16 07:29:05','181.55.112.62'),(2,'Juan','Figueroa ','123188475',NULL,'TAMINANGO','Celular,Whatsapp,Correo,Visita Personal',1,'2023-10-16 07:34:44','181.55.112.62'),(3,'Juan José','Figueroa Navarro','1233188475','3216972161','BUESACO','Celular,Whatsapp',1,'2023-10-16 07:47:23','181.55.112.62'),(4,'Juan','figueroa','55466','161','SANDONA','Whatsapp,Visita Personal',1,'2023-10-16 07:58:23','181.55.112.62');
/*!40000 ALTER TABLE `asociado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `canales`
--

DROP TABLE IF EXISTS `canales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `canales` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `NombreCanal` varchar(45) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `idcanales_UNIQUE` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `canales`
--

LOCK TABLES `canales` WRITE;
/*!40000 ALTER TABLE `canales` DISABLE KEYS */;
INSERT INTO `canales` VALUES (1,'Celular'),(2,'Correo'),(3,'Whatsapp'),(4,'Visita Personal'),(5,'Llamada a Fijo');
/*!40000 ALTER TABLE `canales` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-10-17  7:13:42
