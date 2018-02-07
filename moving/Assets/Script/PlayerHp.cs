using UnityEngine;
using UnityEngine.UI;

public class PlayerHp : MonoBehaviour {
    public float playerLastingTime=0.0f;
    public int hp = 10;
    public Text hpText;
    public Text timeText;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        timeText.text = playerLastingTime.ToString();
        playerLastingTime += Time.deltaTime;
		 hpText.text = hp.ToString();
        if (hp < 0)
        {
            hp = 0;
        }
        if (playerLastingTime> 10.0f)
        {   
            hp++;
            playerLastingTime=0;
        }
	}
}
