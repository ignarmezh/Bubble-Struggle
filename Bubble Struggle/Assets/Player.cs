using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public float speed = 4f;

    public Rigidbody2D rb;

    private float movement = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        movement = Input.GetAxisRaw("Horizontal") * speed;
	}

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + new Vector2(movement ,0f) * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Ball")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
