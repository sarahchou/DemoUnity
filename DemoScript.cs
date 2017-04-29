using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// converted into simple data that you can look at in inspector in Unity (lets you see float and int in inspector)
[System.Serializable]
public class DataClass {
	public int myInt;
	public float myFloat;
}

public class DemoScript : MonoBehaviour {

	// declare variables
	// type - type of variable; defines the component (e.g. Light is a type)
	public Light myLight;
	public DataClass[] myClass;
	public AnotherDataClass[] myOtherClass;

	// variables are always private by default
	private Rigidbody myRigidBody;
	private Rigidbody myOtherRigidBody;

//	void Awake () {
//		int myVar = AddTwo (7,5);
//		Debug.Log (myVar);
//		myRigidBody = GetComponent <Rigidbody> ();
//		myOtherRigidBody = GameObject.FindWithTag ("Player").GetComponent <Rigidbody>
//	}

	// Unity calls Update for us
	void Update () {
		if (Input.GetKeyDown ("space")) {
			//set the light enabled state to the opposite of what it is
			MyFunction ();
		}
	}

	// 
	void MyFunction () {
		myLight.enabled = !myLight.enabled;
	}

//	int AddTwo (int var1, int var2) {
//		int returnValue = var1 + var2;
//		return returnValue;
//	}
}
