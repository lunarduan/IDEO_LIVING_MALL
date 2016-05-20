using UnityEngine;
using UnityEditor;
using NUnit.Framework;

public class IdeoUnitTest : MonoBehaviour{
	private GameObject gameObject = new GameObject();
	private player playerObj;

	public IdeoUnitTest(){
		gameObject = GameObject.FindGameObjectWithTag ("Player");
	}
	public void init()
	{ 
		playerObj = gameObject.AddComponent<player>();
		playerObj.Start ();
		playerObj.Awake ();
	}

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

	[Test]
	public void WalkingTest02 ()
	{
		Debug.Log ("Move Left");
		init ();
		playerObj.moveRight ();
		var speed = playerObj.getPlayerSpeed ();
		Debug.Log ("Got speed = "+speed);
		Assert.Greater(speed, 0,"Move Right");
	}

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