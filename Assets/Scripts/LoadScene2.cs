using UnityEngine;
using UnityEngine.SceneManagement;

public class VRButton : MonoBehaviour
{
    public string sceneToLoad = "YourSceneName";

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider is the hand or controller
        if (other.CompareTag("Hands"))
        {
            LoadScene();
        }
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}