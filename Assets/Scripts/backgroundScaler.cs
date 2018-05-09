using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundScaler : MonoBehaviour {

	void Start () {
		var height = Camera.main.orthographicSize * 2f;
		var widht = height * Screen.width / Screen.height;

		if (gameObject.name == "Background") {
			transform.localScale = new Vector3 (widht, height, -2);
		} else {
			transform.localScale = new Vector3 (widht + 3f, 5f, -2);
		}
	}

	void Update(){

	}

}
