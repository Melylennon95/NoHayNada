using UnityEngine;
using System.Collections;

public class MovimientoPuerta : MonoBehaviour {
	public float timer;
	public float speed = 3.5f;
	public Vector3 randomplace;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(Mathf.PingPong(Time.time, 8)-5, transform.position.y, transform.position.z);
	}
}
