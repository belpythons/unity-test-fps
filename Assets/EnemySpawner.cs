using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("Pengaturan Spam")]
    public GameObject enemyPrefab;
    public int maxEnemies = 15;
    public float spawnInterval = 0.2f;

    private float nextSpawnTime;

    void Update()
    {
        int currentEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if (currentEnemies < maxEnemies && Time.time >= nextSpawnTime)
        {
            // Membuat koordinat acak di sekitar titik spawner agar musuh tidak bertumpuk
            Vector3 randomOffset = new Vector3(Random.Range(-5f, 5f), 0f, Random.Range(-5f, 5f));
            Vector3 spawnPosition = transform.position + randomOffset;

            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

            nextSpawnTime = Time.time + spawnInterval;
        }
    }
}