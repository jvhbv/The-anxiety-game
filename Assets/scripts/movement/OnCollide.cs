using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollide : MonoBehaviour {
	/*static public float newX = 100f;
	static public float newY = 100f;
	static public float newZ = 100f;*/
	/*	public float speed = 15f;
	// Update is called once per frame
	void Update () {
		Vector3 newPos = new Vector3 (newX, newY, newZ);
		var trans = transform.position;
		while (trans.x < newX)
		{
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
	}*/

	// Use this for initialization
	void Start () {

	}

	/*	private GameObject FindEnemy(){
		float closest = visionRange;
		GameObject closestEnemy = null;
		foreach (GameObject target in GameObject.FindGameObjectsWithTag(targetTag)){
			float dist = Vector3.Distance (transform.position, target.transform.position);
			if (dist < closest) {
				closest = dist;
				closestEnemy = target;
			}
		}
		return closestEnemy;
	}*/
	// Update is called once per frame
	Vector3 camLoc;
	void OnCollisionEnter(/*Collision col*/){
		//if (col.gameObject.tag == "Player") {
		Collide ();
		//}
	}
	public float changing;
	void Collide ()
	{
		GameObject StartText = (GameObject)Instantiate(Resources.Load ("StartTextPrefab"));
		StartText.transform.position = GameObject.Find("PinkCoin").transform.position;
		StartText.transform.position += Vector3.up * changing * .75f;
		StartText.transform.position += Vector3.back * changing * 0.1f;
		camLoc = GameObject.Find("datboi").transform.position;
		Camera.main.transform.position = GameObject.Find("PinkCoin").transform.position;
		GameObject.Find("datboi").transform.position += Vector3.back * 1.2f;
		Destroy (GameObject.Find("PinkCoin")); // Deletes the coin on collision
		Camera.main.GetComponent<LookMouse>().enabled = false;
		GameObject.Find ("datboi").GetComponent<Move> ().enabled = false;
		Camera.main.transform.position += Vector3.up * changing;
		//if (col.gameObject.name == "M3DMale") {
		/*Vector3 targetVector = new Vector3 (100f, 100f, 100f);
			Vector3 me = transform.position;
			Vector3 movement = targetVector - me;
			if (movement.x < 0) {
				transform.position += Vector3.left * speed * Time.deltaTime;
			} else if (movement.x > 0) {
				transform.position += Vector3.right * speed * Time.deltaTime;
			}
			if (movement.y > 0) {
				transform.position += Vector3.up * speed * Time.deltaTime;
			} else if (movement.y < 0) {
				transform.position += Vector3.down * speed * Time.deltaTime;
			}
			if (movement.z > 0) {
				transform.position += Vector3.back * speed * Time.deltaTime;
			} else if (movement.z < 0) {
				transform.position += Vector3.forward * speed * Time.deltaTime;
			}*/
		//}
	}
	void Update()
	{
		if (Input.GetKey (KeyCode.Return)) {
			Camera.main.GetComponent<LookMouse> ().enabled = true;
			GameObject.Find("datboi").transform.position = camLoc;
			GameObject.Find ("datboi").GetComponent<Move> ().enabled = true;
			Camera.main.transform.position -= Vector3.up * changing;
		}
	}
}
