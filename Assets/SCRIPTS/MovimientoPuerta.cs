using UnityEngine;
using System.Collections;

public class MovimientoPuerta : MonoBehaviour {
	public float timer;
	public float speed = 3.5f;
	public Vector3 randomplace;
    public Animator anim;
    //const public int Ataque = 1;

	// Use this for initialization
	void Start () {
        anim = this.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(Mathf.PingPong(Time.time, 2)* speed, transform.position.y, transform.position.z);
        //anim.SetInteger("state", 0);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Bla")
        {
            Debug.Log("Touching");
            anim.SetInteger("state", 1);
            Debug.Log("Touching Monita");
        }

    }

    void OnCollisionExit2D(Collision2D coll)
    {
        anim.SetInteger("state", 0);
    }
}
