using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCamera : MonoBehaviour {

	public int cameraIndex;
	private GameObject[] c;

	// Use this for initialization
	void Start () {
		cameraIndex = 0;
		c = new GameObject[4];
		c [0] = GameObject.Find ("MiniCamera (0)");
		c [1] = GameObject.Find ("MiniCamera (1)");
		c [2] = GameObject.Find ("MiniCamera (2)");
		c [3] = GameObject.Find ("MiniCamera (3)");
		c [1].SetActive (false);
		c [2].SetActive (false);
		c [3].SetActive (false);
	}
	
	// Update is called once per frame
	public void rightRotate(){
		c [cameraIndex].SetActive (false);
		cameraIndex = (cameraIndex + 1) % 4;
		Debug.Log (cameraIndex);
		c [cameraIndex].SetActive (true);
	}

	public void leftRotate(){
		c [cameraIndex].SetActive (false);
		cameraIndex = (cameraIndex + 3) % 4;
		Debug.Log (cameraIndex);
		c [cameraIndex].SetActive (true);
	}

}
