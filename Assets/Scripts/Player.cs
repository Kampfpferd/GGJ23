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
    public Animator Anim;
    public SpriteRenderer Render;
    public AudioSource Run;
    public AudioSource earthleft;
    public AudioSource earthright;
    public bool wurzelnschlagen=false;
   
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
        if (Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.D))
        {
            Anim.SetBool("Running",true);
            Run.enabled = true;
        }
        else
        {
            Anim.SetBool("Running", false);
            Run.enabled = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Render.flipX = true;
            earthleft.enabled = false;
            earthright.enabled = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Render.flipX = false;
            earthleft.enabled = true;
            earthright.enabled = false;
        }
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
        if (collision.gameObject.tag=="Tree1" && wurzelnschlagen == false)
        {
            wurzelnschlagen = true;
            CameraSwitcher.SwitchCamera(Tree1);
            Debug.Log("Tree1");
            LVL1 = true;
            start = true;
            
        }
        if (collision.gameObject.tag == "Tree2" && wurzelnschlagen == false)
        {
            wurzelnschlagen = true;
            CameraSwitcher.SwitchCamera(Tree2);
            Debug.Log("Tree1");
            LVL2 = true;
            start = true;
           
        }
        if (collision.gameObject.tag == "Tree3" && wurzelnschlagen == false)
        {
            wurzelnschlagen = true;
            CameraSwitcher.SwitchCamera(Tree3);
            Debug.Log("Tree1");
            LVL3 = true;
            start = true;
           
        }

    }
}
