using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class UserInput : MonoBehaviour
{
    public bool clickable;
    public float timer;
    public float oriClickTimer = 4.0f;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = FindObjectOfType<Animator>();
        // Start clickable with true
        clickable = true;
        // Set timer to original timer
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // timer is more than 0
        if (timer > 0)
        {
            // decrease timer
            timer -= Time.deltaTime;
            // clickable is false
            clickable = false;

        // time is less than 0
        } else {
            // clickable change to true
            clickable = true;
        }

        // if clickable is true
        if (clickable)
        {
            // call touch function 
            GetMouseClick();
        }
    }

    void GetMouseClick(){

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, Mathf.Infinity);
            if (hit.collider != null)
            {
                // reset timer 
                timer = oriClickTimer;

                if (hit.collider.tag == "cat")
                {
                    Debug.Log("hit cat");
                    FindObjectOfType<AudioManager>().Play("cat_sound");
                    // anim.SetTrigger("start_tilt");
                    
                }
                else if (hit.collider.tag == "dog")
                {
                    Debug.Log("hit dog");
                    FindObjectOfType<AudioManager>().Play("dog_sound");
                    // anim.SetTrigger("start_tilt");
                }
                else if (hit.collider.tag == "owl")
                {
                    Debug.Log("hit owl");
                    FindObjectOfType<AudioManager>().Play("owl_sound");
                }
                else if (hit.collider.tag == "frog")
                {
                    Debug.Log("hit frog");
                    FindObjectOfType<AudioManager>().Play("frog_sound");
                }
                else if (hit.collider.tag == "lion")
                {
                    Debug.Log("hit lion");
                    FindObjectOfType<AudioManager>().Play("lion_sound");
                }
                else if (hit.collider.tag == "pig")
                {
                    Debug.Log("hit pig");
                    FindObjectOfType<AudioManager>().Play("pig_sound");
                }
            }
        }
    }
}