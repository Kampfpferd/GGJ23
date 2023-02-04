using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldMove : MonoBehaviour
{
    Vector3 rotation;
    public float movespeed = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rotation = Vector3.back;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rotation = Vector3.forward;
        }
        else
        {
            rotation = Vector3.zero;
        }

        transform.Rotate(rotation * movespeed * Time.deltaTime);
    }
}
