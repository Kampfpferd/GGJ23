using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class Player : MonoBehaviour
{
    public CinemachineVirtualCamera Near;
    public CinemachineVirtualCamera Far;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        CameraSwitcher.Register(Near);
        CameraSwitcher.Register(Far);
        CameraSwitcher.SwitchCamera(Far);
    }

    private void OnDisable()
    {
        CameraSwitcher.Unregister(Near);
        CameraSwitcher.Unregister(Far);
       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Tree1")
        {
            if (CameraSwitcher.IsActiveCamera(Far))
            {
                CameraSwitcher.SwitchCamera(Near);
            }
            else if (CameraSwitcher.IsActiveCamera(Near))
            {
                CameraSwitcher.SwitchCamera(Far);
            }
           
            Debug.Log("Finish");
        }
    }
}
