using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniMapControler : MonoBehaviour {
	
	private bool IsOn = false;
	public GameObject canvas;
	public float timeOut = 5f;
	private float timeRemaining;

	/*public void Start(){
				timeRemaining = timeOut;
				IsOn = true;


	}*/

	void Update(){
		if(Input.GetKeyDown(KeyCode.E) || (Input.GetKey("joystick button 0"))){ 
			//Time.timeScale = 0; 

			//if(IsOn && (timeRemaining > 0)){
				IsOn = !IsOn;
             	canvas.SetActive(IsOn); 
				/*timeRemaining -= Time.deltaTime;
			}
			else{
				timeRemaining = timeOut;
				IsOn = false;
			}*/
             
         }

	}

}