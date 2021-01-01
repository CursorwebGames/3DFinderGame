using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    public GameObject tree;
    public float tick;
    public float spawnTreeTick;

    private void Update()
    {
        tick += Time.deltaTime;
        if (tick >= spawnTreeTick)
        {
            Instantiate(tree, transform.position - new Vector3(0, 0.5f, 0), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
