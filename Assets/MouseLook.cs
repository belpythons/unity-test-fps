using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f; // Sensitivitas mouse 
    public Transform playerBody; // Untuk memutar badan
    float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Menyembunyikan kursor ke tengah layar 
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // Mencegah kamera berputar terbalik ke belakang 

        // Rotasi vertikal kamera (Atas-Bawah)
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // BARIS INI YANG SEBELUMNYA HILANG: Rotasi horizontal badan (Kanan-Kiri)
        playerBody.Rotate(Vector3.up * mouseX);
    }
}