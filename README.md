# **🌌 Sci-Fi FPS Survival**

Sebuah purwarupa (*prototype*) game First-Person Shooter (FPS) bertema fiksi ilmiah (Sci-Fi) yang dikembangkan menggunakan Unity Engine. Pemain harus bertahan hidup dari gelombang serangan monster alien (Slime & Turtle Shell) di sebuah planet asing menggunakan senapan laser.

Fitur utama dalam proyek ini meliputi:

* Pergerakan *First-Person* dengan sistem gravitasi dan lompatan yang mulus.  
* Sistem *shooting* dengan proyektil peluru berbasis fisika (*Rigidbody*).  
* *Enemy Spawner* dinamis yang memunculkan musuh secara acak di sekitar pemain.  
* Lingkungan planet alien *low-poly* dengan pencahayaan URP (Universal Render Pipeline).

## **📋 Persyaratan Sistem (Prerequisites)**

Sebelum membuka proyek ini, pastikan komputer/laptop Anda sudah terinstal:

1. **Unity Hub** (Disarankan versi terbaru).  
2. **Unity Editor** (Pastikan menggunakan versi yang mendukung **URP**). Jika saat proyek dibuka Unity meminta persetujuan instalasi versi yang tepat, silakan ikuti petunjuk dari Unity Hub.  
3. **Git** (Untuk melakukan *cloning* repositori).

## **🛠️ Cara Instalasi & Membuka Proyek**

Proyek ini tidak menyimpan file sementara (seperti folder Library) di GitHub untuk menghemat ruang. Oleh karena itu, ikuti langkah-langkah ini dengan cermat untuk membuka proyek pertama kali:

### **1\. Unduh Proyek (Clone Repository)**

Buka terminal Anda (Command Prompt / Fish / Bash) dan jalankan perintah berikut di folder tempat Anda ingin menyimpan proyek:

git clone https://github.com/belpythons/unity-test-fps.git

### **2\. Tambahkan Proyek ke Unity Hub**

1. Buka aplikasi **Unity Hub**.  
2. Di menu sebelah kiri, pastikan Anda berada di tab **Projects**.  
3. Klik tombol **Add** (atau ikon panah ke bawah di sebelah *Open* lalu pilih *Add project from disk*).  
4. Arahkan *file explorer* Anda ke folder proyek yang baru saja di-*clone*, lalu klik **Add Project** / **Select Folder**.

### **3\. Buka Proyek di Editor**

1. Proyek sekarang akan muncul di daftar Unity Hub Anda.  
2. Klik nama proyek tersebut untuk membukanya.  
3. **Catatan Penting:** Pada proses pembukaan pertama kali, Unity akan memakan waktu lumayan lama (bisa 2-10 menit tergantung spesifikasi laptop) karena Unity harus mengunduh *package* dan membangun ulang folder Library secara lokal. Biarkan proses *loading bar* selesai.

## **🎮 Cara Menjalankan Game (Scene Utama)**

Setelah antarmuka Unity Editor terbuka, Anda mungkin akan melihat layar kosong atau jendela *scene* yang berbeda. Untuk masuk ke dalam arena permainan:

1. Perhatikan panel **Project** di bagian bawah layar.  
2. Navigasikan ke dalam direktori berikut: Assets ➔ Scenes.  
3. Cari file bernama **FPS** (ikonnya berbentuk logo Unity/kubus).  
4. **Klik ganda (Double-click)** file FPS tersebut.  
5. Jendela *Hierarchy* di sebelah kiri sekarang akan terisi dengan FirstPersonPlayer, Terrain, EnemySpawner, dan aset lainnya.  
6. Tekan tombol **▶ Play** di bagian tengah atas layar Editor untuk mulai bermain\!

## **🕹️ Kontrol Permainan (Controls)**

Saat berada di dalam mode *Play*, klik kiri satu kali di area game agar *mouse* Anda terkunci ke dalam layar, lalu gunakan kontrol berikut:

| Tombol / Aksi | Fungsi |
| :---- | :---- |
| **W, A, S, D** | Berjalan maju, mundur, ke kiri, dan ke kanan. |
| **Mouse / Trackpad** | Menengok dan mengarahkan pandangan/senjata (Look). |
| **Klik Kiri (Left Click)** | Menembakkan peluru (Bisa diklik atau ditahan tergantung mode senjata). |
| **Spasi (Spacebar)** | Melompat (*Jump*). |
| **ESC (Escape)** | Melepaskan kursor *mouse* dari layar untuk menghentikan mode Play. |

## **📁 Struktur Folder Penting (Untuk Developer)**

Jika Anda ingin memodifikasi atau berkontribusi pada proyek ini, berikut adalah lokasi file-file krusial:

* Assets/PlayerShoot.cs & Assets/PlayerMovement.cs : Skrip utama untuk mekanik pergerakan dan tembakan pemain.  
* Assets/EnemySpawner.cs : Logika *spawner* musuh dinamis.  
* Assets/PeluruAsli.prefab : *Wrapper prefab* yang memperbaiki masalah rotasi pada aset 3D peluru.  
* Assets/RPG Monster DUO PBR Polyart/ : Folder aset berisi model 3D, animasi, dan AI untuk Slime & TurtleShell.

*Dibuat untuk keperluan riset & pengembangan Game FPS.*

