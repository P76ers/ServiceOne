-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 15. Mai 2024 um 11:04
-- Server-Version: 10.4.32-MariaDB
-- PHP-Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `serviceone`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `artikel`
--

CREATE TABLE `artikel` (
  `ArtikelID` int(11) NOT NULL,
  `MaterialNr` int(11) DEFAULT NULL,
  `Artikelname` varchar(70) DEFAULT NULL,
  `Beschreibung` longtext DEFAULT NULL,
  `Einzelpreis` decimal(19,2) DEFAULT NULL,
  `KategorieNr` int(11) DEFAULT NULL,
  `Bild` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `artikel`
--

INSERT INTO `artikel` (`ArtikelID`, `MaterialNr`, `Artikelname`, `Beschreibung`, `Einzelpreis`, `KategorieNr`, `Bild`) VALUES
(1, 11428, 'Laugenpumpe', 'PL19/3F 220V50HZ', 99.00, 1, '11428.png'),
(2, 1234, 'Anfahrt', '3,0KW 220V', 49.00, 2, ''),
(3, 1234, 'WDA 111', 'Waschmaschine', 599.00, 3, 'wda111.png'),
(4, 123455, 'WDA 111', 'Waschmaschine', 599.00, 3, 'wda111.png');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `artikelkategorien`
--

CREATE TABLE `artikelkategorien` (
  `KategorieID` int(11) NOT NULL,
  `Kategoriename` varchar(255) DEFAULT NULL,
  `Beschreibung` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `artikelkategorien`
--

INSERT INTO `artikelkategorien` (`KategorieID`, `Kategoriename`, `Beschreibung`) VALUES
(1, 'Ersatzteile', 'Miele'),
(2, 'Dienstleistungen', ''),
(3, 'Gerätschaften', 'Miele');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `bestelldetails`
--

CREATE TABLE `bestelldetails` (
  `BestellNr` int(11) NOT NULL,
  `ArtikelNr` int(11) NOT NULL,
  `TechnikerNr` int(11) DEFAULT NULL,
  `Anzahl` decimal(19,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `bestelldetails`
--

INSERT INTO `bestelldetails` (`BestellNr`, `ArtikelNr`, `TechnikerNr`, `Anzahl`) VALUES
(1, 1, 1, 1.00),
(1, 2, 1, 1.50),
(2, 2, 3, 2.00),
(2, 3, 3, 3.00);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `bestellungen`
--

CREATE TABLE `bestellungen` (
  `BestellID` int(11) NOT NULL,
  `KundenNr` int(11) DEFAULT NULL,
  `Datum` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `bestellungen`
--

INSERT INTO `bestellungen` (`BestellID`, `KundenNr`, `Datum`) VALUES
(1, 1, '2023-11-14'),
(2, 2, '2024-01-09'),
(3, 3, '2024-04-23');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `kunden`
--

CREATE TABLE `kunden` (
  `KundenID` int(11) NOT NULL,
  `Firma` varchar(255) DEFAULT NULL,
  `Vorname` varchar(255) DEFAULT NULL,
  `Nachname` varchar(255) DEFAULT NULL,
  `Strasse` varchar(255) DEFAULT NULL,
  `Hausnummer` varchar(255) DEFAULT NULL,
  `PLZ` varchar(255) DEFAULT NULL,
  `Ort` varchar(255) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `Telefon` varchar(255) DEFAULT NULL,
  `Rabatt` decimal(19,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `kunden`
--

INSERT INTO `kunden` (`KundenID`, `Firma`, `Vorname`, `Nachname`, `Strasse`, `Hausnummer`, `PLZ`, `Ort`, `Email`, `Telefon`, `Rabatt`) VALUES
(1, 'Alfreds Futterkiste', 'Maria', 'Anders', 'Obere Straße', '57B', '12209', 'Berlin', 'maria@fiktiv.net', '030-0074321', 1.20),
(2, 'B\'s Beverages', 'Victoria', 'Ashworth', 'Fauntleroy Circus', '21', 'EC2 5NT', 'London', 'victoria@fiktiv.net', '(71) 555-1212', 1.30),
(3, 'Ricardo Adocicados', 'Janete', 'Limeira', 'Av. Copacabana', '267', '02389-890', 'Rio de Janeiro', 'janete@fiktiv.net', '(21) 555-3412', 1.70);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `lager`
--

CREATE TABLE `lager` (
  `LagerNr` int(11) NOT NULL,
  `ArtikelNr` int(11) NOT NULL,
  `Bestand` int(11) DEFAULT NULL,
  `Mindestbestand` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `lager`
--

INSERT INTO `lager` (`LagerNr`, `ArtikelNr`, `Bestand`, `Mindestbestand`) VALUES
(1, 1, 7, 5),
(1, 3, 1, 2),
(2, 1, 1, 2),
(3, 1, 3, 2);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `techniker`
--

CREATE TABLE `techniker` (
  `TechnikerID` int(11) NOT NULL,
  `Vorname` varchar(255) DEFAULT NULL,
  `Nachname` varchar(255) DEFAULT NULL,
  `KFZ` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `techniker`
--

INSERT INTO `techniker` (`TechnikerID`, `Vorname`, `Nachname`, `KFZ`) VALUES
(1, 'Hauptlager', 'HH', ''),
(2, 'Jesse', 'Pinkman', 'PI-NK-2234'),
(3, 'Walther', 'Heisenberg', 'HH-WH-1306');

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `artikel`
--
ALTER TABLE `artikel`
  ADD PRIMARY KEY (`ArtikelID`),
  ADD KEY `fkArtikelkattegorienArtikel` (`KategorieNr`);

--
-- Indizes für die Tabelle `artikelkategorien`
--
ALTER TABLE `artikelkategorien`
  ADD PRIMARY KEY (`KategorieID`);

--
-- Indizes für die Tabelle `bestelldetails`
--
ALTER TABLE `bestelldetails`
  ADD PRIMARY KEY (`BestellNr`,`ArtikelNr`),
  ADD KEY `fkTechnikerBestelldetails` (`TechnikerNr`),
  ADD KEY `fkArtikelBestelldetails` (`ArtikelNr`);

--
-- Indizes für die Tabelle `bestellungen`
--
ALTER TABLE `bestellungen`
  ADD PRIMARY KEY (`BestellID`),
  ADD KEY `fkKundenBestellungen` (`KundenNr`);

--
-- Indizes für die Tabelle `kunden`
--
ALTER TABLE `kunden`
  ADD PRIMARY KEY (`KundenID`);

--
-- Indizes für die Tabelle `lager`
--
ALTER TABLE `lager`
  ADD PRIMARY KEY (`LagerNr`,`ArtikelNr`),
  ADD KEY `fkArtikelLager` (`ArtikelNr`);

--
-- Indizes für die Tabelle `techniker`
--
ALTER TABLE `techniker`
  ADD PRIMARY KEY (`TechnikerID`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `artikel`
--
ALTER TABLE `artikel`
  MODIFY `ArtikelID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT für Tabelle `artikelkategorien`
--
ALTER TABLE `artikelkategorien`
  MODIFY `KategorieID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT für Tabelle `bestellungen`
--
ALTER TABLE `bestellungen`
  MODIFY `BestellID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT für Tabelle `kunden`
--
ALTER TABLE `kunden`
  MODIFY `KundenID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT für Tabelle `techniker`
--
ALTER TABLE `techniker`
  MODIFY `TechnikerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `artikel`
--
ALTER TABLE `artikel`
  ADD CONSTRAINT `fkArtikelkattegorienArtikel` FOREIGN KEY (`KategorieNr`) REFERENCES `artikelkategorien` (`KategorieID`);

--
-- Constraints der Tabelle `bestelldetails`
--
ALTER TABLE `bestelldetails`
  ADD CONSTRAINT `fkArtikelBestelldetails` FOREIGN KEY (`ArtikelNr`) REFERENCES `artikel` (`ArtikelID`),
  ADD CONSTRAINT `fkBestellungenBestelldetails` FOREIGN KEY (`BestellNr`) REFERENCES `bestellungen` (`BestellID`),
  ADD CONSTRAINT `fkTechnikerBestelldetails` FOREIGN KEY (`TechnikerNr`) REFERENCES `techniker` (`TechnikerID`);

--
-- Constraints der Tabelle `bestellungen`
--
ALTER TABLE `bestellungen`
  ADD CONSTRAINT `fkKundenBestellungen` FOREIGN KEY (`KundenNr`) REFERENCES `kunden` (`KundenID`);

--
-- Constraints der Tabelle `lager`
--
ALTER TABLE `lager`
  ADD CONSTRAINT `fkArtikelLager` FOREIGN KEY (`ArtikelNr`) REFERENCES `artikel` (`ArtikelID`),
  ADD CONSTRAINT `fkTechnikerLager` FOREIGN KEY (`LagerNr`) REFERENCES `techniker` (`TechnikerID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
