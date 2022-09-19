using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cobajalan : MonoBehaviour
{
    // Start is called before the first frame update
    public float movespeed;
    int status;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + movespeed, transform.position.y);
    }
}
