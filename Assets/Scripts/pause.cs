using UnityEngine;
using System.Collections;
using System;


public class pause : MonoBehaviour
{
	bool paused = false;
	
	void Update()
	{
		if(Input.GetKey("p"))
			paused = togglePause();//if p is pressed during run-time, the pause menu is invoked
	}
	
	void OnGUI()
	{
		if(paused)
		{
			GUILayout.Label("Game is paused!");  //Pause Menu with 2 Options : Resume or Quit
			if(GUILayout.Button("Click me to unpause"))
				paused = togglePause();
			if(GUILayout.Button("Quit")) 
				Application.Quit();
		}
	}
	
	bool togglePause()
	{
		if(Time.timeScale == 0f)
		{
			Time.timeScale = 1f;
			return(false);
		}
		else
		{
			Time.timeScale = 0f;
			return(true);    
		}
	}
}
