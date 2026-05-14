using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 30f; // Darah musuh, bisa Anda ubah nanti di Inspector

    void Update()
    {
        // Jika darah habis, hancurkan objek ini
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}