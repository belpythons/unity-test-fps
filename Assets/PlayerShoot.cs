using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [Header("Pengaturan Peluru")]
    public float bulletSpeed = 50f;
    public float fireRate = 0.5f;
    public float bulletDamage = 10f;

    [Header("Referensi Objek")]
    public Transform bulletSpawnTransform;
    public GameObject bulletPrefab;

    private float timer;

    void Update()
    {
        // Penghitung waktu jeda antar tembakan
        if (timer > 0)
        {
            timer -= Time.deltaTime / fireRate;
        }

        // Fire1 adalah tombol Klik Kiri pada mouse
        if (Input.GetButtonDown("Fire1") && timer <= 0)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // 1. Memunculkan peluru di posisi ujung senjata
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnTransform.position, Quaternion.identity);

        // 2. Mendorong peluru ke depan
        bullet.GetComponent<Rigidbody>().AddForce(bulletSpawnTransform.forward * bulletSpeed, ForceMode.Impulse);

        // 3. Mengatur seberapa besar damage peluru tersebut
        bullet.GetComponent<Bullet>().damage = bulletDamage;

        // 4. Mereset jeda tembakan
        timer = 1;
    }
}