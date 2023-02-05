using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class RootSpawnRoot_LVL2 : MonoBehaviour
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

    public CinemachineVirtualCamera Near;
    public CinemachineVirtualCamera Far;
    public CinemachineVirtualCamera Bunny;
    public Player playerscript;

    // Start is called before the first frame update
    private void OnEnable()
    {
        CameraSwitcher.Register(Near);
        CameraSwitcher.Register(Far);
        CameraSwitcher.SwitchCamera(Bunny);
    }

    private void OnDisable()
    {
        CameraSwitcher.Unregister(Near);
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

        if (playerscript.LVL2)
        {
            Debug.Log(transform.position.x);
            Debug.Log(transform.position.y);

            CameraSwitcher.SwitchCamera(Near);
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
            Destroy(this);
            CameraSwitcher.SwitchCamera(Bunny);
            Debug.Log("Finish");
        }
    }

}
