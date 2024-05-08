using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScenes : MonoBehaviour
{
    public int scene;
    void Start()
    {
        scene = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
    
    }
     public void OnClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(scene);
    }
}
