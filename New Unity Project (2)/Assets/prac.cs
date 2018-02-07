using UnityEngine;

public class prac : MonoBehaviour
{

    Rigidbody rb;
    public float forceMag = 2;      //force magnitude

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        var dx = Input.GetAxis("Horizontal");
        var dz = Input.GetAxis("Vertical");
        var inputDir = new Vector3(dx, 0, dz).normalized;
        //rb.AddForce(new Vector3(dx, 0, dz)*forceMag);
        rb.velocity = new Vector3(inputDir.x*forceMag, rb.velocity.y, inputDir.z*forceMag);
        
        Debug.LogFormat("Veloctiy: {0}", rb.velocity.magnitude);

    }
}
