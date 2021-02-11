using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontroller : MonoBehaviour
{
    GameObject body;
    public float camHeight;
    // Start is called before the first frame update
    void Start()
    {
        body = GameObject.Find("body");

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(body.transform.position.x, body.transform.position.y, -10);
    }
}
