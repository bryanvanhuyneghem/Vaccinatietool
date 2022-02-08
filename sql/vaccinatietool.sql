-- phpMyAdmin SQL Dump
-- version 4.0.4.2
-- http://www.phpmyadmin.net
--
-- Machine: localhost
-- Genereertijd: 29 jan 2022 om 15:03
-- Serverversie: 5.6.13
-- PHP-versie: 5.4.17

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Databank: `vaccinatietool`
--
CREATE DATABASE IF NOT EXISTS `vaccinatietool` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `vaccinatietool`;

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `burger`
--

CREATE TABLE IF NOT EXISTS `burger` (
  `BurgerID` int(11) NOT NULL AUTO_INCREMENT,
  `Voornaam` varchar(45) DEFAULT NULL,
  `Familienaam` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`BurgerID`),
  UNIQUE KEY `RijksregisterNr_UNIQUE` (`BurgerID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=458 ;

--
-- Gegevens worden uitgevoerd voor tabel `burger`
--

INSERT INTO `burger` (`BurgerID`, `Voornaam`, `Familienaam`) VALUES
(1, 'Lester', 'Pimpens'),
(451, 'Jan', 'De Lange'),
(454, 'Reinout', 'Putman'),
(456, 'Tom', 'De Cock'),
(457, 'Lestaa', 'papap');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `vaccin`
--

CREATE TABLE IF NOT EXISTS `vaccin` (
  `VaccinID` int(11) NOT NULL,
  `Naam` varchar(45) DEFAULT NULL,
  `Producent` varchar(45) DEFAULT NULL,
  `Type` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`VaccinID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden uitgevoerd voor tabel `vaccin`
--

INSERT INTO `vaccin` (`VaccinID`, `Naam`, `Producent`, `Type`) VALUES
(1, 'Spikevax', 'Moderna Biotech', 'mRNA'),
(2, 'Comirnaty', 'Biontech', 'mRNA'),
(3, 'Johnson & Johnson', 'Janssen Pharmaceuticals', 'Vector'),
(4, 'Vaxzevria', 'AstraZeneca', 'Vector');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `vaccinatie`
--

CREATE TABLE IF NOT EXISTS `vaccinatie` (
  `VaccinatieID` int(11) NOT NULL AUTO_INCREMENT,
  `Datum` date NOT NULL,
  `BurgerID` int(11) NOT NULL,
  `VaccinID` int(11) NOT NULL,
  `VaccinatorID` int(11) NOT NULL,
  PRIMARY KEY (`VaccinatieID`),
  KEY `fk_Vaccinatie_Burger_idx` (`BurgerID`),
  KEY `fk_Vaccinatie_Vaccin1_idx` (`VaccinID`),
  KEY `fk_Vaccinatie_Vaccinator1_idx` (`VaccinatorID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=13 ;

--
-- Gegevens worden uitgevoerd voor tabel `vaccinatie`
--

INSERT INTO `vaccinatie` (`VaccinatieID`, `Datum`, `BurgerID`, `VaccinID`, `VaccinatorID`) VALUES
(1, '2022-01-26', 1, 1, 1),
(2, '2022-01-27', 1, 3, 1),
(3, '2008-11-11', 1, 1, 1),
(8, '2022-01-27', 451, 4, 1),
(9, '2022-01-27', 454, 3, 1),
(10, '2022-01-27', 1, 4, 1),
(11, '2022-01-27', 456, 3, 1),
(12, '2022-01-28', 457, 1, 1);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `vaccinator`
--

CREATE TABLE IF NOT EXISTS `vaccinator` (
  `VaccinatorID` int(11) NOT NULL,
  `Voornaam` varchar(45) DEFAULT NULL,
  `Familienaam` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`VaccinatorID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden uitgevoerd voor tabel `vaccinator`
--

INSERT INTO `vaccinator` (`VaccinatorID`, `Voornaam`, `Familienaam`) VALUES
(1, 'Dmitriy', 'Van der Beuken');

--
-- Beperkingen voor gedumpte tabellen
--

--
-- Beperkingen voor tabel `vaccinatie`
--
ALTER TABLE `vaccinatie`
  ADD CONSTRAINT `fk_Vaccinatie_Burger` FOREIGN KEY (`BurgerID`) REFERENCES `burger` (`BurgerID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Vaccinatie_Vaccin1` FOREIGN KEY (`VaccinID`) REFERENCES `vaccin` (`VaccinID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Vaccinatie_Vaccinator1` FOREIGN KEY (`VaccinatorID`) REFERENCES `vaccinator` (`VaccinatorID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
