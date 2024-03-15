using UnityEngine;

public class SceneAudioPlayer : MonoBehaviour
{
    public AudioClip audioClip;

    private AudioSource audioSource;

    private void Start()
    {
        if (GetComponent<AudioSource>() == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        else
        {
            audioSource = GetComponent<AudioSource>();
        }

        audioSource.clip = audioClip;

        // Play the audio clip
        audioSource.Play();
    }
}
