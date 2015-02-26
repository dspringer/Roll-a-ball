using UnityEngine;
using System.Collections;
using System.IO;

public class Instantiation : MonoBehaviour {

	string fileName = "values.txt";

	// Use this for initialization
	void Start () {
		for (int y = 0; y < 5; y++) {
			for (int x = 0; x < 5; x++) {
				GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
				cube.AddComponent<Rigidbody>();
				cube.transform.localScale = new Vector3(.25f, .25f, .25f);
				cube.transform.position = new Vector3(x, y, 0);
			}
		}
	
		StreamReader sr = new StreamReader (Application.dataPath + "/" + fileName);
		float [] fTokens = new float[3];



		// Currently a performance bottleneck? Later should read-in in bulk
		for (int b = 0; b < 3; b++) {
			var tokens = sr.ReadLine ().Trim ().Split (',');
			for (int a = 0; a < 3; a++) {
				fTokens [a] = float.Parse (tokens [0]);
			}

			GameObject dynamicCube = GameObject.CreatePrimitive (PrimitiveType.Cube);
			dynamicCube.transform.position = new Vector3 (fTokens [0], fTokens [1], fTokens [2]);

		}


		//Debug.Log (tokens[2]);
		sr.Close ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
