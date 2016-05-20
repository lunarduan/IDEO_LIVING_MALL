using UnityEngine;
using UnityEditor;
using NUnit.Framework;

public class IdeoUnitTest : MonoBehaviour{
	private GameObject gameObject = new GameObject();
	private player playerObj;

	/**
	 *	Intital game object and player object when
	 *	begin
	 * 
	 **/
	public IdeoUnitTest(){
		gameObject = GameObject.FindGameObjectWithTag ("Player");
	}

	/*
	 * 	Set player position and velocity to zero
	 * 	then reanimate
	 **/
	public void init()
	{ 
		playerObj = gameObject.AddComponent<player>();
		playerObj.Start ();
		playerObj.Awake ();
	}

	/*
	 *  Move left and then assert that player speed is a negative number
	 * 
	 **/
	[Test]
	public void WalkingTest01()
	{
		Debug.Log ("Move Left");
		init ();
		playerObj.moveLeft ();
		var speed = playerObj.getPlayerSpeed ();
		Debug.Log ("Got speed = "+speed);
		Assert.Less(speed, 0,"Move Left");
	}

	/*
	 *  Move right and hen assert that player speed is a positive number
	 * 
	 **/
	[Test]
	public void WalkingTest02 ()
	{
		Debug.Log ("Move Right");
		init ();
		playerObj.moveRight ();
		var speed = playerObj.getPlayerSpeed ();
		Debug.Log ("Got speed = "+speed);
		Assert.Greater(speed, 0,"Move Right");
	}

	/*
	 * 	Move right shortly and then stop, assert that player speed is zero
	 * 
	 **/
	[Test]
	public void WalkingTest03()
	{
		Debug.Log ("Move Right Then Stop");
		init ();
		playerObj.moveRight ();
		playerObj.stop ();
		var speed = playerObj.getPlayerSpeed ();
		Debug.Log ("Got speed = "+speed);
		Assert.That(speed==0);
	}
}