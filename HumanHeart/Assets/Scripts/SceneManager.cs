﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void load_the_Index_scene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
    public void load_Learning_scene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void load_visualization_scene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
    
   
    public void QuitApplication()
    {
        Application.Quit();
    }
}

