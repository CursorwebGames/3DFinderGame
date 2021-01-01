using UnityEngine;
using UnityEngine.UI;

public class UserScoreManager : MonoBehaviour
{
    public GameManager gameManager;
    public Text userText;

    void Start()
    {
        userText.text = string.Format("{0:#,##0.##}", gameManager.score);
    }
}
