using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class Player : MonoBehaviour
{
    public CinemachineVirtualCamera Tree1;
    public CinemachineVirtualCamera Tree2;
    public CinemachineVirtualCamera Tree3;
    public CinemachineVirtualCamera Far;
    public CinemachineVirtualCamera Bunny;
    public bool LVL1;
    public bool LVL2;
    public bool LVL3;
    public bool start;
    public int Score = 0;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        CameraSwitcher.Register(Tree1);
        CameraSwitcher.Register(Far);
        CameraSwitcher.Register(Tree2);
        CameraSwitcher.Register(Tree3);
        CameraSwitcher.SwitchCamera(Bunny);
    }

    private void OnDisable()
    {
        CameraSwitcher.Unregister(Tree1);
        CameraSwitcher.Unregister(Far);
        CameraSwitcher.Unregister(Tree2);
        CameraSwitcher.Unregister(Tree3);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            //if (CameraSwitcher.IsActiveCamera(Near))
            //{
                CameraSwitcher.SwitchCamera(Far);
            //}
            //else if (CameraSwitcher.IsActiveCamera(Far))
            //{
            //   CameraSwitcher.SwitchCamera(Near);
            //}
           
            Debug.Log("Finish");
        }
     
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Tree1")
        {
            CameraSwitcher.SwitchCamera(Tree1);
            Debug.Log("Tree1");
            LVL1 = true;
            start = true;
            
        }
        if (collision.gameObject.tag == "Tree2")
        {
            CameraSwitcher.SwitchCamera(Tree2);
            Debug.Log("Tree1");
            LVL2 = true;
            start = true;
           
        }
        if (collision.gameObject.tag == "Tree3")
        {
            CameraSwitcher.SwitchCamera(Tree3);
            Debug.Log("Tree1");
            LVL3 = true;
            start = true;
           
        }

    }
}
