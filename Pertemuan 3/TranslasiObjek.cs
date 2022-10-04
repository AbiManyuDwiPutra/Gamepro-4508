using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslasiObjek : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 kekanan;
    Vector3 kekiri;
    Vector3 keatas;
    Vector3 kebawah;
    void Start()
    {
        kekanan = new Vector3(1,0,0);
        kekiri = new Vector3(-1,0,0);
        keatas = new Vector3(0,1,0);
        kebawah = new Vector3(0,-1,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (kebawah * 2f * Time.deltaTime);
        Debug.Log(kekanan+" "+kekiri+" "+keatas+" "+kebawah);
        
    }
}
