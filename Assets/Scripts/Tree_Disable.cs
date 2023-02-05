using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree_Disable : MonoBehaviour
{
    public BoxCollider2D BoxTree1;
    public BoxCollider2D BoxTree2;
    public Player playerscript;
    // public BoxCollider2D BoxTree3;
    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.Find("Player");
        playerscript = player.GetComponent<Player>();
        BoxTree1 = GetComponent<BoxCollider2D>();
        BoxTree2 = GetComponent<BoxCollider2D>();
       // BoxTree3 = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        // this.GetComponent<BoxCollider2D>().enabled = false;
        if (collision.gameObject.tag == "Player" && playerscript.wurzelnschlagen == false)
        {
            Debug.Log("BoxCol");
            BoxTree1.enabled = false;
        }
       if (collision.gameObject.tag =="Tree2")
       {
            BoxTree2.enabled = false;
        }
       if (collision.gameObject.tag=="Tree3")
        {
            //BoxTree3.enabled = false;
       }
        
    }
}

