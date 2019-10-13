using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject go_bluebutton, go_greenbutton, go_redbutton, go_yellowbutton;
    public Material mat_blue1, mat_blue2, mat_green1, mat_green2, mat_red1, mat_red2, mat_yellow1, mat_yellow2;
    public AudioClip aud_blue, aud_green, aud_red, aud_yellow;
    public AudioSource audioSource;

    private float fl_blueTimer, fl_greenTimer, fl_redTimer, fl_yellowTimer, fl_timer = 0.5f;
    private bool bl_lit = false;

    Renderer rend_bluebutton, rend_greenbutton, rend_redbutton, rend_yellowbutton;

    // Start is called before the first frame update
    void Start()
    {
        rend_bluebutton=go_bluebutton.GetComponent<Renderer>();
        rend_greenbutton=go_greenbutton.GetComponent<Renderer>();
        rend_redbutton=go_redbutton.GetComponent<Renderer>();
        rend_yellowbutton=go_yellowbutton.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > fl_blueTimer + fl_timer)
        {

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                play_blue();
                fl_blueTimer = Time.time;
            }
            else
            {
                rend_bluebutton.material = mat_blue1;
            }
        }
        if (Time.time > fl_greenTimer + fl_timer)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                play_green();
                fl_greenTimer = Time.time;
            }
            else
            {
                rend_greenbutton.material = mat_green1;
            }
        }
        if (Time.time > fl_redTimer + fl_timer)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                play_red();
                fl_redTimer= Time.time;
            }
            else
            {
                rend_redbutton.material = mat_red1;
            }
        }
        if (Time.time > fl_yellowTimer + fl_timer)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                play_yellow();
                fl_yellowTimer= Time.time;
            }
            else
            {
                rend_yellowbutton.material = mat_yellow1;
            }
        }
    }

    void play_blue()
    {
        //Lights up and plays sound
        rend_bluebutton.material = mat_blue2;
        audioSource.PlayOneShot(aud_blue);
    }
    void play_green()
    {
        //Lights up and plays sound
        rend_greenbutton.material = mat_green2;
        audioSource.PlayOneShot(aud_green);
    }
    void play_red()
    {
        //Lights up and plays sound
        rend_redbutton.material = mat_red2;
        audioSource.PlayOneShot(aud_red);
    }
    void play_yellow()
    {
        //Lights up and plays sound
        rend_yellowbutton.material = mat_yellow2;
        audioSource.PlayOneShot(aud_yellow);
    }
}
