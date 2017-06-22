using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour
{

    // Use this for initialization



    // Update is called once per frame
    public void FirstScene()
    {
        SceneManager.LoadScene(1);
    }
    public void SecondScene()
    {
        SceneManager.LoadScene(2);
    }
}
    

