using UnityEngine;
using System.Collections;

public class ForLoopExample : MonoBehaviour {
	public int 數到第幾 = 1;
	public int 要數到多少隻 = 1000;
	public int 第幾隻就睡著 = 300;
	// Use this for initialization
	void Start () {

		Debug.Log ("睡不著覺來數羊");

		//從第1隻開始數，要數到10000隻
		for (int 數到第幾 = 1; 數到第幾 < 要數到多少隻; 數到第幾++) {

			Debug.Log (數到第幾 + "隻羊");//現在數到第幾隻

			if (數到第幾 == 第幾隻就睡著) {
			
				Debug.Log ("zzzZZZ");// zzzZZZ 睡著了
				break;	//已經睡著就不再數了
			}
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
