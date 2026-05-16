using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [Header("Status Musuh")]
    public float health = 30f;

    [Header("Pengaturan Lompatan")]
    public float jumpForce = 5f; // Kekuatan melompat ke atas
    public float forwardForce = 4f; // Kekuatan menerjang ke depan
    public float jumpInterval = 2f; // Jeda waktu antar lompatan

    private Transform player;
    private Rigidbody rb;
    private float jumpTimer;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // AI akan otomatis mencari objek dengan nama "FirstPersonPlayer" di arena
        player = GameObject.Find("FirstPersonPlayer").transform;
        jumpTimer = jumpInterval; // Set waktu awal
    }

    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            return;
        }

        // Memaksa monster agar selalu memutar badannya menatap pemain
        Vector3 lookPosition = new Vector3(player.position.x, transform.position.y, player.position.z);
        transform.LookAt(lookPosition);

        // Menghitung mundur waktu untuk melompat
        jumpTimer -= Time.deltaTime;
        if (jumpTimer <= 0)
        {
            JumpAtPlayer();
            jumpTimer = jumpInterval;
        }
    }

    void JumpAtPlayer()
    {
        // Memberikan daya dorong ke atas dan ke depan sekaligus
        rb.AddForce(Vector3.up * jumpForce + transform.forward * forwardForce, ForceMode.Impulse);
    }
}