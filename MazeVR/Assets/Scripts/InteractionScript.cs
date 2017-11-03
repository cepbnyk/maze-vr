﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class InteractionScript : MonoBehaviour
{ //amount of time we need to look at something before doing something 
    public float gazeTime = 2f; //a generic timer 
    private float timer; //a boolean to determine whether we are or aren't looking at something
    private bool gazedAt;
    private int level = 3;
  // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        //If we are looking at something, start counting up the timer
        if (gazedAt == true)
        {
            timer += Time.deltaTime;
          //  Debug.Log(timer);
            //If we have been looking at something for longer than gazeTime (2 seconds) do something
            if (timer >= gazeTime)
            {
                ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerClickHandler);
#pragma warning disable CS0618 // Type or member is obsolete
                Application.LoadLevel(level); //Loads Level at index
#pragma warning restore CS0618 // Type or member is obsolete
                // SceneManager.LoadScene("Maze1(20x20)", LoadSceneMode.Additive);
                gazedAt = false;
                timer = 0f;

                //This turns the collider on the current component off so we cannot interact with it again
                //GetComponent<Collider> ().enabled = false;
            }
        }
    }
    //If the reticle enters a collision mesh, we are looking at something, and the gazedAt Boolean value becomes true
    public void PointerEnter()
    {
        gazedAt = true;
        

    }
    //If we are no longer doing the above, gazedAt becomes false
    public void PointerExit()
    {
        gazedAt = false;
        timer = 0f;
    }
}