using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    void Update()
    {
        // Membuat bola imajiner di bawah kaki untuk mengecek apakah menyentuh layer "Grounded"
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; // Menjaga karakter tetap menapak stabil di tanah
        }

        // Membaca input keyboard (W, A, S, D atau Panah)
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // Menggerakkan karakter berdasarkan arah hadapnya
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        // Melompat
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        // Menarik karakter ke bawah (Simulasi Gravitasi)
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}