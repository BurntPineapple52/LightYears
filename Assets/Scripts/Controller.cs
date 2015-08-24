using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

    public int Cash, AP, Food, MP, Year, Workers, Fighters, Scouts, Children,
               Farm, School, Armory, ScoutSchool;

    /*public bool makeWorker, buyFighter, makeChild, buildFarm, doScavage, doEducate,
    *            buildMenu, actionMenu, buildArmory, buildScoutSchool;
    * Probably delete, made bools when I didn't need them*/

    public bool buildMenu, actionMenu, newTurn;


    public GameObject buildmenu, actionmenu;


	// Use this for initialization

    void ButtonUpdate()
    {
        if (buildMenu == true)
        {
            actionMenu = false;
            buildmenu.SetActive(true);
            actionmenu.SetActive(false);
        }
        if (actionMenu == true)
        {
            buildMenu = false;
            buildmenu.SetActive(false);
            actionmenu.SetActive(true);
        }
    }


	void Start () {
        //actionMenu = true;
        //buildMenu = false;
        Cash = 1000;
        
	 
	}
	
	// Update is called once per frame
	void Update () {

        //ButtonUpdate();
	
	}
}
