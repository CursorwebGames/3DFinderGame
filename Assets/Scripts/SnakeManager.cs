using UnityEngine;

public class SnakeManager : MonoBehaviour
{
    public GameObject segment; // prefab
    public Transform snakeHead; // head

    public float tick;
    public float maxTick;


    public void DrawSegment()
    {
        GameObject seg = Instantiate(segment, snakeHead.transform.position, Quaternion.identity);
        SegmentManager props = seg.GetComponent<SegmentManager>();
        props.follower = snakeHead;
        snakeHead = seg.transform;
    }
}
