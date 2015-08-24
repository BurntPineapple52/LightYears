using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class sButtonFun : MonoBehaviour {

    public Controller controller;

    public void NextYear()
    {
        controller.Year += 1;
        controller.AP = controller.Workers * 2;
    }

    public void MakeWorker()
    {
        controller.Workers += 1;
    }

    public void MakeChild()
    {
        if (controller.AP - 4 >= 0)
        {
            controller.Children += 1;
        }
        
    }

    public void MakeFighter()
    {
        controller.Fighters += 1;
    }

    public void MakeScout()
    {
        controller.Scouts += 1;
    }

    public void Farm() // If there's enough AP, Make food
    {
        if (controller.AP - 2 >= 0)
        {
            controller.Food += 4;
            controller.AP -= 2;
        }
    }

    public void Explore()
    {
        if (controller.AP - 4 >= 0)
        {
            controller.Cash += Random.Range(0,500);
            controller.AP -= 4;
        }

    }

    public void Educate()
    {
        controller.Cash += 1500;
    }

    public void ActionMenu()  // Only selectable by "Go To 
    {
        controller.buildmenu.SetActive(false);
        controller.actionmenu.SetActive(true);
    }

    public void BuildMenu()
    {
        controller.buildmenu.SetActive(true);
        controller.actionmenu.SetActive(false);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
