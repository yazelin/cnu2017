using UnityEngine;
using System.Collections;

public class DebugLogExample : MonoBehaviour {
	public string 飲料="珍奶";
	public int 幾杯=1;
	public bool 老闆帥=true;
	// Use this for initialization
	void Start () {
		

		Debug.Log ("老闆我要"+幾杯+"杯"+飲料);
		if (老闆帥) {
			Debug.Log ("老闆可以給我你的電話號碼嗎");
		} else {
			Debug.Log ("老闆可以快點嗎 我趕時間");
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
