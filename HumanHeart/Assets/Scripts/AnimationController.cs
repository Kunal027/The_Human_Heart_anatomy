using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AnimationController : MonoBehaviour
{
    public GameObject part1_button;

    public GameObject part1_window;

    Animation part1_window_animation;
    void Start()
    {
        part1_window_animation = part1_window.GetComponent<Animation>();
    }

    public void part1_button_clicked() 
    {
        part1_window_animation["part1_window_anim"].speed = 1;
        part1_window_animation.Play();
    }

    public void close_button_clicked()
    {
        string button_name = EventSystem.current.currentSelectedGameObject.name;
        if( button_name ==  "Part 1_Close_button")
        {
            part1_window_animation["part1_window_anim"].speed = -1;
        }
    }
}
