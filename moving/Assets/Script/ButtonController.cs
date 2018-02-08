using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour {
    public AudioSource audioSource;
    public GameObject hpPanel;
    public Text addNumberButtonText; //누르면 숫자가 증가하는 버튼 Text
    public PlayerHp playerHp;

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
       // Debug.LogFormat("wow");
    }

    public void ToggleHpPanel()         ///*in a simple way:*/ hpPanel.SetActive(hpPanel.activeSelf==false);
    {
        if (hpPanel.activeSelf)
        {
            hpPanel.SetActive(false);
        }
        else
        {
            hpPanel.SetActive(true);
        }
    }

    


   

    public void AddNumber(float finalScore)
    {
        var playerHighestHp = PlayerPrefs.GetInt("PLAYER_HIGHEST_HP", 0);
       
        
        addNumberButtonText.text = (finalScore).ToString();
        RecordSetSave(GetHighestHp());

    }

    public int GetHighestHp()
    {
        return PlayerPrefs.GetInt("PLAYER_HIGHEST_HP", 0);
    }
    public void RecordSetSave(float finalScore)
    {
        PlayerPrefs.SetFloat("PLAYER_HIGHEST_HP", finalScore);
        PlayerPrefs.Save();
    }


   
}
