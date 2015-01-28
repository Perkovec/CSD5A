using UnityEngine;
using System.Collections;

public class PlayerControll : MonoBehaviour {

	public Transform LeftJoy;
	public Transform RightJoy;
	public Transform Center;
	public Transform Stick;
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

		Debug.Log ("Horizontal: " + CNLeft.GetAxis ("Horizontal") + " Vertical: " + CNLeft.GetAxis ("Vertical"));

	}


}
