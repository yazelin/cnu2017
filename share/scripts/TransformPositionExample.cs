using UnityEngine;
using System.Collections;

public class TransformPositionExample : MonoBehaviour {
	private GameObject Target;
	// Use this for initialization
	void Start () {
		Target = GameObject.Find ("Cube");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI (){
		if (Input.GetKey(KeyCode.W)) {
			Target.transform.Translate (0,0,1);
		}
		if (Input.GetKey(KeyCode.S)) {
			Target.transform.Translate (0,0,-1);
		}
		if (GUI.Button(new Rect(10,10,200,30),"X ++")) {
			Target.transform.Translate (1,0,0);
		}
		if (GUI.Button(new Rect(210,10,200,30),"X --")) {
			Target.transform.Translate (-1,0,0);
		}

		if (GUI.Button(new Rect(10,40,200,30),"Y ++")) {
			Target.transform.Translate (0,1,0);
		}
		if (GUI.Button(new Rect(210,40,200,30),"Y --")) {
			Target.transform.Translate (0,-1,0);
		}

		if (GUI.Button(new Rect(10,70,200,30),"Z ++")) {
			Target.transform.Translate (0,0,1);
		}
		if (GUI.Button(new Rect(210,70,200,30),"Z --")) {
			Target.transform.Translate (0,0,-1);
		}
	}
}
