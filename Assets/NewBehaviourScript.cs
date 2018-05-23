using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			Debug.Log ("left arrow");
			Vector3 position = this.transform.position;
			position.x--;
			this.transform.position = position;
		}
		if (Input.GetKey (KeyCode.RightArrow))
		{
			Debug.Log ("right arrow");
			Vector3 position = this.transform.position;
			position.x++;
			this.transform.position = position;
		}
		if (Input.GetKey (KeyCode.UpArrow))
		{
			Debug.Log ("up arrow");
			Vector3 position = this.transform.position;
			position.y++;
			this.transform.position = position;
		}
		if (Input.GetKey (KeyCode.DownArrow))
		{
			Debug.Log ("down arrow");
			Vector3 position = this.transform.position;
			position.y--;
			this.transform.position = position;
		}
		if (Input.GetKey (KeyCode.Space))
		{
			Vector3 position = this.transform.position;
			position.x = 0;
			position.y = 0;

		}
	}
}
