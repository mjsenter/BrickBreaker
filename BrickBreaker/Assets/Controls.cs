using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {
	
	public float moveSpeed = 5;
	
	// Update is called once per frame
	void Update () {
		Vector3 move = new Vector3();
		move.x += Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
		move.z -= Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
		
		transform.position += move;
	}
}
