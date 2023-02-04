using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootSpawn : MonoBehaviour
{
    public GameObject Root;
    public GameObject NewObject;
    float timepassed;
    float lastY;
    float lastSpawnY;
    public Transform parent;
   
    // Start is called before the first frame update
    void Start()
    {
        
        NewObject=Instantiate(Root, new Vector3(transform.position.x, transform.position.y,0), transform.rotation)as GameObject;
        NewObject.transform.parent = GameObject.Find("World").transform;
        lastSpawnY = transform.position.y;
        
    }

    // Update is called once per frame
    void Update()
    {
        // timepassed += Time.deltaTime;
        //if (timepassed >=2)
        //{

        NewObject = Instantiate(Root, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation) as GameObject;
        NewObject.transform.parent = GameObject.Find("World").transform;
        lastSpawnY = transform.position.y;
       
           //NewObject = Instantiate(Root, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
         //   timepassed = 0;
       // }
        
    }
}
