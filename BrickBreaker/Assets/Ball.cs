using UnityEngine;
using System.Collections;


public class Ball : MonoBehaviour {
	
	public float initialVelocity = 10;
	private AudioSource audio;
	
	void Awake()
	{
		audio = GetComponent<AudioSource>();
		transform.parent.rigidbody.velocity = Random.insideUnitSphere * initialVelocity;
	}
	
	void OnTriggerEnter(Collider other)
	{
		audio.Play();
		other.SendMessage("BallHit", transform.parent, SendMessageOptions.DontRequireReceiver);
	}
	
}
