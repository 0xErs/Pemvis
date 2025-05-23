### Tugas 3 Pemrograman Visual 

# 🌍 SelLand - Aplikasi Penjualan Tanah

**SelLand** adalah aplikasi desktop berbasis Windows Forms (WinForms) yang dibuat menggunakan Visual Studio dan MySQL. Aplikasi ini bertujuan untuk mempermudah proses pendataan, pengelolaan, dan penjualan tanah. Proyek ini dikembangkan sebagai tugas akhir mata kuliah **Pemrograman Visual**.

## ✨ Fitur Utama

- **🔐 Login Sistem**
  - Verifikasi pengguna menggunakan data dari tabel `login`.

- **📊 Dashboard Utama**
  - Tampilan utama setelah login untuk mengakses fitur aplikasi.

- **📁 Manajemen Data Tanah**
  - Tambah, edit, dan hapus data tanah.
  - Data tersimpan di tabel `tanah`.

- **👤 Manajemen User**
  - Kelola data pengguna aplikasi dari tabel `user`.

- **📄 Halaman Daftar Penjualan**
  - Menampilkan daftar tanah yang sudah dijual atau dalam proses transaksi.
  - Data berasal dari tabel `daftar`.

## 🛠️ Teknologi yang Digunakan

- Bahasa Pemrograman: **C# (Windows Forms)**
- Basis Data: **MySQL**
- IDE: **Visual Studio**

## 🗃️ Struktur Tabel Database

1. **`login`** – Menyimpan username dan password pengguna.
2. **`tanah`** – Menyimpan informasi tanah seperti lokasi, luas, dan harga.
3. **`user`** – Menyimpan informasi pengguna (admin/operator).
4. **`daftar`** – Menyimpan data transaksi atau daftar tanah terjual.
