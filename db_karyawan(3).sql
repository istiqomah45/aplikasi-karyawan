-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 11 Des 2019 pada 05.37
-- Versi server: 10.3.16-MariaDB
-- Versi PHP: 7.3.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_karyawan`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `absen`
--

CREATE TABLE `absen` (
  `id_absen` int(11) NOT NULL,
  `nik` varchar(20) NOT NULL,
  `jam_masuk` varchar(15) NOT NULL,
  `jam_kerja` varchar(15) NOT NULL,
  `tgl_kerja` date NOT NULL,
  `jam_pulang` varchar(15) NOT NULL,
  `telat_masuk` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `absen`
--

INSERT INTO `absen` (`id_absen`, `nik`, `jam_masuk`, `jam_kerja`, `tgl_kerja`, `jam_pulang`, `telat_masuk`) VALUES
(1, '88888', '11:01:45', '07:00:00', '0000-00-00', '2019-12-11', '11:01:45'),
(2, '92866', '11:04:05', '07:00:00', '2019-12-11', '11:04:05', '-'),
(3, '92866', '11:05:14', '07:00:00', '2019-12-11', '11:05:14', '-');

-- --------------------------------------------------------

--
-- Struktur dari tabel `gaji`
--

CREATE TABLE `gaji` (
  `id_gaji` int(11) NOT NULL,
  `nomor_slip` varchar(15) NOT NULL,
  `nik` int(20) NOT NULL,
  `tgl_gaji` date NOT NULL,
  `id_jabatan` int(2) NOT NULL,
  `nama_jabatan` varchar(40) NOT NULL,
  `gaji_pokok` decimal(8,0) NOT NULL,
  `tunjangan` decimal(8,0) NOT NULL,
  `lembur` decimal(8,0) NOT NULL,
  `pot_bpjs_kes` decimal(8,0) NOT NULL,
  `pot_bpjs_ket` decimal(8,0) NOT NULL,
  `pot_lain` decimal(8,0) NOT NULL,
  `no_rekening` varchar(40) NOT NULL,
  `nama_rekening` varchar(40) NOT NULL,
  `nama_bank` varchar(20) NOT NULL,
  `total_gaji` decimal(8,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `gaji`
--

INSERT INTO `gaji` (`id_gaji`, `nomor_slip`, `nik`, `tgl_gaji`, `id_jabatan`, `nama_jabatan`, `gaji_pokok`, `tunjangan`, `lembur`, `pot_bpjs_kes`, `pot_bpjs_ket`, `pot_lain`, `no_rekening`, `nama_rekening`, `nama_bank`, `total_gaji`) VALUES
(2, '1144', 1, '2019-11-28', 6, 'HRD', '1500000', '100000', '200000', '50000', '30000', '15000', '7764573882', 'istiqmh', 'BRI', '1705000'),
(3, 'TR191203-105536', 1, '2019-12-03', 6, 'HRD', '1500000', '100000', '150000', '100000', '100000', '50000', '76435765', 'isti', 'bri', '1500000'),
(4, 'TR191204-100419', 10808, '2019-12-04', 6, 'HRD', '1500000', '100000', '150000', '50000', '50000', '20000', '765241367937', 'istiqmh', 'BRI', '1630000'),
(5, 'TR191204-100618', 766564, '2019-12-04', 7, 'CEO', '50000000', '500000', '400000', '50000', '100000', '30000', '4565676789', 'boskoo', 'bri', '50720000'),
(6, 'TR191204-100802', 6647, '2019-12-04', 5, 'Kepala Divisi', '6000000', '100000', '100000', '50000', '50000', '10000', '0776676555', 'bosok', 'bca', '6090000'),
(7, 'TR191204-101122', 67483675, '2019-12-04', 5, 'Kepala Divisi', '6000000', '20000', '100000', '100000', '200000', '50000', '7878456799', 'irah', 'BTN', '5770000'),
(8, 'TR191204-101622', 7475643, '2019-12-04', 7, 'CEO', '50000000', '20000', '10000', '40000', '10000', '10000', '757894641', 'haha', 'BNI', '49970000');

-- --------------------------------------------------------

--
-- Struktur dari tabel `jabatan`
--

CREATE TABLE `jabatan` (
  `id_jabatan` int(2) NOT NULL,
  `nama_jabatan` varchar(40) NOT NULL,
  `gaji_pokok` decimal(8,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `jabatan`
--

INSERT INTO `jabatan` (`id_jabatan`, `nama_jabatan`, `gaji_pokok`) VALUES
(5, 'Kepala Divisi', '6000000'),
(6, 'HRD', '1500000'),
(7, 'CEO', '50000000');

-- --------------------------------------------------------

--
-- Struktur dari tabel `lembur`
--

CREATE TABLE `lembur` (
  `id_lembur` int(10) NOT NULL,
  `nik` int(20) NOT NULL,
  `nama_karyawan` varchar(45) NOT NULL,
  `id_jabatan` int(11) NOT NULL,
  `tgl_lembur` date NOT NULL,
  `jml_lembur` int(2) NOT NULL,
  `uang_lembur` decimal(8,0) NOT NULL,
  `ttl_uang_lembur` decimal(8,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `lembur`
--

INSERT INTO `lembur` (`id_lembur`, `nik`, `nama_karyawan`, `id_jabatan`, `tgl_lembur`, `jml_lembur`, `uang_lembur`, `ttl_uang_lembur`) VALUES
(1, 998237, 'isti', 6, '2019-11-26', 0, '1500000', '23000'),
(2, 1, 'IstiQomah', 5, '2019-11-28', 3, '150000', '450000'),
(3, 1, 'IstiQomah', 5, '2019-11-28', 3, '150000', '450000');

-- --------------------------------------------------------

--
-- Struktur dari tabel `t_karyawan`
--

CREATE TABLE `t_karyawan` (
  `nik` varchar(15) NOT NULL,
  `nama` varchar(30) NOT NULL,
  `tempat_lahir` varchar(20) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `agama` varchar(15) NOT NULL,
  `status` varchar(15) NOT NULL,
  `kewarganegaraan` varchar(3) NOT NULL,
  `no_hp` varchar(13) NOT NULL,
  `email` varchar(25) NOT NULL,
  `alamat` varchar(35) NOT NULL,
  `pendidikan_terakhir` varchar(4) NOT NULL,
  `pt_terakhir` varchar(40) NOT NULL,
  `jabatan` varchar(20) NOT NULL,
  `tgl_masuk` date NOT NULL,
  `bagian` varchar(20) NOT NULL,
  `status_karyawan` varchar(15) NOT NULL,
  `status_kerja` varchar(15) NOT NULL,
  `gaji` varchar(10) NOT NULL,
  `nama_gambar` varchar(200) NOT NULL,
  `lokasi_gambar` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `t_karyawan`
--

INSERT INTO `t_karyawan` (`nik`, `nama`, `tempat_lahir`, `tgl_lahir`, `agama`, `status`, `kewarganegaraan`, `no_hp`, `email`, `alamat`, `pendidikan_terakhir`, `pt_terakhir`, `jabatan`, `tgl_masuk`, `bagian`, `status_karyawan`, `status_kerja`, `gaji`, `nama_gambar`, `lokasi_gambar`) VALUES
('0001', 'IstiQomah', 'Dayu', '2000-04-05', 'Islam', 'Belum Menikah', 'WNI', '085211989097', 'iss@gmail.com', 'Jl. Warugo No. 15', 'S1', 'Universitas Airlangga', '5', '2009-02-14', 'Administrasi', '7000000', 'AKTIF', 'TETAP', '', ''),
('88888', 'jfjkhfkjd', 'yryrg', '2019-12-10', 'Islam', 'Belum Menikah', 'WNI', '78589467', 'ghsfhfkj', 'ghj', 'S2', 'yrksufhg', 'rgg', '2019-12-10', 'gfdgg', 'NONAKTIF', 'KONTRAK', '25566666', 'Androit.jpg', 'C:\\Users\\LP3I STUDENT\\Documents\\Androit.jpg'),
('92866', 'kepo ay', 'haha', '1999-12-10', 'Islam', 'Sudah Menikah', 'WNI', '879266363', 'hdhjdh', 'safdsdgh', 'S2', 'ytututu', 'CEO', '2009-12-10', 'gddhhf', 'AKTIF', 'TETAP', '20000000', 'shutterstock_295777460.jpg', 'C:\\Users\\LP3I STUDENT\\Documents\\shutterstock_295777460.jpg');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `absen`
--
ALTER TABLE `absen`
  ADD PRIMARY KEY (`id_absen`);

--
-- Indeks untuk tabel `gaji`
--
ALTER TABLE `gaji`
  ADD PRIMARY KEY (`id_gaji`);

--
-- Indeks untuk tabel `jabatan`
--
ALTER TABLE `jabatan`
  ADD PRIMARY KEY (`id_jabatan`);

--
-- Indeks untuk tabel `lembur`
--
ALTER TABLE `lembur`
  ADD PRIMARY KEY (`id_lembur`);

--
-- Indeks untuk tabel `t_karyawan`
--
ALTER TABLE `t_karyawan`
  ADD PRIMARY KEY (`nik`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `absen`
--
ALTER TABLE `absen`
  MODIFY `id_absen` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT untuk tabel `gaji`
--
ALTER TABLE `gaji`
  MODIFY `id_gaji` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT untuk tabel `jabatan`
--
ALTER TABLE `jabatan`
  MODIFY `id_jabatan` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT untuk tabel `lembur`
--
ALTER TABLE `lembur`
  MODIFY `id_lembur` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
