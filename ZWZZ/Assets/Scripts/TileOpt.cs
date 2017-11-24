using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileOpt : MonoBehaviour {

	public Text nameText;
	public Image nameImage;
	public Canvas osCanvas;
	public Canvas typeCanvas;
	private Button buildButton;
	private Button updateButton;
	private Button pulldownButton;
	private Button houseButton;
	private Button officeButton;
	private Button cafeButton;
	private Button schoolButton;
	private Button parkButton;
	private Button shopButton;
	private float positionx;
	private float positiony;
	private GameObject beingBuild;
	private bool isDetected;
	RaycastHit hit;

	void Start()
	{
		isDetected = false;
		buildButton = GameObject.Find ("Build").GetComponent<Button>();
		updateButton = GameObject.Find ("Update").GetComponent<Button>();
		pulldownButton = GameObject.Find ("PullDown").GetComponent<Button>();
		houseButton = GameObject.Find ("House").GetComponent<Button>();
		officeButton = GameObject.Find ("Office").GetComponent<Button>();
		cafeButton = GameObject.Find ("Cafe").GetComponent<Button>();
		schoolButton = GameObject.Find ("School").GetComponent<Button>();
		shopButton = GameObject.Find ("Shop").GetComponent<Button>();
		parkButton = GameObject.Find ("Park").GetComponent<Button>();
		osCanvas.gameObject.SetActive (false);
		typeCanvas.gameObject.SetActive (false);
	}
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
		

	public void WindowContain()
	{

		if (buildButton.onClick.AddListener())
		{
			GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			//cube.AddComponent<HouseComponent>();
			cube.transform.localScale = new Vector3 (10, 10, 10);
			cube.transform.position = new Vector3 (0.0f, 0.0f, 0.0f) + gameObject.transform.position;
			nextPlayer ();
		}

		if (GUI.Button(new Rect(260, 10, 230, 230), "拆除"))
		{
			nextPlayer ();
		}

		if (GUI.Button(new Rect(10, 260, 230, 230), "升级"))
		{
			nextPlayer ();
		}
	}
	//处理鼠标移上物体以及点击事件

	void Update()
	{
		buildButton.onClick.AddListener (buildModel);
		updateButton.onClick.AddListener (updateModel);
		pulldownButton.onClick.AddListener (pulldownModel);
		houseButton.onClick.AddListener (pulldownModel);
	}

	void buildModel()
	{
		osCanvas.gameObject.SetActive(false);
		typeCanvas.gameObject.SetActive (true);

	}

	void updateModel()
	{

	}

	void pulldownModel()
	{

	}

	void nextPlayer()
	{
		Manager.instance.nextTurn();
		if (Manager.instance.currentPlayerIndex == 0) {
			nameText.text="租户";
			nameImage.GetComponent<Image>().sprite = Resources.Load("Sprites/zkw") as Sprite;
		} else if (Manager.instance.currentPlayerIndex == 1) {
			nameText.text="村民";
			nameImage.GetComponent<Image>().sprite = Resources.Load("Sprites/zky") as Sprite;
		} else if (Manager.instance.currentPlayerIndex == 2) {
			nameText.text="政府";
			nameImage.GetComponent<Image>().sprite = Resources.Load("Sprites/wdl") as Sprite;
		} else {
			nameText.text="企业";
			nameImage.GetComponent<Image>().sprite = Resources.Load("Sprites/zc") as Sprite;
		}
	}

	void OnMouseDown()
	{
		osCanvas.gameObject.SetActive(true);
		WindowContain ();
		
	}

}
	