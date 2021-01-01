using UnityEngine;

public class HeadManager : MonoBehaviour
{
    public Behaviour parent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Body"))
        {
            enabled = false;
            parent.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
