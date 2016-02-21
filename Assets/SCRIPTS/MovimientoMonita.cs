using UnityEngine;
using System.Collections;

public class MovimientoMonita : MonoBehaviour {

	public float speed = 3.5f;
	public bool bDerecha = false;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey(KeyCode.LeftArrow)) {
			if (bDerecha == false) {
				Vector3 theScale = transform.localScale;
				theScale.x *= -1;
				transform.localScale = theScale;
				bDerecha = true;
			}

			transform.position += Vector3.left *speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			if (bDerecha == true) {
				Vector3 theScale = transform.localScale;
				theScale.x *= -1;
				transform.localScale = theScale;
				bDerecha = false;
			}
			transform.position += Vector3.right * speed* Time.deltaTime;
		}
	}
}
