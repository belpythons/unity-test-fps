using UnityEngine;
public class PergerakanPemain : MonoBehaviour
{
    public float speedPosition = 3.1f;
    public float jumpforce = 3.14f;
    Rigidbody yy;
    private bool canJump = false;
    void Start()
    {
        yy = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKey("right"))
        {
            transform.position += Vector3.right * speedPosition * Time.deltaTime;
        }
        if (Input.GetKey("left"))
        {
            transform.position += Vector3.left * speedPosition * Time.deltaTime;
        }
        if (Input.GetKey("up"))
        {
            transform.position += transform.forward * speedPosition * Time.deltaTime;
        }
        if (Input.GetKey("down"))
        {
            transform.position += -transform.forward * speedPosition * Time.deltaTime;
        }
        if (Input.GetKey("space") && canJump)
        {
            yy.AddForce(0, jumpforce, 0);
            canJump = false;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Alas")
        {
            canJump = true;
        }
    }
}