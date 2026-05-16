using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("Pengaturan Spam")]
    // Tanda kurung siku [] mengubah variabel menjadi Array (bisa banyak slot)
    public GameObject[] enemyPrefabs; 
    public int maxEnemies = 15;
    public float spawnInterval = 0.2f;

    private float nextSpawnTime;

    void Update()
    {
        // Menghitung jumlah monster di arena
        int currentEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if (currentEnemies < maxEnemies && Time.time >= nextSpawnTime)
        {
            Vector3 randomOffset = new Vector3(Random.Range(-5f, 5f), 0f, Random.Range(-5f, 5f));
            Vector3 spawnPosition = transform.position + randomOffset;

            // Memilih indeks acak dari slot 0 sampai batas maksimal slot yang Anda isi
            int randomIndex = Random.Range(0, enemyPrefabs.Length);
            GameObject selectedMonster = enemyPrefabs[randomIndex];

            Instantiate(selectedMonster, spawnPosition, Quaternion.identity);

            nextSpawnTime = Time.time + spawnInterval;
        }
    }
}