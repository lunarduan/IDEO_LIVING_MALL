using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Avatar : MonoBehaviour {
	public Button ChooseHair,ChooseShirt,ChoosePants,ChooseShoes;
	public GameObject h1, h2, t1, t2, p1, p2, s1, s2;
	// Use this for initialization
	public GameObject h1t1,h1t2,h1t1p1,h1t1p2,h1t2p1,h1t2p2,h1t1p1s1,h1t1p1s2,h1t1p2s1,h1t1p2s2,h1t2p1s1,h1t2p2s1,h1t2p1s2,h1t2p2s2;
	public GameObject h2t1,h2t2,h2t1p1,h2t1p2,h2t2p1,h2t2p2,h2t1p1s1,h2t1p1s2,h2t1p2s1,h2t1p2s2,h2t2p1s1,h2t2p2s1,h2t2p1s2,h2t2p2s2;
	public GameObject simple,H1,H2;
	int h,t,p,s;
	public void Start()
	{
		ChooseHair.interactable = true;
		ChooseShirt.interactable = false;
		ChoosePants.interactable = false;
		ChooseShoes.interactable = false;
	}

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




	public void hair1(){
		ChooseHair.interactable = false;
		ChooseShirt.interactable = true;
		simple.SetActive(false);
		H1.SetActive (true);
		H2.SetActive (false);
		h = 1;
	}
	public void hair2(){
		ChooseHair.interactable = false;
		ChooseShirt.interactable = true;
		simple.SetActive(false);
		H2.SetActive (true);
		H1.SetActive (false);
		h = 2;
	}
	public void T1(){
		ChooseShirt.interactable = false;
		ChoosePants.interactable = true;
		H2.SetActive (false);
		H1.SetActive (false);
		if (h == 1) {
			h1t1.SetActive (true);

		} 
		else if (h == 2){
			h2t1.SetActive (true);
		}
		t = 1;
	}
	public void T2(){
		ChooseShirt.interactable = false;
		ChoosePants.interactable = true;
		H2.SetActive (false);
		H1.SetActive (false);
		if (h == 1) {
			h1t2.SetActive (true);

		} 
		else if (h == 2){
			h2t2.SetActive (true);
		}
		t = 2;
	}
	public void P1(){
		ChoosePants.interactable = false;
		ChooseShoes.interactable = true;
		h1t2.SetActive (false);
		h2t2.SetActive (false);
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
		ChoosePants.interactable = false;
		ChooseShoes.interactable = true;
		h1t2.SetActive (false);
		h2t2.SetActive (false);
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
		ChooseShoes.interactable = false;
		h1t1p2.SetActive (false);
		h1t2p2.SetActive (false);
		h2t1p2.SetActive (false);
		h2t2p2.SetActive (false);
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
		ChooseShoes.interactable = false;
		h1t1p2.SetActive (false);
		h1t2p2.SetActive (false);
		h2t1p2.SetActive (false);
		h2t2p2.SetActive (false);
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
