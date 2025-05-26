# Tugas 9 - Refactor WinForms ke Arsitektur MVC

## Deskripsi
Project ini adalah hasil refactor dari aplikasi Windows Forms biasa menjadi menggunakan **arsitektur MVC (Model-View-Controller)**. Refactor ini bertujuan untuk meningkatkan pemisahan tanggung jawab antar komponen serta menjadikan kode lebih terstruktur dan mudah dikelola.

## Struktur MVC

- **Model** (`Model/`)
  - `User.cs` dan `Tanah.cs`: Berisi representasi data dan logika bisnis terkait entitas pengguna dan tanah.
  
- **View** (`View/`)
  - `Form1.cs` sampai `Form4.cs`: Menyediakan tampilan antarmuka pengguna berbasis WinForms.

- **Controller** (`Controller/`)
  - `UserController.cs` dan `TanahController.cs`: Menjembatani logika antara Model dan View, mengatur alur data dan aksi pengguna.

## Struktur Folder
```
Selland/
├── Controller/
│   ├── TanahController.cs
│   └── UserController.cs
├── Model/
│   ├── Tanah.cs
│   └── User.cs
├── View/
│   ├── Form1.cs
│   ├── Form2.cs
│   ├── Form3.cs
│   └── Form4.cs
├── DB.cs
└── Program.cs
```
