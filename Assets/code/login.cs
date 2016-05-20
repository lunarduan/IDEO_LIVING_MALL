// import library
using Parse;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

//class login 
public class login : MonoBehaviour {

	//initial ค่าปุ่ม ค่าinput
	public InputField username;
	public InputField pass;
	public GameObject warnning;
	public GameObject loading;


	//ปุ่มเข้าสู่ระบบ
	public void next () {
		//ทำการโชว์ป๊อปอัพ loading
		loading.SetActive (true);
	
	    //เริ่มต้น query
		StartCoroutine (query ());


	}

	// query account's user
	IEnumerator query()
	{
		IEnumerable<ParseObject> comment =null;
		//initial เงื่อนไข
		int couteruser = 0;
		int endqueryuser = 0;
		int loadnextscence = 0;
		// checkค่าว่าตรงกับdatabaseไหม
		Task queryTask = ParseObject.GetQuery("Account").WhereEqualTo("Username",username.text).FindAsync().ContinueWith(t =>
			{

				comment = t.Result;


				foreach (ParseObject obj in comment)
				{
					couteruser++;
					var Pass = obj.Get<string>("Password");

					//เซตเงื่อนไขรหัสผ่านกรณีตรงและไม่ตรง
					if (Pass == pass.text)
					{
						

						loadnextscence = 1;
					}
					else
					{
						loadnextscence = 0;
					
					}


				}
				//เซตเงื่อนไขusernameกรณีไม่ตรง
				if (couteruser == 0)
				{
					loadnextscence = 0;
				

				}



			});

		while (!queryTask.IsCompleted)
		{
			yield return null;
		    //กรณีเงื่อนไขถูกต้องให้ไปฉากต่อไป
			if (loadnextscence == 1)
			{


				Application.LoadLevel(1);

			}

		}
		//กรณีเงื่อนไขผิดให้โช์ป๊อปอัพ warnning และ ปิด ป๊อปอัพโหลด
		 if(loadnextscence == 0)
		{
			loading.SetActive (false);
			warnning.SetActive (true);

		}

	}






		


}
