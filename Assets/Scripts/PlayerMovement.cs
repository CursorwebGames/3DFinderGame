using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody player;

    private void FixedUpdate()
    {
        Vector3 movevect = Vector3.forward;
        player.velocity = transform.TransformDirection(movevect) * Time.fixedDeltaTime * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Tree"))
        {
            enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
