using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
	public float speed = 1.5f;
	/*public int angleOne = 0;
	public int angleTwo = 360;*/

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.rotation = Quaternion.identity;// * speed * Time.deltaTime;
	}
}
