using UnityEngine;
using System.Collections;

public class sButtonFun : MonoBehaviour {

    public Controller controller;

    public void BuyWorker()
    {
        controller.Workers += 1;
    }

    public void BuyFighter()
    {
        controller.Fighters += 1;
    }

    public void Farm()
    {
        controller.Cash += 1500;
    }

    public void Scavage()
    {
        controller.Cash += 1500;
    }

    public void Educate()
    {
        controller.Cash += 1500;
    }

    public void ActionMenu()
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
