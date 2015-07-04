using UnityEngine;
using System.Collections;

public class TestMove : MonoBehaviour {

		float speed =5;
		Animator anim;
		Transform trans;
		bool right=true;
		// Use this for initialization
		void Start () {
			anim= gameObject.GetComponent<Animator>();
			trans = gameObject.GetComponent<Transform> ();
		}
		
		// Update is called once per frame
		void Update () {
			anim.SetFloat ("Speed", Mathf.Abs (Input.GetAxis("Horizontal")));
		}
}
