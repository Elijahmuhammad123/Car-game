using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    Vector3 startPos;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag =="Respawn")
        {
            rb.velocity = Vector3.zero;
            transform.position = startPos;
        }
    }
}
