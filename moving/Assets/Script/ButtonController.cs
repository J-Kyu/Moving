using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour {
public void OpenMainScene()
    {
        SceneManager.LoadScene("Main");
    }

    public void BackToSplashScene()
    {
        SceneManager.LoadScene("Splash");
    }
}
