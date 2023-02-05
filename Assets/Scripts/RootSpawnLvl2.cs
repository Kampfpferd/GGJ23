using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class RootSpawnLvl2 : MonoBehaviour
{
    public GameObject Root;
    public GameObject NewObject;
    public GameObject Root1;
    public GameObject Tree22;
    public GameObject Root3;
    float timepassed;
    float lastY;
    float lastSpawnY;
    int einmal = 1;
    public Transform parent;

    public CinemachineVirtualCamera Tree1;
    public CinemachineVirtualCamera Tree2;
    public CinemachineVirtualCamera Tree3;
    public CinemachineVirtualCamera Far;
    public CinemachineVirtualCamera Bunny;
    public Player playerscript;

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
        if (playerscript.LVL2 && playerscript.start)
        {
            float Drehung;
            Drehung = transform.position.y;
            transform.position = Tree22.transform.position;
            playerscript.start = false;
        }
       

        // timepassed += Time.deltaTime;
        //if (timepassed >=2)
        //{

        if (playerscript.LVL2)
        {
            Debug.Log(transform.position.x);
            Debug.Log(transform.position.y);

            CameraSwitcher.SwitchCamera(Tree2);
            Root1 = Instantiate(Root, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation) as GameObject;
            Root1.transform.parent = GameObject.Find("World").transform;
            lastSpawnY = transform.position.y;
        }



        //NewObject = Instantiate(Root, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
        //   timepassed = 0;
        // }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
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