// import library
using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	//initial ค่า
	private Vector2 velocity;

	public float smoothTimeY;
	public float smoothTimeX;

	public GameObject player;

	public bool bounds;

	public Vector3 minCameraPos;
	public Vector3 maxCametaPos;


	void Start () {

		//initial player
		player = GameObject.FindGameObjectWithTag("Player");
	}



	void FixedUpdate () {
		//initial ค่ากล้อง
		float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX);
		//initial ตำแหน่งplayer
		transform.position = new Vector3(posX,0,transform.position.z);

		if (bounds)
		{
			//ทำกล้องให้ติดตามplayer
			transform.position = new Vector3(Mathf.Clamp(transform.position.x, minCameraPos.x, maxCametaPos.x),

				Mathf.Clamp(transform.position.z, minCameraPos.z, maxCametaPos.z));
		}
	}
}
