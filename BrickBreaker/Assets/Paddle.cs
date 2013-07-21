using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	
	public float moveSpeed = 5;
	public float velocityModifier = 5;
//	
//	void Awake()
//	{
//		Texture2D tex = new Texture2D(1, 1);
//		Color col = new Color(.4f, 0.4f, 0.4f, 1f);
//		tex.SetPixel(0, 0, col);
//		renderer.material.mainTexture = tex;
//	}
//	
	// Update is called once per frame
	void Update () {
		Vector3 move = new Vector3();
		move.x += Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
		move.z -= Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
		
		transform.position += move;
	}
	
	public void BallHit(Transform ball)
	{
		Debug.Log("FUCK!");
		if(ball == null)
		{
			Debug.Log("ITS FUCKING NULL");
			return;
		}
		Vector3 hitPos = ball.position - transform.position;
		hitPos.y = 0;
		ball.rigidbody.velocity = ball.rigidbody.velocity + hitPos * velocityModifier;
	}
}
