using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    // Membuat pilihan dropdown di Inspector
    public enum FireMode { SemiAuto, Auto }

    [Header("Pengaturan Senjata")]
    public FireMode fireMode; // Mode tembakan
    public float bulletSpeed = 50f;
    public float fireRate = 0.2f; // Dipercepat agar mode auto terasa
    public float bulletDamage = 10f;

    [Header("Referensi Objek")]
    public Transform bulletSpawnTransform;
    public GameObject bulletPrefab;

    private float timer;

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }

        bool isShooting = false;

        // Mengecek mode tembakan
        if (fireMode == FireMode.SemiAuto)
        {
            isShooting = Input.GetButtonDown("Fire1"); // Harus diklik berkali-kali
        }
        else if (fireMode == FireMode.Auto)
        {
            isShooting = Input.GetButton("Fire1"); // Bisa ditahan
        }

        // Jika pemain menembak dan waktu jeda sudah habis
        if (isShooting && timer <= 0)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnTransform.position, bulletSpawnTransform.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(bulletSpawnTransform.forward * bulletSpeed, ForceMode.Impulse);
        bullet.GetComponent<Bullet>().damage = bulletDamage;

        timer = fireRate; // Reset timer berdasarkan fire rate
    }
}