using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public bool isPlaying = true;
    public GameObject warningTree;
    public GameObject endScreen;
    public Text userText;

    public float tick = 0;
    public float spawnTreeTick = 5;

    private void Start()
    {
        UpdateText();
    }

    private void Update()
    {
        if (isPlaying) Cursor.lockState = CursorLockMode.Locked;
        else Cursor.lockState = CursorLockMode.None;

        if (!isPlaying) return;
        tick += Time.deltaTime;
        if (tick >= spawnTreeTick)
        {
            CreateTree();
            tick = 0;
            if (spawnTreeTick > 3) spawnTreeTick -= 0.1f;
        }
    }

    public void UpdateText()
    {
        userText.text = string.Format("{0:#,##0.##}", score);
    }

    public void CreateTree()
    {
        Instantiate(warningTree, new Vector3(Random.Range(-20, 20), 4, Random.Range(-20, 20)), Quaternion.identity);
    }

    public void GameOver()
    {
        endScreen.SetActive(true);
        isPlaying = false;
    }
}
