using UnityEngine;
using System.Collections;

public class TransformRotationExample : MonoBehaviour {
	private GameObject Target;
	// Use this for initialization
	void Start () {
		Target = GameObject.Find ("Cube");
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnGUI (){

		Target.transform.Rotate (0,Input.GetAxis("Mouse X"),0);

		if (GUI.Button(new Rect(10,10,200,30),"X ++")) {
			Target.transform.Rotate (10,0,0);
		}
		if (GUI.Button(new Rect(210,10,200,30),"X --")) {
			Target.transform.Rotate (-10,0,0);
		}

		if (GUI.Button(new Rect(10,40,200,30),"Y ++")) {
			Target.transform.Rotate (0,10,0);
		}
		if (GUI.Button(new Rect(210,40,200,30),"Y --")) {
			Target.transform.Rotate (0,-10,0);
		}

		if (GUI.Button(new Rect(10,70,200,30),"Z ++")) {
			Target.transform.Rotate (0,0,10);
		}
		if (GUI.Button(new Rect(210,70,200,30),"Z --")) {
			Target.transform.Rotate (0,0,-10);
		}
	}
}
