
// import library
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
// ประกาศ Class Shop ไว้สำหรับเข้าร้านค้า
public class Shop : MonoBehaviour {

	//ประกาศตัวแปรป๊อปอัพ
	public GameObject x;

	//method ตรวจเช็คเมื่อplayerมาบริเวณร้านจะมีป๊อบอัพขึ้นให้เข้าร้อน
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag("Player"))
		{
			x.SetActive (true);
		
			if (Input.GetKeyDown("e"))
			{

				Application.LoadLevel(3);
			}
		}
	}
	//method ตรวจเช็คเมื่อplayerอยู่ในบริเวณร้านจะมีป๊อบอัพขึ้นให้เข้าร้อน
	void OnTriggerStay2D(Collider2D col)
	{
		if(col.CompareTag("Player"))
		{
			if (Input.GetKeyDown("e"))
			{
				
				Application.LoadLevel(3);
			}
		}
	}
	//method ตรวจเช็คเมื่อplayerอยนอกในบริเวณร้านปุ่มจะหายไป
	void OnTriggerExit2D(Collider2D col)
	{
		if (col.CompareTag("Player"))
		{
			x.SetActive (false);
		}
	}
	//method เข้าไปใฉากร้านค้า
	public void gotoshoppingmall()
	{
		Application.LoadLevel(2);
	}


		
}
