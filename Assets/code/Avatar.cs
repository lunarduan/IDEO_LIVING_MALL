
// import library 
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// ประกาศ Class Avartar ไว้สำหรับเลือกกดสิ่งของ
public class Avatar : MonoBehaviour {

	//ประกาศตัวแปร
	public Button ChooseHair,ChooseShirt,ChoosePants,ChooseShoes;   // ตัวแปรชนิดปุ่ม ไว้กดชนิดของ

	public GameObject h1, h2, t1, t2, p1, p2, s1, s2; //ตัวแปรสิ่งของ

	//ตัวแปรcode AVATAR
	public GameObject h1t1,h1t2,h1t1p1,h1t1p2,h1t2p1,h1t2p2,h1t1p1s1,h1t1p1s2,h1t1p2s1,h1t1p2s2,h1t2p1s1,h1t2p2s1,h1t2p1s2,h1t2p2s2;
	public GameObject h2t1,h2t2,h2t1p1,h2t1p2,h2t2p1,h2t2p2,h2t1p1s1,h2t1p1s2,h2t1p2s1,h2t1p2s2,h2t2p1s1,h2t2p2s1,h2t2p1s2,h2t2p2s2;
	public GameObject simple,H1,H2;

	public int h,t,p,s;//ตัวแปรเงื่อนไขสำหรับการเลือก

	//initial ปุ่ม
	public void Start()
	{
		
		ChooseHair.interactable = true;
		ChooseShirt.interactable = false;
		ChoosePants.interactable = false;
		ChooseShoes.interactable = false;

	}
	//method ปุ่มผม จะแสดงแค่itemชนิทรงผมเท่านั่น
	public void chooseh(){
		h1.SetActive (true);
		h2.SetActive (true);
		t1.SetActive (false);
		t2.SetActive (false);
		p1.SetActive (false);
		p2.SetActive (false);
		s1.SetActive (false);
		s2.SetActive (false);
	}
	//method ปุ่มเสื้อ จะแสดงแค่itemชนิดเสื้อเท่านั่น
	public void chooset(){
		h1.SetActive (false);
		h2.SetActive (false);
		t1.SetActive (true);
		t2.SetActive (true);
		p1.SetActive (false);
		p2.SetActive (false);
		s1.SetActive (false);
		s2.SetActive (false);
	}
	// method ปุ่มกางเกง จะแสดงแค่itemชนิดกางเกงเท่านั่น
	public void choosep(){
		h1.SetActive (false);
		h2.SetActive (false);
		t1.SetActive (false);
		t2.SetActive (false);
		p1.SetActive (true);
		p2.SetActive (true);
		s1.SetActive (false);
		s2.SetActive (false);
	}
	//method ปุ่มรองเท้า จะแสดงแค่itemชนิดรองเท้าเท่านั่น
	public void chooses(){
		h1.SetActive (false);
		h2.SetActive (false);
		t1.SetActive (false);
		t2.SetActive (false);
		p1.SetActive (false);
		p2.SetActive (false);
		s1.SetActive (true);
		s2.SetActive (true);
	}



