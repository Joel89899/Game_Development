using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {

    }
    public void QuitGame()
    {
        SceneManager.LoadScene(0);
    }
}