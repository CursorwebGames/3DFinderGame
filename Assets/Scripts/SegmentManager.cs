using UnityEngine;

public class SegmentManager : MonoBehaviour
{
    public float speed = 200;
    public Transform follower;
    public Rigidbody rb;

    private void FixedUpdate()
    {
        Vector3 direction = follower.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.up);
        rb.rotation *= rotation;
        rb.velocity = direction * speed;
    }
}
