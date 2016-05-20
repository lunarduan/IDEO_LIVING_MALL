using UnityEngine;
using UnityEditor;
using NUnit.Framework;

public class AvatarTest :MonoBehaviour{
	private GameObject gameObject = new GameObject();
	private Avatar avatar;

	public AvatarTest(){
		gameObject = GameObject.FindGameObjectWithTag ("Avatar");
	}

    [Test]
    public void hairClick()
    {
		Debug.Log ("Click on hair");
		avatar = gameObject.AddComponent<Avatar> ();
		//var avatar = gameObject.AddComponent<Avatar> ();
		avatar.Start();
		avatar.chooseh ();
		//Assert.IsFalse (avatar.h1.);
    }
}