	//method กดที่ปุ่มเสื้อตัวที่1
	public  void hair1(){
		//initial ปุ่ม
		ChooseHair.interactable = false;
		ChooseShirt.interactable = true;
		simple.SetActive(false);
		H1.SetActive (true);
		H2.SetActive (false);
		h = 1;
	}
	public void hair2(){
		//initial ปุ่ม
		ChooseHair.interactable = false;
		ChooseShirt.interactable = true;
		simple.SetActive(false);
		//โชว์modelใหม่ที่มีเงื่อนไขตรงกับที่เลือกมา
		H2.SetActive (true);
		H1.SetActive (false);
		h = 2;
	}
	public void T1(){
		//initial ปุ่ม
		ChooseShirt.interactable = false;
		ChoosePants.interactable = true;
		//ลบmodelก่อนหน้านี้
		H2.SetActive (false);
		H1.SetActive (false);
		//โชว์modelใหม่ที่มีเงื่อนไขตรงกับที่เลือกมา
		if (h == 1) {
			h1t1.SetActive (true);

		} 
		else if (h == 2){
			h2t1.SetActive (true);
		}
		t = 1;
	}
	public void T2(){
		//initial ปุ่ม
		ChooseShirt.interactable = false;
		ChoosePants.interactable = true;
		//ลบmodelก่อนหน้านี้
		H2.SetActive (false);
		H1.SetActive (false);
		//โชว์modelใหม่ที่มีเงื่อนไขตรงกับที่เลือกมา
		if (h == 1) {
			h1t2.SetActive (true);

		} 
		else if (h == 2){
			h2t2.SetActive (true);
		}
		t = 2;
	}
	public void P1(){
		//initial ปุ่ม
		ChoosePants.interactable = false;
		ChooseShoes.interactable = true;
		//ลบmodelก่อนหน้านี้
		h1t2.SetActive (false);
		h2t2.SetActive (false);
		//โชว์modelใหม่ที่มีเงื่อนไขตรงกับที่เลือกมา
		if(h==1&&t==1)
		h1t1p1.SetActive (true);
		else if(h==1&&t==2)
		h1t2p1.SetActive (true);
		else if(h==2&&t==1)
		h2t1p1.SetActive (true);
		else if(h==2&&t==2)
			h2t2p1.SetActive (true);
		p = 1;
	}
	public void P2(){
		//initial ปุ่ม
		ChoosePants.interactable = false;
		ChooseShoes.interactable = true;
		//ลบmodelก่อนหน้านี้
		h1t2.SetActive (false);
		h2t2.SetActive (false);
		//โชว์modelใหม่ที่มีเงื่อนไขตรงกับที่เลือกมา
		if(h==1&&t==1)
		h1t1p2.SetActive (true);
		else if(h==1&&t==2)
		h1t2p2.SetActive (true);
		else if(h==2&&t==1)
		h2t1p2.SetActive (true);
		else if(h==2&&t==2)
			h2t2p2.SetActive (true);
		p = 2;
	}
	public void S1(){
		//initial ปุ่ม
		ChooseShoes.interactable = false;
		//ลบmodelก่อนหน้านี้
		h1t1p2.SetActive (false);
		h1t2p2.SetActive (false);
		h2t1p2.SetActive (false);
		h2t2p2.SetActive (false);
		//โชว์modelใหม่ที่มีเงื่อนไขตรงกับที่เลือกมา
		if(h==1&&t==1&&p==1)
		h1t1p1s1.SetActive (true);
		else if(h==1&&t==1&&p==2)
			h1t1p2s1.SetActive (true);
		else if(h==1&&t==2&&p==1)
			h1t2p1s1.SetActive (true);
		else if(h==2&&t==1&&p==1)
			h2t1p1s1.SetActive (true);
		else if(h==2&&t==2&&p==1)
			h2t2p1s1.SetActive (true);
		else if(h==1&&t==1&&p==2)
		h1t1p2s1.SetActive (true);
		else if(h==1&&t==2&&p==2)
			h1t2p2s1.SetActive (true);
		else if(h==2&&t==1&&p==2)
		h2t1p2s1.SetActive (true);
		else if(h==2&&t==2&&p==2)
			h2t2p2s1.SetActive (true);
	}
	public void S2(){
		//initial ปุ่ม
		ChooseShoes.interactable = false;
		//ลบmodelก่อนหน้านี้
		h1t1p2.SetActive (false);
		h1t2p2.SetActive (false);
		h2t1p2.SetActive (false);
		h2t2p2.SetActive (false);
		//โชว์modelใหม่ที่มีเงื่อนไขตรงกับที่เลือกมา
		if(h==1&&t==1&&p==1)
			h1t1p1s2.SetActive (true);
		else if(h==1&&t==1&&p==2)
			h1t1p2s2.SetActive (true);
		else if(h==1&&t==2&&p==1)
			h1t2p1s2.SetActive (true);
		else if(h==2&&t==1&&p==1)
			h2t1p1s2.SetActive (true);
		else if(h==2&&t==2&&p==1)
			h2t2p1s2.SetActive (true);
		else if(h==1&&t==1&&p==2)
			h1t1p2s2.SetActive (true);
		else if(h==1&&t==2&&p==2)
			h1t2p2s2.SetActive (true);
		else if(h==2&&t==1&&p==2)
			h2t1p2s2.SetActive (true);
		else if(h==2&&t==2&&p==2)
			h2t2p2s2.SetActive (true);
	}


}
