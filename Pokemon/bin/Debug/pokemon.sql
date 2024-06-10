-- Crear la base de datos si no existe
CREATE DATABASE IF NOT EXISTS `pokemon` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `pokemon`;

-- Crear la tabla `pokemones` si no existe
CREATE TABLE IF NOT EXISTS `pokemones` (
  `Nick` varchar(255) DEFAULT NULL,
  `PokemonID` int DEFAULT NULL,
  `HP` int DEFAULT NULL,
  `Attack` int DEFAULT NULL,
  `Defense` int DEFAULT NULL,
  `SPAttack` int DEFAULT NULL,
  `SPDefense` int DEFAULT NULL,
  `Speed` int DEFAULT NULL,
  `EXP` int DEFAULT NULL,
  `LVL` int DEFAULT NULL,
  `Skill1` varchar(255) DEFAULT NULL,
  `Skill2` varchar(255) DEFAULT NULL,
  `Skill3` varchar(255) DEFAULT NULL,
  `Skill4` varchar(255) DEFAULT NULL,
  `TP` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Crear la tabla `pokemonusuarios` si no existe
CREATE TABLE IF NOT EXISTS `pokemonusuarios` (
  `Nombre` varchar(255) DEFAULT NULL,
  `Contraseña` varchar(255) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `Genero` varchar(50) DEFAULT NULL,
  `Primario` int DEFAULT NULL,
  `Nick` varchar(255) DEFAULT NULL,
  `Pokemon1` int DEFAULT NULL,
  `Pokemon2` int DEFAULT NULL,
  `Pokemon3` int DEFAULT NULL,
  `Pokemon4` int DEFAULT NULL,
  `Pokemon5` int DEFAULT NULL,
  `Pokemon6` int DEFAULT NULL,
  `Zeny` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

