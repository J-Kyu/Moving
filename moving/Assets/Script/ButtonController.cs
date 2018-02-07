using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour {
    public AudioSource audioSource;



    public void OpenMainScene()
    {
        SceneManager.LoadScene("Main");
    }

    public void BackToSplashScene()
    {
        SceneManager.LoadScene("Splash");
    }

    public void PlaySound()
    {
        audioSource.Play();
        Debug.LogFormat("wow");
    }
}
