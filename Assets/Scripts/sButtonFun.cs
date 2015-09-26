using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Functions executed on various button's press 
public class sButtonFun : MonoBehaviour {

    public Controller controller; // Assigned in scene, button
                                  // functions below are same as
                                  // in game button names

    public void NextYear() // Next Year button
    {
        controller.Year += 1; // go forard a year
        //Remove food per unit
        controller.Food -= controller.Workers + controller.Fighters * 2 + controller.Scouts * 2
                           + controller.Children;
        // Worker year end
        controller.AP = controller.Workers * 2;  // Every worker worth 2AP
        
    }

    public void MakeWorker() // Make worker button
    {
        if (controller.AP - 1 >= 0 && controller.Children - 1 >= 0 && 
            controller.Cash - 250 >= 0 && controller.Workspace - 1 >= 0)
        {
            controller.AP -= 1;
            controller.Children -= 1;
            controller.Cash -= 250;
            controller.Childspace += 1;
            controller.Workspace -= 1;
            controller.Workers += 1;
        }
        
    }

    public void MakeChild() // Make child button
    {
        if (controller.AP - 4 >= 0)
        {
            controller.AP -= 4;
            controller.Children += 1;
        }
        
    }

    public void MakeFighter() // make fighter, base increase of 1 MP per unit
    {
        controller.Fighters += 1;
        controller.MP += 1; 
    }

    public void MakeScout() // make scout button
    {
        controller.Scouts += 1;
    }

    public void Farm() // Farm (action) button. If there's enough AP, Make food
    {
        if (controller.AP - 2 >= 0)
        {
            controller.Food += 4;
            controller.AP -= 2;
        }
    }

    public void Explore() // Explore action button.  
    {
        if (controller.AP - 4 >= 0)
        {
            controller.Cash += Random.Range(0,500); // random range to increase based on num of scouts
            controller.AP -= 4;
        }

    }

    public void ActionMenu()  // Only selectable by "Go To Action Menu" button
    {
        controller.buildmenu.SetActive(false);
        controller.actionmenu.SetActive(true);
    }

    public void BuildMenu()  // Only selectable by "Go To Build Menu" button
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
