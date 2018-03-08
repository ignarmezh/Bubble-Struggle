using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public Vector2 startForce;

    public GameObject nextBallPref;

    public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb.AddForce(startForce,ForceMode2D.Impulse);
	}
	
	public void Split()
    {
        if(nextBallPref != null)
        {
            GameObject ballOne = Instantiate(nextBallPref,rb.position + Vector2.right/4f,Quaternion.identity);
            GameObject ballTwo = Instantiate(nextBallPref,rb.position + Vector2.left / 4f,Quaternion.identity);

            ballOne.GetComponent<Ball>().startForce = new Vector2(2f,5f);
            ballTwo.GetComponent<Ball>().startForce = new Vector2(-2f,5f);
        }
        Destroy(gameObject);
    }
}
