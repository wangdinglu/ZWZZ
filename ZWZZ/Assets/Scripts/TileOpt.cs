using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileOpt : MonoBehaviour {

	public Text nameText;
	public Image nameImage;
	void OnMouseEnter()
	{
		
		if (Manager.instance.currentPlayerIndex == 0) {
			transform.GetComponent<Renderer> ().material.color = Color.yellow;
		} else if (Manager.instance.currentPlayerIndex == 1) {
			transform.GetComponent<Renderer> ().material.color = Color.red;
		} else if (Manager.instance.currentPlayerIndex == 2) {
			transform.GetComponent<Renderer> ().material.color = Color.blue;
		} else {
			transform.GetComponent<Renderer> ().material.color = Color.green;
		}
	}

	void OnMouseExit()
	{
		transform.GetComponent<Renderer>().material.color = Color.white;
	}

	public bool WindowSwitch = false;
	private Rect WindowRect = new Rect(710, 260, 500, 500);

	void OnGUI()
	{
		if (WindowSwitch == true)
		{
			WindowRect = GUI.Window(0, WindowRect, WindowContain, "建造窗口"); //鼠标点击方块弹出建造选项窗口，目前只实现了退出和建造两个选项，未来还应该加入拆除和升级
		}
	}
	public void WindowContain(int windowID)
	{
		if (GUI.Button(new Rect(260, 260, 230, 230), "退出")) 
		{
			WindowSwitch = false;
		}

		if (GUI.Button(new Rect(10, 10, 230, 230), "建造"))
		{
			GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			//cube.AddComponent<HouseComponent>();
			cube.transform.localScale = new Vector3 (10, 10, 10);
			cube.transform.position = new Vector3 (0.0f, 0.0f, 0.0f) + gameObject.transform.position;
			WindowSwitch = false;
			nextPlayer ();
		}

		if (GUI.Button(new Rect(260, 10, 230, 230), "拆除"))
		{
			WindowSwitch = false;
			nextPlayer ();
		}

		if (GUI.Button(new Rect(10, 260, 230, 230), "升级"))
		{
			WindowSwitch = false;
			nextPlayer ();
		}
	}
	//处理鼠标移上物体以及点击事件

	void nextPlayer()
	{
		Manager.instance.nextTurn();
		if (Manager.instance.currentPlayerIndex == 0) {
			nameText.text="ZKW";
			nameImage.GetComponent<Image>().sprite = Resources.Load("zkw") as Sprite;
		} else if (Manager.instance.currentPlayerIndex == 1) {
			nameText.text="ZKY";
			nameImage.GetComponent<Image>().sprite = Resources.Load("zky") as Sprite;
		} else if (Manager.instance.currentPlayerIndex == 2) {
			nameText.text="WDL";
			nameImage.GetComponent<Image>().sprite = Resources.Load("wdl") as Sprite;
		} else {
			nameText.text="ZC";
			nameImage.GetComponent<Image>().sprite = Resources.Load("zc") as Sprite;
		}
	}

	void OnMouseDown()
	{
		WindowSwitch = true; // 如果鼠标点击方块

	}

}
	