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
	/*	Scene scene = EditorSceneManager.NewScene (NewSceneSetup.EmptyScene, NewSceneMode.Single);
		EditorSceneManager.SaveScene (scene, "Assets\\inshop.unity");
		EditorSceneManager.CloseScene (scene, true);
		EditorSceneManager.OpenScene ("Assets\\Shoppingmall.unity");*/
		//Application.LoadLevel(2);
	}

	public void gotoshop()
	{
		Application.LoadLevel(3);
	}

	public void gotoshopOnTest()
	{
		/*Scene scene = EditorSceneManager.NewScene (NewSceneSetup.EmptyScene, NewSceneMode.Single);
		EditorSceneManager.SaveScene (scene, "Assets\\Shoppingmall.unity");
		EditorSceneManager.CloseScene (scene, true);
		EditorSceneManager.OpenScene("Assets\\inshop.unity");
		//EditorSceneManager.CreateScene("Assets\\inshop.unity");
		//Application.LoadLevel(3);*/
	}

	public int getLevel()
	{
		return Application.loadedLevel;
	}

	public string getLevelOnTest()
	{
		return EditorSceneManager.GetActiveScene ().path;
		//return Application.loadedLevel;
	}

		
}
