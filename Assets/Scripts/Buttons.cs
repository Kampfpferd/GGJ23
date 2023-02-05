using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void LoadLevel()
    {
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void LoadMenu()
    {
        
        SceneManager.LoadScene(0);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }

    //Delay für Gameplay to Credits

    public void Winner()
    {
        Invoke("LoadCredits", 3f);
    }

    public void LoadCredits()
    {
        SceneManager.LoadScene(2);
    }
}
