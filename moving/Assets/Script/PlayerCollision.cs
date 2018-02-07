using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerHp playerHp;
  
	// Use this for initialization
	void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            playerHp.playerLastingTime=0.0f;
            playerHp.hp--;
            Destroy(other.gameObject);
        }
    }
}
