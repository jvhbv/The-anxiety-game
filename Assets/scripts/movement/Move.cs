using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
	public float speed = 1.5f;
	private int facing;		//zero is left one is right
	Transform playerGraphics;
	
	
    private Animator animator;
 
    // Use this for initialization
    void Start()
    {
        animator = this.GetComponent<Animator>();
	}
	
	void Update ()
	
	 { 
         if (Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey("a"))
         {
             transform.position += Vector3.left * speed * Time.deltaTime;
			 animator.SetFloat("vx", -1);
			 animator.SetFloat("dir", 1);
         }
         else if (Input.GetKey(KeyCode.RightArrow)||Input.GetKey("d"))
         {
             transform.position += Vector3.right * speed * Time.deltaTime;
			 animator.SetFloat("vx", 1);
			 animator.SetFloat("dir", .33f);
         }
		 else {
			 animator.SetFloat("vx", 0);
		 }
         if (Input.GetKey(KeyCode.UpArrow)|| Input.GetKey("w"))
         {
			transform.position += Vector3.forward * speed * Time.deltaTime;
			 animator.SetFloat("vy", 1);
			 animator.SetFloat("dir", 0);
         }
         else if (Input.GetKey(KeyCode.DownArrow)|| Input.GetKey("s"))
         {
			transform.position += Vector3.back * speed * Time.deltaTime;
			 animator.SetFloat("vy", -1);
			 animator.SetFloat("dir", 0.66f);
         }
		 else {
			 animator.SetFloat("vy", 0);
			 }
	 }
}