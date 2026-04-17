-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 17 Apr 2026 pada 13.24
-- Versi server: 10.4.32-MariaDB
-- Versi PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbfreediver`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbpeminjaman`
--

CREATE TABLE `tbpeminjaman` (
  `idPinjam` int(11) NOT NULL,
  `idPeralatan` int(11) NOT NULL,
  `namaPeminjam` varchar(100) NOT NULL,
  `tanggalPinjam` date NOT NULL,
  `tanggalKembali` date NOT NULL,
  `statusKembali` varchar(20) NOT NULL,
  `keterangan` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbperalatan`
--

CREATE TABLE `tbperalatan` (
  `id` int(11) NOT NULL,
  `namaAlat` varchar(100) NOT NULL,
  `kategori` varchar(50) NOT NULL,
  `kondisi` varchar(20) NOT NULL,
  `tanggalMasuk` date NOT NULL,
  `stok` int(5) NOT NULL,
  `keterangan` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbpeminjaman`
--
ALTER TABLE `tbpeminjaman`
  ADD PRIMARY KEY (`idPinjam`),
  ADD KEY `fk_peralatan` (`idPeralatan`);

--
-- Indeks untuk tabel `tbperalatan`
--
ALTER TABLE `tbperalatan`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `tbpeminjaman`
--
ALTER TABLE `tbpeminjaman`
  MODIFY `idPinjam` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT untuk tabel `tbperalatan`
--
ALTER TABLE `tbperalatan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `tbpeminjaman`
--
ALTER TABLE `tbpeminjaman`
  ADD CONSTRAINT `fk_peralatan` FOREIGN KEY (`idPeralatan`) REFERENCES `tbperalatan` (`id`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
