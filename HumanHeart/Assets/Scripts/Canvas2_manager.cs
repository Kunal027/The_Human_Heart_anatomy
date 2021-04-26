using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas2_manager : MonoBehaviour
{

    public GameObject world_Space_Canvas;

    public GameObject aboutButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void deactivate_about_button()
    {
        aboutButton.SetActive(false);
    }
    public void deactivate_WorldSpace_Canvas()
    {
        world_Space_Canvas.SetActive(false);
    }
}
