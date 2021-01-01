using UnityEngine;

public class FoodGenerator : MonoBehaviour
{
    public GameObject apple;

    public float tick = 0;
    public float maxTick = 3;

    private void Start()
    {
        CreateApple();
    }

    private void Update()
    {
        tick += Time.deltaTime;

        if (tick >= maxTick)
        {
            tick = 0;
            CreateApple();
        }
    }


    private void CreateApple()
    {
        Instantiate(apple, new Vector3(Random.Range(-20, 20), 1, Random.Range(-20, 20)), Quaternion.identity);
    }
}
