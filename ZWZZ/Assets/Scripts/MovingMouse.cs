using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingMouse : MonoBehaviour {


    /*void OnMouseEnter()
    {
        transform.GetComponent<Renderer>().material.color = Color.yellow;
    }

    void OnMouseExit()
    {
        transform.GetComponent<Renderer>().material.color = Color.white;
    }*/

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
			Object homePreb = Resources.Load("HomeComponent",typeof(GameObject));
			GameObject home = Instantiate(homePreb) as GameObject;
			home.transform.localScale = new Vector3 (200, 200, 200);
			home.transform.position = new Vector3 (0.0f, 0.0f, 0.0f) + gameObject.transform.position;
			//home.renderer.material.mainTexture = Resources.Load("Unit2_Ramp__home");
            WindowSwitch = false;
        }

        if (GUI.Button(new Rect(260, 10, 230, 230), "拆除"))
        {
            WindowSwitch = false;
        }

        if (GUI.Button(new Rect(10, 260, 230, 230), "升级"))
        {
            WindowSwitch = false;
        }
    }
    //处理鼠标移上物体以及点击事件
    void OnMouseEnter()
    {
        transform.GetComponent<Renderer>().material.color = Color.yellow; //鼠标移入时方块颜色改为黄色
    }
    void OnMouseDown()
    {
        WindowSwitch = true; // 如果鼠标点击方块

    }
    void OnMouseExit()
    {
        transform.GetComponent<Renderer>().material.color = Color.white; // 鼠标光标移出时方块颜色变回白色
    }
}
