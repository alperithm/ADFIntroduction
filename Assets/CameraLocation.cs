using UnityEngine;
using System.Collections;

public class CameraLocation : MonoBehaviour {

	public GameObject Player;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(Player.transform.position.x - 1.78f, Player.transform.position.y - 2.81f, Player.transform.position.z - 8.35f);
	}
}
