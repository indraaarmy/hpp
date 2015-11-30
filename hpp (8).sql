-- phpMyAdmin SQL Dump
-- version 4.0.4
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Nov 29, 2015 at 01:33 PM
-- Server version: 5.6.12-log
-- PHP Version: 5.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `hpp`
--
CREATE DATABASE IF NOT EXISTS `hpp` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `hpp`;

-- --------------------------------------------------------

--
-- Table structure for table `kebutuhan`
--

CREATE TABLE IF NOT EXISTS `kebutuhan` (
  `id_kebutuhan` int(11) NOT NULL AUTO_INCREMENT,
  `nama_kebutuhan` varchar(30) NOT NULL,
  `harga_kebutuhan` float NOT NULL,
  `satuan` varchar(30) NOT NULL,
  `jenis` varchar(30) NOT NULL,
  `listrik` varchar(11) NOT NULL,
  `watt` int(11) NOT NULL,
  `umur_pemakaian` float NOT NULL,
  PRIMARY KEY (`id_kebutuhan`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=70 ;

--
-- Dumping data for table `kebutuhan`
--

INSERT INTO `kebutuhan` (`id_kebutuhan`, `nama_kebutuhan`, `harga_kebutuhan`, `satuan`, `jenis`, `listrik`, `watt`, `umur_pemakaian`) VALUES
(38, ' Kulit pull up', 20000, 'ft', 'bahan', 'tidak', 0, 0),
(40, 'Ring D', 381.94, 'biji', 'bahan', 'tidak', 0, 0),
(41, 'Ring geser', 381.94, 'biji', 'bahan', 'tidak', 0, 0),
(42, 'Kepala Rit', 140, 'biji', 'bahan', 'tidak', 0, 0),
(44, 'Doghug', 1666.67, 'biji', 'bahan', 'tidak', 0, 0),
(45, 'Resletting', 41, 'cm', 'bahan', 'tidak', 0, 0),
(46, 'Cat Semir Puring', 15, 'ml', 'bahan', 'tidak', 0, 0),
(47, 'Cat Vether', 50, 'g', 'bahan', 'tidak', 0, 0),
(48, 'Benang Nilon', 0.049, 'cm', 'bahan', 'tidak', 0, 0),
(49, 'Busa/Spon', 4000, 'g', 'bahan', 'tidak', 0, 0),
(50, 'Kain Puring', 6500, 'm', 'bahan', 'tidak', 0, 0),
(51, 'Kertas Karton', 3500, 'lembar', 'bahan', 'tidak', 0, 0),
(52, 'Lem Kuning', 25, 'liter', 'bahan', 'tidak', 0, 0),
(53, 'Lem Latex', 25, 'kg', 'bahan', 'tidak', 0, 0),
(54, 'Lem Putih D 600', 60, 'g', 'bahan', 'tidak', 0, 0),
(55, 'Isi Cutter', 128.2, 'pcs', 'bahan', 'tidak', 0, 0),
(56, 'ATK', 10000, 'unit', 'alat', 'tidak', 0, 2),
(57, 'Alat Ukur', 8500, 'unit', 'alat', 'tidak', 0, 2),
(58, 'Alat Potong Cutter', 12000, 'unit', 'alat', 'tidak', 0, 3),
(59, 'Alat Potong Gunting', 18000, 'unit', 'alat', 'tidak', 0, 3),
(60, 'Lampu Neon 40 Watt', 20000, 'unit', 'alat', 'ya', 40, 5),
(61, 'Lampu dop 10 Watt', 3000, 'unit', 'alat', 'ya', 10, 5),
(62, 'Alat Kating', 700000, 'unit', 'alat', 'tidak', 0, 60),
(63, 'Mesin seset/skiving', 7000000, 'unit', 'alat', 'ya', 250, 60),
(64, 'Mesin Stampel/emboss', 7000000, 'unit', 'alat', 'ya', 300, 60),
(65, 'Mesin jahit Mother', 2600000, 'unit', 'alat', 'ya', 250, 60),
(66, 'Mesin jahit TYPICAL 2605', 6300000, 'unit', 'alat', 'ya', 400, 60),
(67, 'Palu', 25000, 'unit', 'alat', 'tidak', 0, 3),
(68, 'Dongkrak', 400000, 'unit', 'alat', 'tidak', 0, 60),
(69, 'Pinset', 3000, 'unit', 'alat', 'tidak', 0, 0.1);

-- --------------------------------------------------------

--
-- Table structure for table `kebutuhan_produk`
--

CREATE TABLE IF NOT EXISTS `kebutuhan_produk` (
  `id_kebutuhan_produk` int(11) NOT NULL AUTO_INCREMENT,
  `id_produk` int(11) NOT NULL,
  `id_kebutuhan` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  PRIMARY KEY (`id_kebutuhan_produk`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=60 ;

--
-- Dumping data for table `kebutuhan_produk`
--

INSERT INTO `kebutuhan_produk` (`id_kebutuhan_produk`, `id_produk`, `id_kebutuhan`, `jumlah`) VALUES
(28, 4, 38, 0),
(29, 4, 40, 0),
(30, 4, 41, 0),
(31, 4, 42, 0),
(32, 4, 44, 0),
(33, 4, 45, 0),
(34, 4, 46, 0),
(35, 4, 47, 0),
(36, 4, 48, 0),
(37, 4, 49, 0),
(38, 4, 50, 0),
(39, 4, 51, 0),
(40, 4, 52, 0),
(41, 4, 53, 0),
(42, 4, 54, 0),
(43, 4, 55, 0),
(44, 4, 56, 0),
(45, 4, 57, 0),
(46, 4, 58, 0),
(47, 4, 59, 0),
(48, 4, 60, 0),
(49, 4, 61, 0),
(50, 4, 62, 0),
(51, 4, 63, 0),
(52, 4, 64, 0),
(53, 4, 65, 0),
(54, 4, 66, 0),
(55, 4, 67, 0),
(56, 4, 68, 0),
(57, 4, 69, 0),
(58, 5, 56, 0),
(59, 5, 60, 0);

-- --------------------------------------------------------

--
-- Table structure for table `kebutuhan_sk`
--

CREATE TABLE IF NOT EXISTS `kebutuhan_sk` (
  `id_kebutuhan_sk` int(11) NOT NULL AUTO_INCREMENT,
  `id_kebutuhan_produk` int(11) NOT NULL,
  `id_sk_produk` int(11) NOT NULL,
  `jumlah` float NOT NULL,
  PRIMARY KEY (`id_kebutuhan_sk`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=132 ;

--
-- Dumping data for table `kebutuhan_sk`
--

INSERT INTO `kebutuhan_sk` (`id_kebutuhan_sk`, `id_kebutuhan_produk`, `id_sk_produk`, `jumlah`) VALUES
(65, 37, 19, 8),
(66, 33, 19, 10),
(67, 33, 27, 7),
(71, 32, 20, 9),
(78, 39, 28, 2),
(79, 44, 28, 1),
(80, 45, 28, 1),
(81, 48, 28, 6),
(82, 28, 29, 13),
(83, 43, 29, 1),
(84, 46, 29, 1),
(85, 48, 29, 18),
(86, 49, 29, 7),
(87, 50, 29, 1),
(88, 51, 30, 1),
(89, 35, 31, 0.2),
(90, 52, 32, 1),
(91, 36, 33, 5861),
(92, 37, 33, 0.5),
(93, 38, 33, 1.5),
(94, 40, 33, 50),
(95, 41, 33, 28.7),
(96, 42, 33, 14.38),
(97, 47, 33, 1),
(98, 48, 33, 24),
(99, 49, 33, 9),
(100, 53, 33, 1),
(101, 54, 33, 1),
(102, 55, 33, 1),
(103, 29, 34, 2),
(104, 30, 34, 1),
(105, 31, 34, 4),
(106, 32, 34, 1),
(107, 33, 34, 41),
(108, 48, 34, 2),
(109, 56, 34, 1),
(110, 34, 35, 1.43),
(111, 48, 35, 2),
(112, 57, 35, 1),
(113, 48, 36, 2),
(114, 58, 37, 1),
(115, 59, 37, 2),
(116, 58, 38, 2),
(117, 59, 38, 1),
(118, 58, 39, 1),
(119, 59, 39, 4),
(120, 58, 40, 3),
(121, 59, 40, 5),
(122, 58, 41, 8),
(123, 59, 41, 2),
(124, 58, 42, 1),
(125, 59, 42, 1),
(126, 58, 43, 1),
(127, 59, 43, 1),
(128, 58, 44, 1),
(129, 59, 44, 3),
(130, 58, 45, 2),
(131, 59, 45, 4);

-- --------------------------------------------------------

--
-- Table structure for table `produk`
--

CREATE TABLE IF NOT EXISTS `produk` (
  `id_produk` int(11) NOT NULL AUTO_INCREMENT,
  `nama_produk` varchar(30) NOT NULL,
  PRIMARY KEY (`id_produk`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `produk`
--

INSERT INTO `produk` (`id_produk`, `nama_produk`) VALUES
(4, 'Tas Sacco'),
(5, 'h');

-- --------------------------------------------------------

--
-- Table structure for table `sk`
--

CREATE TABLE IF NOT EXISTS `sk` (
  `id_sk` int(11) NOT NULL AUTO_INCREMENT,
  `nama_sk` varchar(30) NOT NULL,
  PRIMARY KEY (`id_sk`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=10 ;

--
-- Dumping data for table `sk`
--

INSERT INTO `sk` (`id_sk`, `nama_sk`) VALUES
(1, 'Perancangan Gambar Pola'),
(2, 'Pemotongan Pola'),
(3, 'Penyesetan Kulit'),
(4, 'Pewarnaan Handle'),
(5, 'Pembuatan Stampel'),
(6, 'Perakitan'),
(7, 'Pemasangan Accesoris'),
(8, 'Make Up'),
(9, 'TQC');

-- --------------------------------------------------------

--
-- Table structure for table `sk_produk`
--

CREATE TABLE IF NOT EXISTS `sk_produk` (
  `id_sk_produk` int(11) NOT NULL AUTO_INCREMENT,
  `id_produk` int(11) NOT NULL,
  `id_sk` int(11) NOT NULL,
  `waktu` float NOT NULL,
  `jumlah_pekerja` int(11) NOT NULL,
  `upah` double NOT NULL,
  PRIMARY KEY (`id_sk_produk`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=46 ;

--
-- Dumping data for table `sk_produk`
--

INSERT INTO `sk_produk` (`id_sk_produk`, `id_produk`, `id_sk`, `waktu`, `jumlah_pekerja`, `upah`) VALUES
(28, 4, 1, 58.39, 5, 5400000),
(29, 4, 2, 11.47, 7, 7450000),
(30, 4, 3, 6.88, 2, 1700000),
(31, 4, 4, 3.76, 8, 7600000),
(32, 4, 5, 6.07, 4, 3400000),
(33, 4, 6, 279.55, 70, 199962500),
(34, 4, 7, 60, 6, 4500000),
(35, 4, 8, 24.04, 9, 7725000),
(36, 4, 9, 11.82, 6, 5900000),
(37, 5, 1, 90, 8, 9000),
(38, 5, 2, 80, 5, 70000),
(39, 5, 3, 60, 7, 700000),
(40, 5, 4, 56, 90, 6000000),
(41, 5, 5, 5, 1, 900000),
(42, 5, 6, 6, 8, 700000),
(43, 5, 7, 56, 1, 900000),
(44, 5, 8, 70, 5, 500000),
(45, 5, 9, 40, 4, 100000);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `username` varchar(25) NOT NULL,
  `password` varchar(25) NOT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`username`, `password`) VALUES
('fai', 'fai'),
('intan', 'allah');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
