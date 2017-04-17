using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour
{
	void Update()
	{
		if (!isLocalPlayer)
		{
			return;
		}


		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 300.0f;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * 30.0f;

		transform.Rotate(0, x, 0);
		transform.Translate(0, 0, z);
	}
	public override void OnStartLocalPlayer()
	{
		GetComponent<MeshRenderer>().material.color = Color.blue;
	}
}