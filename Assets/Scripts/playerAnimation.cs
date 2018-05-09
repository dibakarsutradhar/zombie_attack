using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimation : MonoBehaviour {

	private Animator anim;

	void Awake () {
		anim = GetComponent<Animator> ();
	}

	void OnCollisionEnter2D (Collision2D target) {
		if (target.gameObject.tag == "Obstacle") {
			anim.Play ("playerIdle");
		}
	}

	void OnCollisionExit2D (Collision2D target) {
		if (target.gameObject.tag == "Obstacle") {
			anim.Play ("playerWalk");
		}
	}
}
