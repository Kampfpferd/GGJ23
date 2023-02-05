using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class RootSpawn : MonoBehaviour
{
    public GameObject Root;
    public GameObject NewObject;
    public GameObject Root1;
    public GameObject Root2;
    public GameObject Root3;
    float timepassed;
    float lastY;
    float lastSpawnY;
    public Transform parent;

    public CinemachineVirtualCamera Tree1;
    public CinemachineVirtualCamera Tree2;
    public CinemachineVirtualCamera Tree3;
    public CinemachineVirtualCamera Far;
    public CinemachineVirtualCamera Bunny;
    public Player playerscript;
    public AudioSource Roots1;

    // Start is called before the first frame update
    private void OnEnable()
    {
        CameraSwitcher.Register(Tree1);
        CameraSwitcher.Register(Tree2);
        CameraSwitcher.Register(Tree3);
        CameraSwitcher.Register(Far);
        CameraSwitcher.SwitchCamera(Bunny);
    }

    private void OnDisable()
    {
        CameraSwitcher.Unregister(Tree1);
        CameraSwitcher.Unregister(Tree2);
        CameraSwitcher.Unregister(Tree3);
        CameraSwitcher.Unregister(Far);
        CameraSwitcher.Unregister(Bunny);

    }


    void Start()
    {
        GameObject player = GameObject.Find("Player");
        playerscript = player.GetComponent<Player>();
        
       // NewObject=Instantiate(Root, new Vector3(transform.position.x, transform.position.y,0), transform.rotation)as GameObject;
        //NewObject.transform.parent = GameObject.Find("World").transform;
        //lastSpawnY = transform.position.y;
        
    }

    // Update is called once per frame
    void Update()
    {

        // timepassed += Time.deltaTime;
        //if (timepassed >=2)
        //{
        
       if (playerscript.LVL1)
        {
            Roots1.enabled = true;
            Debug.Log(transform.position.x);
            Debug.Log(transform.position.y);

            CameraSwitcher.SwitchCamera(Tree1);
            Root1 = Instantiate(Root, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation) as GameObject;
            Root1.transform.parent = GameObject.Find("World").transform;
            lastSpawnY = transform.position.y;
        }
        else
        {
            Roots1.enabled = false;
        }
       
        
       
           //NewObject = Instantiate(Root, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
         //   timepassed = 0;
       // }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Finish")
        {
            Roots1.enabled = false;
            playerscript.Score += 1;
            Destroy(this);
            if (playerscript.Score == 3)
            {
                CameraSwitcher.SwitchCamera(Far);
            }
            else
            {
                CameraSwitcher.SwitchCamera(Bunny);
            }
            Debug.Log("Finish");
        }
    }

}
