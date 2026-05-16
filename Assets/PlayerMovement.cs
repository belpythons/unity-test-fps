using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -15f; // Diperbesar agar jatuhnya lebih cepat dan realistis
    public float jumpHeight = 3f;

    [Header("Pengaturan Melompat")]
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    void Update()
    {
        // Mengecek apakah kaki karakter menyentuh tanah
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        // Berjalan
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        // MELOMPAT (Tombol Space)
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            // Rumus fisika untuk melompat
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        // Menerapkan Gravitasi
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}