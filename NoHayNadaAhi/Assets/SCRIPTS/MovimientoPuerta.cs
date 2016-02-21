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
		timer = timer - Time.deltaTime;
		if (timer < 1) {
			timer = 15;
			randomplace = Random.Range(5f,50f);
			randomplace = 
		}
		transform.position = Vector3.MoveTowards(transform.position, randomplace, speed);
	}
}
