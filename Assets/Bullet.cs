using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage;
    public float lifeTime = 5f;

    void Update()
    {
        lifeTime -= Time.deltaTime;

        if (lifeTime < 0)
        {
            Destroy(gameObject);
        }
    }

    // Fungsi ini terpanggil otomatis ketika peluru menabrak sesuatu
    private void OnTriggerEnter(Collider other)
    {
        // SEKARANG PELURU MENCARI SCRIPT "EnemyAI", BUKAN "Enemy" LAGI
        if (other.GetComponent<EnemyAI>() != null)
        {
            // Mengurangi darah monster
            other.GetComponent<EnemyAI>().health -= damage;

            // Menghancurkan peluru agar tidak tembus terus
            Destroy(gameObject);
        }
    }
}