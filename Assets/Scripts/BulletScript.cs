using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate (Vector3.up * Time.deltaTime * 25);
	}

	void OnCollisionEnter2D(Collision2D collider){
		Debug.Log (collider.gameObject.name);
		Destroy (gameObject);
	}
}
