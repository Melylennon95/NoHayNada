using UnityEngine;
using System.Collections;

public class MovimientoMonita : MonoBehaviour {

	public float speed = 3.5f;
	public bool bDerecha = false;
	public int jumpSpeed = 30;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (KeyCode.LeftArrow)) {
			if (bDerecha == false) {
				Vector3 theScale = transform.localScale;
				theScale.x *= -1;
				transform.localScale = theScale;
				bDerecha = true;
			}

			transform.position += Vector3.left * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			if (bDerecha == true) {
				Vector3 theScale = transform.localScale;
				theScale.x *= -1;
				transform.localScale = theScale;
				bDerecha = false;
			}
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.Space)) {
			Vector3 theScale = transform.position;
			transform.position += Vector3.up * jumpSpeed * Time.deltaTime;
		}

	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Bla")
        {
            //coll.gameObject.SendMessage("ApplyDamage", 10);
            Debug.Log("Touching");
            Destroy(coll.gameObject);
        }
    }
}
