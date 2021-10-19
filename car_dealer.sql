-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 07, 2021 at 10:57 PM
-- Server version: 10.4.19-MariaDB
-- PHP Version: 8.0.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `car_dealer`
--

-- --------------------------------------------------------

--
-- Table structure for table `brands`
--

CREATE TABLE `brands` (
  `BrandID` int(11) NOT NULL,
  `Name` text NOT NULL,
  `Country` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `brands`
--

INSERT INTO `brands` (`BrandID`, `Name`, `Country`) VALUES
(1, 'Mazda', 'Japan'),
(2, 'Toyota', 'Japan'),
(4, 'Nissan', '');

-- --------------------------------------------------------

--
-- Table structure for table `clients`
--

CREATE TABLE `clients` (
  `ClientID` int(11) NOT NULL,
  `FirstName` text NOT NULL,
  `LastName` text NOT NULL,
  `Address` text NOT NULL,
  `Phone` text NOT NULL,
  `Email` text NOT NULL,
  `ContactByPhone` tinyint(1) NOT NULL,
  `ContactByEmail` tinyint(1) NOT NULL,
  `Enterprise` text NOT NULL,
  `VAT` double NOT NULL,
  `FAX` text NOT NULL,
  `Notes` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `clients`
--

INSERT INTO `clients` (`ClientID`, `FirstName`, `LastName`, `Address`, `Phone`, `Email`, `ContactByPhone`, `ContactByEmail`, `Enterprise`, `VAT`, `FAX`, `Notes`) VALUES
(1, 'Ben', 'Kindle', 'Athens', '0707039364', 'BenKindle@gmail.com', 0, 0, 'GR.net', 16, '00100', 'Rich'),
(2, 'Mrs Wendy', 'Joy', 'Lushnje', '0721930993', 'wendy@yahoo.com', 1, 1, 'Deewee', 0, 'wew234', 'Loyal Client'),
(3, 'Willy', 'Wonka', '1445 West Norwood Avenue', '07000000', 'willy@wonka.com', 1, 1, 'Chocolate Factory', 0, '0', ''),
(4, 'Edwin', 'Headwiner', 'sdfsdfsd', '3243242', 'edu@gmail.com', 1, 1, '', 0, '', ''),
(5, 'Brian', 'TheBeast', 'b@gmail.com', '0700000000', 'b@gmail.com', 1, 1, '', 0, '', ''),
(6, 'erli', 'myzeqari', 'address', '25466', 'erlim@asd.com', 0, 1, '', 0, '', 'asdasd'),
(7, 'bruno', 'bruno', 'asdasd', '12345', 'brunoruno@gmail.com', 1, 1, '', 0, '', ''),
(8, 'bla', 'blabla', 'thessaloniki', '2224455', 'bla@gmail.com', 1, 0, '', 0, '', 'asd'),
(9, 'Teona', 'asd', 'asd', '123456789', 'teona@gmail.com', 1, 1, '', 0, '', '');

-- --------------------------------------------------------

--
-- Table structure for table `expenses`
--

CREATE TABLE `expenses` (
  `ExpenseID` int(11) NOT NULL,
  `VehicleID` int(11) NOT NULL,
  `Date` text NOT NULL,
  `Description` text NOT NULL,
  `Amount` double NOT NULL,
  `Notes` longtext NOT NULL,
  `CreatedBy` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `expenses`
--

INSERT INTO `expenses` (`ExpenseID`, `VehicleID`, `Date`, `Description`, `Amount`, `Notes`, `CreatedBy`) VALUES
(1, 1, '12/8/2019', 'Payment Desc', 50000, '', 0),
(5, 2, '12/8/2019', 'Crap', 80000, '', 0),
(6, 11, '12/8/2019', 'Brakes', 6000, '', 0),
(7, 11, '12/8/2019', 'Body Work', 10000, '', 0),
(8, 11, '12/8/2019', 'Registration', 50000, '', 0),
(9, 10, '12/9/2019', 'Body Work', 10000, '', 0),
(10, 13, '5/27/2021', '', 0, '', 0),
(11, 13, '5/27/2021', '', 0, '', 0),
(12, 13, '5/27/2021', '', 0, '', 0),
(13, 8, '6/7/2021', 'Repair', 500, '', 0);

-- --------------------------------------------------------

--
-- Table structure for table `models`
--

CREATE TABLE `models` (
  `ModelID` int(11) NOT NULL,
  `BrandID` int(11) NOT NULL,
  `Name` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `models`
--

INSERT INTO `models` (`ModelID`, `BrandID`, `Name`) VALUES
(1, 1, 'Verisa'),
(2, 1, 'Demio'),
(3, 2, 'Alion'),
(4, 2, 'Premio'),
(5, 2, 'Rav 4'),
(6, 1, 'CS5-Skyactive'),
(13, 4, 'Tiida'),
(14, 4, 'March'),
(15, 4, 'Note');

-- --------------------------------------------------------

--
-- Table structure for table `payments`
--

CREATE TABLE `payments` (
  `PaymentID` int(11) NOT NULL,
  `PaidBy` text NOT NULL,
  `ReceivedBy` int(11) NOT NULL,
  `ReservationID` int(11) NOT NULL,
  `Date` text NOT NULL,
  `Description` text NOT NULL,
  `Amount` double NOT NULL,
  `Notes` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `payments`
--

INSERT INTO `payments` (`PaymentID`, `PaidBy`, `ReceivedBy`, `ReservationID`, `Date`, `Description`, `Amount`, `Notes`) VALUES
(1, 'Ben Kindle', 0, 8, '12/1/2019', 'Reservation Payment', 30000, ''),
(2, 'Ben Kindle', 0, 8, '12/1/2019', 'Balance Payment', 770000, ''),
(3, 'Ben Kindle', 0, 8, '12/1/2019', 'Documents Transfer', 2500, ''),
(5, 'Mrs Wendy Joy', 0, 4, '12/1/2019', 'Car payment ', 90000, ''),
(6, 'Ben Kindle', 0, 10, '12/3/2019', 'Test', 300000, ''),
(7, 'Ben KIndle', 0, 9, '12/8/2019', 'Cash Paymment for vehicle', 910000, ''),
(12, 'Brian Kangogo', 0, 14, '12/8/2019', '20% Deposint', 280000, ''),
(14, 'Brian Kangogo', 0, 14, '12/8/2019', 'Balance Payment', 1120000, ''),
(15, 'Edwin Headwiner', 0, 16, '12/14/2019', '', 0, ''),
(16, 'Edwin Headwiner', 0, 16, '12/14/2019', '', 0, ''),
(17, 'Edwin Headwiner', 0, 16, '12/14/2019', '', 0, ''),
(18, 'Edwin Headwiner', 0, 15, '6/1/2021', '', 0, ''),
(19, 'Mrs Wendy Joy', 0, 4, '6/3/2021', '', 5464658, ''),
(20, 'Edwin Headwiner', 0, 12, '6/3/2021', '', 500000, ''),
(21, 'Ben Kindle', 0, 10, '6/7/2021', '', 0, '');

-- --------------------------------------------------------

--
-- Table structure for table `reservations`
--

CREATE TABLE `reservations` (
  `ReservatonID` int(11) NOT NULL,
  `VehicleID` int(11) NOT NULL,
  `ClientID` int(11) NOT NULL,
  `DateReserved` text NOT NULL,
  `DueDate` text NOT NULL,
  `SellingPrice` double(10,0) NOT NULL,
  `Sold` tinyint(1) NOT NULL,
  `DateSold` text NOT NULL,
  `Notes` longtext NOT NULL,
  `ReservedBy` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `reservations`
--

INSERT INTO `reservations` (`ReservatonID`, `VehicleID`, `ClientID`, `DateReserved`, `DueDate`, `SellingPrice`, `Sold`, `DateSold`, `Notes`, `ReservedBy`) VALUES
(4, 2, 2, '11/30/2019', '12/30/2019', 5464658, 1, '6/3/2021', 'The buyer will come back for repairs', 0),
(6, 6, 1, '11/30/2019', '12/30/2019', 800000, 0, '2019-12-08 13:13:16', '', 0),
(8, 1, 1, '11/30/2019', '12/30/2019', 800000, 1, '6/1/2021', '', 0),
(9, 10, 1, '11/30/2019', '12/31/2019', 900000, 1, '12/25/2019', '15% Refund', 0),
(10, 3, 1, '12/1/2019', '12/31/2019', 90000, 0, '2019-12-08 13:13:21', '', 0),
(12, 4, 4, '12/8/2019', '1/7/2020', 0, 1, '6/3/2021', '', 0),
(14, 11, 5, '12/8/2019', '1/7/2020', 1400000, 1, '12/12/2019', '20% Deposit', 0),
(15, 5, 4, '12/11/2019', '1/10/2020', 800000, 0, '', '', 0),
(16, 8, 4, '12/14/2019', '1/13/2020', 88666, 0, '12/14/2019', '', 0),
(17, 12, 9, '6/4/2021', '7/4/2021', 500, 1, '6/4/2021', '', 0);

-- --------------------------------------------------------

--
-- Table structure for table `sellers`
--

CREATE TABLE `sellers` (
  `SellerID` int(11) NOT NULL,
  `FullName` text NOT NULL,
  `Address` text NOT NULL,
  `Phone` text NOT NULL,
  `Email` text NOT NULL,
  `ContactByEmail` tinyint(1) NOT NULL,
  `ContactByPhone` tinyint(1) NOT NULL,
  `isEnterprise` tinyint(1) NOT NULL COMMENT 'Individual | Enterprise',
  `VAT` double NOT NULL,
  `FAX` text NOT NULL,
  `Notes` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sellers`
--

INSERT INTO `sellers` (`SellerID`, `FullName`, `Address`, `Phone`, `Email`, `ContactByEmail`, `ContactByPhone`, `isEnterprise`, `VAT`, `FAX`, `Notes`) VALUES
(1, 'NewStatus', '', '', '', 0, 0, 0, 0, '', ''),
(2, 'Prestige Motors', 'adasdasda', '0707039364', 'bruno@gmail.com', 0, 1, 1, 33, 'wdadada', ''),
(3, 'ERLI', 'qqwe', '09328423', 'erliSales@gmail.com', 1, 1, 0, 0, '', 'test');

-- --------------------------------------------------------

--
-- Table structure for table `tasks`
--

CREATE TABLE `tasks` (
  `TaskID` int(11) NOT NULL,
  `CreatedBy` int(11) NOT NULL,
  `TargetID` int(11) NOT NULL,
  `Description` text NOT NULL,
  `Complete` tinyint(1) NOT NULL COMMENT 'Pending | Done',
  `CreatedAt` text NOT NULL,
  `CompletedAt` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tasks`
--

INSERT INTO `tasks` (`TaskID`, `CreatedBy`, `TargetID`, `Description`, `Complete`, `CreatedAt`, `CompletedAt`) VALUES
(1, 0, 0, 'Test Task', 0, '11/11/2019', ''),
(2, 0, 0, 'Test Task', 1, '11/11/2019', '');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `UserID` int(11) NOT NULL,
  `Initials` text NOT NULL,
  `FullName` text NOT NULL,
  `email` text NOT NULL,
  `password` text NOT NULL,
  `isAdmin` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`UserID`, `Initials`, `FullName`, `email`, `password`, `isAdmin`) VALUES
(0, 'em', 'erli', 'erlimyzeqari5@gmail.com', '12345', 1),
(5, 'em1', 'erli1', 'erlimyzeqari4@gmail.com', '123456', 1);

-- --------------------------------------------------------

--
-- Table structure for table `vehicles`
--

CREATE TABLE `vehicles` (
  `VehicleID` int(11) NOT NULL,
  `KeyNo` text NOT NULL,
  `Type` text NOT NULL COMMENT 'Demo | New  | Used',
  `ModelID` int(11) NOT NULL,
  `Version` text NOT NULL,
  `Transmission` text NOT NULL,
  `Year` int(11) NOT NULL,
  `KM` int(11) NOT NULL,
  `Fuel` text NOT NULL,
  `CC` int(11) NOT NULL,
  `Color` text NOT NULL,
  `Warranty` int(11) NOT NULL,
  `Chassis` text NOT NULL,
  `SellerID` int(11) NOT NULL,
  `Internet` tinyint(1) NOT NULL,
  `VAT` tinyint(1) NOT NULL,
  `Buying_Price` double NOT NULL,
  `Export_Price` double NOT NULL,
  `forEnterprise` tinyint(1) NOT NULL,
  `Selling_Price` double NOT NULL,
  `Features` longtext NOT NULL,
  `CreatedBy` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `vehicles`
--

INSERT INTO `vehicles` (`VehicleID`, `KeyNo`, `Type`, `ModelID`, `Version`, `Transmission`, `Year`, `KM`, `Fuel`, `CC`, `Color`, `Warranty`, `Chassis`, `SellerID`, `Internet`, `VAT`, `Buying_Price`, `Export_Price`, `forEnterprise`, `Selling_Price`, `Features`, `CreatedBy`) VALUES
(1, '11', 'Demo', 3, '2012', 'Automatic', 2012, 97000, 'Petrol', 1490, 'Pearl', 2012, 'KCV516F', 1, 1, 1, 500000, 80000, 1, 90000, 'Airbags, Alarm, CD Player, Bluethoot', 0),
(2, '89', 'Demo', 5, '556', 'Automatic', 2012, 89465, 'Petrol', 3432, 'Red', 3025, 'kcb500t', 3, 1, 0, 600000, 645544, 1, 546465, '', 0),
(3, '88', 'Occasion', 2, '1.5', 'Manual', 2012, 982511, 'Hybrid', 2500, 'Yellow', 2012, 'kcc500', 2, 1, 0, 500000, 600000, 0, 0, '', 0),
(4, '1', 'Demo', 1, '12', 'Automatic', 2012, 98544, 'Petrol', 1490, 'Black', 2011, '56566', 1, 0, 1, 500000, 0, 0, 0, '', 0),
(5, '2', 'Demo', 1, '10', 'Manual', 2012, 97000, 'Hybrid', 1500, 'Blue', 2012, 'kcf300', 1, 1, 1, 60000, 0, 0, 0, '', 0),
(6, '3', 'Demo', 1, '1.5', 'Automatic', 2012, 9700, 'Petrol', 1490, 'Blue', 2000, 'khjkashdjhkjaad', 1, 0, 0, 90000, 30008, 0, 99877, '', 0),
(8, '5', 'Demo', 2, '558', 'Manual', 2013, 89555, 'GPL', 2500, 'White', 2012, 'KCC778', 3, 0, 1, 90000, 88999, 0, 88666, 'JUst Notes', 0),
(10, '7', 'Demo', 4, '2322', 'Automatic', 3232, 3223, 'Petrol', 2323, '2323', 2323, '2323', 3, 1, 1, 800000, 2323, 1, 2323232, '232323232', 0),
(11, '12', 'Demo', 2, '2015', 'Manual', 2015, 0, 'Hybrid', 1500, 'red', 2020, 'KCX516F', 3, 1, 1, 1000000, 1200000, 0, 0, '', 0),
(12, '100', 'Demo', 15, '1.5', 'Automatic', 2013, 79000, 'Petrol', 1200, 'maroon', 2020, 'abcd200', 2, 1, 1, 550000, 700000, 0, 660000, 'AirBags, DVD, bluetooth', 0),
(13, '123', 'Occasion', 15, '123', 'Automatic', 1998, 12, 'Electric', 12, 'asd', 1445, 'asd', 2, 1, 1, 1555, 12, 0, 1555, '', 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `brands`
--
ALTER TABLE `brands`
  ADD PRIMARY KEY (`BrandID`);

--
-- Indexes for table `clients`
--
ALTER TABLE `clients`
  ADD PRIMARY KEY (`ClientID`);

--
-- Indexes for table `expenses`
--
ALTER TABLE `expenses`
  ADD PRIMARY KEY (`ExpenseID`),
  ADD KEY `VehicleID` (`VehicleID`),
  ADD KEY `CreatedBy` (`CreatedBy`);

--
-- Indexes for table `models`
--
ALTER TABLE `models`
  ADD PRIMARY KEY (`ModelID`),
  ADD KEY `BrandID` (`BrandID`);

--
-- Indexes for table `payments`
--
ALTER TABLE `payments`
  ADD PRIMARY KEY (`PaymentID`),
  ADD KEY `ReservationID` (`ReservationID`),
  ADD KEY `ReceivedBy` (`ReceivedBy`);

--
-- Indexes for table `reservations`
--
ALTER TABLE `reservations`
  ADD PRIMARY KEY (`ReservatonID`),
  ADD KEY `VehicleID` (`VehicleID`),
  ADD KEY `ClientID` (`ClientID`),
  ADD KEY `ReservedBy` (`ReservedBy`);

--
-- Indexes for table `sellers`
--
ALTER TABLE `sellers`
  ADD PRIMARY KEY (`SellerID`);

--
-- Indexes for table `tasks`
--
ALTER TABLE `tasks`
  ADD PRIMARY KEY (`TaskID`),
  ADD KEY `TargetID` (`TargetID`),
  ADD KEY `CreatedBy` (`CreatedBy`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`UserID`);

--
-- Indexes for table `vehicles`
--
ALTER TABLE `vehicles`
  ADD PRIMARY KEY (`VehicleID`),
  ADD KEY `ModelID` (`ModelID`),
  ADD KEY `SellerID` (`SellerID`),
  ADD KEY `CreatedBy` (`CreatedBy`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `brands`
--
ALTER TABLE `brands`
  MODIFY `BrandID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `clients`
--
ALTER TABLE `clients`
  MODIFY `ClientID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `expenses`
--
ALTER TABLE `expenses`
  MODIFY `ExpenseID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `models`
--
ALTER TABLE `models`
  MODIFY `ModelID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `payments`
--
ALTER TABLE `payments`
  MODIFY `PaymentID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `reservations`
--
ALTER TABLE `reservations`
  MODIFY `ReservatonID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `sellers`
--
ALTER TABLE `sellers`
  MODIFY `SellerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tasks`
--
ALTER TABLE `tasks`
  MODIFY `TaskID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `vehicles`
--
ALTER TABLE `vehicles`
  MODIFY `VehicleID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `expenses`
--
ALTER TABLE `expenses`
  ADD CONSTRAINT `expenses_ibfk_1` FOREIGN KEY (`VehicleID`) REFERENCES `vehicles` (`VehicleID`),
  ADD CONSTRAINT `expenses_ibfk_2` FOREIGN KEY (`CreatedBy`) REFERENCES `users` (`UserID`);

--
-- Constraints for table `models`
--
ALTER TABLE `models`
  ADD CONSTRAINT `models_ibfk_1` FOREIGN KEY (`BrandID`) REFERENCES `brands` (`BrandID`);

--
-- Constraints for table `payments`
--
ALTER TABLE `payments`
  ADD CONSTRAINT `payments_ibfk_1` FOREIGN KEY (`ReservationID`) REFERENCES `reservations` (`ReservatonID`),
  ADD CONSTRAINT `payments_ibfk_2` FOREIGN KEY (`ReceivedBy`) REFERENCES `users` (`UserID`);

--
-- Constraints for table `reservations`
--
ALTER TABLE `reservations`
  ADD CONSTRAINT `reservations_ibfk_1` FOREIGN KEY (`ClientID`) REFERENCES `clients` (`ClientID`),
  ADD CONSTRAINT `reservations_ibfk_2` FOREIGN KEY (`VehicleID`) REFERENCES `vehicles` (`VehicleID`),
  ADD CONSTRAINT `reservations_ibfk_3` FOREIGN KEY (`ReservedBy`) REFERENCES `users` (`UserID`);

--
-- Constraints for table `vehicles`
--
ALTER TABLE `vehicles`
  ADD CONSTRAINT `vehicles_ibfk_1` FOREIGN KEY (`ModelID`) REFERENCES `models` (`ModelID`),
  ADD CONSTRAINT `vehicles_ibfk_2` FOREIGN KEY (`SellerID`) REFERENCES `sellers` (`SellerID`),
  ADD CONSTRAINT `vehicles_ibfk_3` FOREIGN KEY (`CreatedBy`) REFERENCES `users` (`UserID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
