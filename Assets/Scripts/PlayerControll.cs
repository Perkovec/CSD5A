using UnityEngine;
using System.Collections;

public class PlayerControll : MonoBehaviour {

	public Transform LeftJoy;
	public Transform RightJoy;
	public Transform Center;
	public Transform Stick;
	public GameObject Bullet;
	public Transform SpawnPoint;
	private Transform currentBullet;
	CNJoystick CNLeft;
	CNJoystick CNRight;
	Vector3 movement;
	// Use this for initialization
	void Start () {
		CNLeft = LeftJoy.GetComponent<CNJoystick> ();
		CNRight = RightJoy.GetComponent<CNJoystick> ();

	}
	
	// Update is called once per frame
	void Update()
	{

		//Debug.Log ("Horizontal: " + CNLeft.GetAxis ("Horizontal") + " Vertical: " + CNLeft.GetAxis ("Vertical"));

		if (!CNRight.Touched) {
			float angle = Mathf.Atan2 (CNLeft.GetAxis ("Horizontal"), CNLeft.GetAxis ("Vertical")) * Mathf.Rad2Deg; 
			transform.rotation = Quaternion.Lerp (transform.rotation, Quaternion.Euler (new Vector3 (0, 0, -angle)), Time.deltaTime * 10);
		}
		transform.Translate(Vector3.up * Time.deltaTime * Mathf.Abs(Vector3.Distance(Center.transform.position, Stick.transform.position))*2);
		if (CNRight.Touched) {
			float angle = Mathf.Atan2 (CNRight.GetAxis ("Horizontal"), CNRight.GetAxis ("Vertical")) * Mathf.Rad2Deg; 
			transform.rotation = Quaternion.Lerp (transform.rotation, Quaternion.Euler (new Vector3 (0, 0, -angle)), Time.deltaTime * 10);
			Instantiate(Bullet,	SpawnPoint.transform.position, SpawnPoint.transform.rotation);
		}
	}


}
