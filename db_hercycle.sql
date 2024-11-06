-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 06, 2024 at 04:28 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_hercycle`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_records`
--

CREATE TABLE `tbl_records` (
  `records_id` int(11) NOT NULL,
  `user_id` int(11) DEFAULT NULL,
  `date` date DEFAULT NULL,
  `datestart` date DEFAULT NULL,
  `dateend` date DEFAULT NULL,
  `duration` int(11) DEFAULT NULL,
  `notes` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_records`
--

INSERT INTO `tbl_records` (`records_id`, `user_id`, `date`, `datestart`, `dateend`, `duration`, `notes`) VALUES
(5, 2, '2024-11-06', '2024-11-06', '2024-11-06', 1, 'dsg'),
(6, 1, '2024-11-06', '2024-11-06', '2024-11-06', 2, 'test'),
(7, 2, '2024-11-06', '2024-11-06', '2024-11-06', 2, 'test'),
(8, 1, '2024-11-06', '2024-11-06', '2024-11-06', 2, 'testing'),
(9, 2, '2024-11-06', '2024-10-31', '2024-11-22', 2323, 'testttt'),
(10, 2, '2024-11-06', '2024-10-31', '2024-11-22', 2323, 'testttt'),
(11, 1, '2024-11-06', '2024-11-06', '2024-11-06', 2, 'testngiba'),
(12, 2, '2024-11-06', '2024-11-06', '2024-11-06', 2, 'nanana');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user`
--

CREATE TABLE `tbl_user` (
  `user_ID` int(11) NOT NULL,
  `firstname` varchar(255) NOT NULL,
  `middleinitial` varchar(255) NOT NULL,
  `lastname` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `age` int(255) NOT NULL,
  `gender` text NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_user`
--

INSERT INTO `tbl_user` (`user_ID`, `firstname`, `middleinitial`, `lastname`, `email`, `age`, `gender`, `username`, `password`) VALUES
(1, 'John Kenny', 'Q', 'Reyes', 'reyes.johnkenny.quiachon@gmail.com', 19, 'Male', 'batdimoiprint', 'admin'),
(2, 'test', 'test', 'test', 'test', 19, 'System.Windows.Forms.TextBox, Text: test', 'admin', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_records`
--
ALTER TABLE `tbl_records`
  ADD PRIMARY KEY (`records_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `tbl_user`
--
ALTER TABLE `tbl_user`
  ADD PRIMARY KEY (`user_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_records`
--
ALTER TABLE `tbl_records`
  MODIFY `records_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `tbl_user`
--
ALTER TABLE `tbl_user`
  MODIFY `user_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_records`
--
ALTER TABLE `tbl_records`
  ADD CONSTRAINT `tbl_records_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `tbl_user` (`user_ID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
