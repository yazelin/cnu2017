using UnityEngine;
using System.Collections;

public class TransformScaleExample : MonoBehaviour {
	private GameObject Target;
	// Use this for initialization
	void Start () {
		Target = GameObject.Find ("Cube");
	}

	// Update is called once per frame
	void Update () {

	}

	void OnGUI (){
		if (GUI.Button(new Rect(10,10,200,30),"X ++")) {
			Target.transform.localScale += new Vector3 (0.1f,0,0);
		}
		if (GUI.Button(new Rect(210,10,200,30),"X --")) {
			Target.transform.localScale += new Vector3 (-0.1f,0,0);
		}

		if (GUI.Button(new Rect(10,40,200,30),"Y ++")) {
			Target.transform.localScale += new Vector3 (0,0.1f,0);
		}
		if (GUI.Button(new Rect(210,40,200,30),"Y --")) {
			Target.transform.localScale += new Vector3 (0,-0.1f,0);
		}

		if (GUI.Button(new Rect(10,70,200,30),"Z ++")) {
			Target.transform.localScale += new Vector3 (0,0,0.1f);
		}
		if (GUI.Button(new Rect(210,70,200,30),"Z --")) {
			Target.transform.localScale += new Vector3 (0,0,-0.1f);
		}
	}
}
