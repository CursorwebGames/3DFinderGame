using UnityEngine;

public class AppleBehavior : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tree"))
        {
            transform.position = new Vector3(Random.Range(-20, 20), 1, Random.Range(-20, 20));
        }
        else if (other.CompareTag("Player"))
        {
            GameManager gameManager = FindObjectOfType<GameManager>();
            gameManager.score++;
            gameManager.UpdateText();

            FindObjectOfType<SnakeManager>().DrawSegment();
            FindObjectOfType<AudioManager>().PlayChomp();

            Destroy(gameObject);
        }
    }
}
