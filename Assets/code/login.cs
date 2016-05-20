using Parse;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
public class login : MonoBehaviour {
	public InputField username;
	public InputField pass;
	public GameObject warnning;
	public GameObject loading;
	// Use this for initialization

	public void next () {
		loading.SetActive (true);
		Debug.Log (username.text);
		Debug.Log (pass.text);
	
		StartCoroutine (query ());


	}


	IEnumerator query()
	{
		IEnumerable<ParseObject> comment =null;
		Debug.Log("2");
		int couteruser = 0;
		int endqueryuser = 0;
		int loadnextscence = 0;

		Task queryTask = ParseObject.GetQuery("Account").WhereEqualTo("Username",username.text).FindAsync().ContinueWith(t =>
			{



				Debug.Log("3");

				comment = t.Result;


				foreach (ParseObject obj in comment)
				{
					couteruser++;
					var Pass = obj.Get<string>("Password");
					if (Pass == pass.text)
					{
						//string  username = id.text;
						Debug.Log("Next scence");
						loadnextscence = 1;
					}
					else
					{
						loadnextscence = 0;
						endqueryuser = 1;
					}


				}

				if (couteruser == 0)
				{
					loadnextscence = 0;
					endqueryuser = 1;

				}



			});

		while (!queryTask.IsCompleted)
		{
			yield return null;
		
			if (loadnextscence == 1)
			{

				Debug.Log("Success");
				Application.LoadLevel(1);

			}

		}
		 if(loadnextscence == 0)
		{
			loading.SetActive (false);
			warnning.SetActive (true);

		}

	}






		


}
