using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour {

	public void gotocatalog(){
		SceneManager.LoadScene ("catalog");
	}

	public void gotocalMode(){
		SceneManager.LoadScene ("calMode");
	}

	public void gotoRule(){
		SceneManager.LoadScene ("Rule");
	}

	public void gotobuildMode(){
		SceneManager.LoadScene ("buildMode");
	}

}
