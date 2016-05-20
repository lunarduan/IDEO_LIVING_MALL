using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;

public class Shop : MonoBehaviour {
	public GameObject x;


	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag("Player"))
		{
			x.SetActive (true);
		
			if (Input.GetKeyDown("e"))
			{

				gotoshop ();
			}
		}
	}
	void OnTriggerStay2D(Collider2D col)
	{
		if(col.CompareTag("Player"))
		{
			if (Input.GetKeyDown("e"))
			{
				
				gotoshop ();
			}
		}
	}
	void OnTriggerExit2D(Collider2D col)
	{
		if (col.CompareTag("Player"))
		{
			x.SetActive (false);
		}
	}
	public void gotoshoppingmall()
	{
		Application.LoadLevel(2);
	}

	public void gotoshoppingmallOnTest()
	{
		EditorSceneManager.OpenScene ("Assets\\Shoppingmall.unity");
	}

	public void gotoshop()
	{
		Application.LoadLevel(3);
	}

	public void gotoshopOnTest()
	{

		EditorSceneManager.OpenScene("Assets\\inshop.unity");
	}

	public int getLevel()
	{
		return Application.loadedLevel;
	}

	public string getLevelOnTest()
	{
		return EditorSceneManager.GetActiveScene ().path;
	}

		
}
