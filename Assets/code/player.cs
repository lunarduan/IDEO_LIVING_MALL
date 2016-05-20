using UnityEngine;
using System.Collections;

public class player : MonoBehaviour
{
	private bool _IsFacingRight;
	public float maxSpeed = 3;
	public float speed = 50f;

	public bool facingRight = true;

	public Rigidbody2D rb2d;
	public Animator anim;
	private SpriteRenderer mySpriteRenderer;

	public void Awake()
	{
		// get a reference to the SpriteRenderer component on this gameObject
		mySpriteRenderer = GetComponent<SpriteRenderer>();
	}

	public void Start()
	{
		anim = gameObject.GetComponent<Animator>();
		rb2d = gameObject.GetComponent<Rigidbody2D>();
		rb2d.velocity = new Vector2(0, rb2d.velocity.x); 
	}

	public void Update()
	{
		if (Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow))
		{
			moveRight ();
		}
		else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
		{
			moveLeft ();
		}
		else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
		{
			stop ();
		}
	}

	public float getPlayerSpeed()
	{
		return rb2d.velocity.x;
	}

	public float getPlayerPostition()
	{
		return rb2d.position.x;
	}

	private void Flip()
	{
		
	}

	public void moveRight()
	{
		mySpriteRenderer.flipX = true;
		rb2d.velocity = new Vector2(3, rb2d.velocity.x);
	}

	public void moveLeft()
	{
		mySpriteRenderer.flipX = false;
		rb2d.velocity = new Vector2(-3, rb2d.velocity.x);
	}

	public void stop()
	{
		rb2d.velocity = new Vector2(0, rb2d.velocity.x);
	}
}

