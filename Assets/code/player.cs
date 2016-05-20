
//import library
using UnityEngine;
using System.Collections;
//class player
public class player : MonoBehaviour
{
//initial ค่า
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
	//initial ค่า
		anim = gameObject.GetComponent<Animator>();
		rb2d = gameObject.GetComponent<Rigidbody2D>();
		rb2d.velocity = new Vector2(0, rb2d.velocity.x); 
	}

	public void Update()
	{
	   //user กด d หรือ ลูกศรขวาจะเข้าเคลื่อนที่ไปทางขวา
		if (Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow))
		{
			moveRight ();
		}
		 //user กด a หรือ ลูกศรซ้ายจะเข้าเคลื่อนที่ไปทางซ้าย
		else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
		{
			moveLeft ();
		}
		 //user กด s หรือ ลูกศรลงจะหยุดการเคลื่อนที่
		else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
		{
			stop ();
		}
	}
     //method ส่งค่า ความเร็วในแกนxของuser
	public float getPlayerSpeed()
	{
		return rb2d.velocity.x;
	}
     //method ส่งค่าpostion แกน x ของ user
	public float getPlayerPostition()
	{
		return rb2d.position.x;
	}

    // เคลือนที่ไปทางขวาและทำการflipเมื่อuserหันซ้าย
	public void moveRight()
	{
		mySpriteRenderer.flipX = true;
		rb2d.velocity = new Vector2(3, rb2d.velocity.x);
	}
   // เคลือนที่ไปทางซ้ายและทำการflipเมื่อuserหันขวา
	public void moveLeft()
	{
		mySpriteRenderer.flipX = false;
		rb2d.velocity = new Vector2(-3, rb2d.velocity.x);
	}
    //ทำการหยุดการเคลื่อนที่
	public void stop()
	{
		rb2d.velocity = new Vector2(0, rb2d.velocity.x);
	}
}

