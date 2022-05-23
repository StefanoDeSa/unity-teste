using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int vel, str;
    [SerializeField] private Animator an;
    [SerializeField] private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3(0f,0f,0f);
       if (Input.GetKey(KeyCode.A)){
           pos.x = -1f;
           an.SetBool("running", true);
           transform.eulerAngles = new Vector3(0f,180f,0f);
       }
       if (Input.GetKeyDown(KeyCode.F)){
           rb.AddForce(new Vector3(0f,1f,0f)*str,ForceMode2D.Impulse);
       }
       if (Input.GetKey(KeyCode.D)){
           an.SetBool("running", true);
           pos.x = 1f;
           transform.eulerAngles = new Vector3(0f,0f,0f);
       }

       if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)){
            an.SetBool("running", false);
            pos.x = 0f;
       }
           
        transform.position += pos*vel*Time.deltaTime;
    }
}
