using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSrc;

    public void PlayChomp()
    {
        audioSrc.Play(0);
    }
}
