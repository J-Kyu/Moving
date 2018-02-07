using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {
    public float speed=3.0f;
    public GameObject enemy;
    public DirPad dirpad;
    // Use this for initialization
    void Start () {
        enemy = GameObject.Find("CapsuleEnemy");
	}
	
	// Update is called once per frame
	void Update () {

        if (dirpad.dragging)
        {
            var dn = dirpad.dir.normalized * Time.deltaTime * speed;
            transform.Translate(new Vector3(dn.x, 0, dn.y));
        }

        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(h * Time.deltaTime * speed, 0.0f, v * Time.deltaTime * speed));
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other == enemy)
        {
            DestroyImmediate(enemy);
        }
    }
}
