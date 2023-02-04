using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour
{
    public float growSpeed = 2f;
    Vector3 GrowDirection;
    float lastpos;
    public GameObject test;
    // Start is called before the first frame update
    void Start()
    {
       // test = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
       // test.transform.position = transform.position;
        //GrowDirection = Vector3.down;
        //transform.position = transform.position + GrowDirection * growSpeed * Time.deltaTime;
        //Debug.Log(test.transform.position);
    }
}
