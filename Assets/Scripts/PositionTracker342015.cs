using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;
using System.Collections.Generic;

public class PositionTracker : MonoBehaviour {
	public GameObject player;
	StreamWriter outfile = new StreamWriter("values.txt", true);
	List<Vector3> posArray = new List<Vector3> ();//player position array as XYZ vectors
	List<RaycastHit> collisionArray = new List<RaycastHit
	// Use this for initialization
	void Start () {
	}
	

	// Update is called once per frame
	void Update () {
			var playerPos = player.transform.position;//player position as XYZ vector
			posArray.Add (playerPos); // add player position to 3-D Array
		   // outfile.WriteLine(playerPos); //write to values.txt--> uncomment to test StreamWriter 
			Debug.Log (playerPos); //log position to check if player movement is being recorded
	}
	void onApplicationQuit(){
			foreach(Vector3 coordinate in posArray){//loop through posArray to write position coordinates to values.txt
				outfile.WriteLine(coordinate.toString()); //write to values.txt 
				outfile.WriteLine("=====");//add seperator between XYZ value
				var direction = coordinate.transform.direction; //direction the player is moving in at a certain time

				if(Physics.Raycast(coordinate, direction,out HitInfo : RayCastHit, 100)){ //Record coordinate of
				var collision = RaycastHit.transform;			//raycast collision object and add the info to the values txt
				outfile.WriteLine("collides with:  ");
				outfile.WriteLine(collision.toString());
			}
		}
	}

}
