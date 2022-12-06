-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 01 Des 2022 pada 09.48
-- Versi server: 10.4.24-MariaDB
-- Versi PHP: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `perpustakaan`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `koleksi`
--

CREATE TABLE `koleksi` (
  `id_koleksi` int(10) UNSIGNED NOT NULL,
  `nama_koleksi` varchar(255) NOT NULL DEFAULT '0',
  `dir_gambar` text NOT NULL,
  `deskripsi` longtext NOT NULL,
  `penerbit` varchar(255) NOT NULL DEFAULT '0',
  `jenis_koleksi` varchar(255) NOT NULL DEFAULT '0',
  `tahun_terbit` year(4) NOT NULL,
  `lokasi` varchar(255) NOT NULL DEFAULT '0',
  `tgl_masuk` date NOT NULL,
  `stock` int(11) NOT NULL DEFAULT 0,
  `bahasa` varchar(50) NOT NULL DEFAULT '0',
  `kategori` varchar(50) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `koleksi`
--

INSERT INTO `koleksi` (`id_koleksi`, `nama_koleksi`, `dir_gambar`, `deskripsi`, `penerbit`, `jenis_koleksi`, `tahun_terbit`, `lokasi`, `tgl_masuk`, `stock`, `bahasa`, `kategori`) VALUES
(5, 'g', 'C:/Users/hp/Downloads/metnum.jpeg', 'a', 'a', 'Publikasi Penelitian', 2001, 'a', '2022-12-01', 2, 'Indonesia', 'Sains|Sosial|'),
(8, 'e', 'C:/Users/hp/Downloads/printer.png', 'b', 'b', 'Majalah', 2003, '2ad', '2022-12-01', 3, 'Indonesia', 'Sains|Sosial|'),
(9, 'd', 'C:/Users/hp/Downloads/download (4).png', 'aaa', 'aaa', 'Majalah', 2004, 'awddw', '2022-12-01', 5, 'Bahasa Indonesia', 'Sains|Sosial|');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `koleksi`
--
ALTER TABLE `koleksi`
  ADD PRIMARY KEY (`id_koleksi`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `koleksi`
--
ALTER TABLE `koleksi`
  MODIFY `id_koleksi` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
