using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// Controller is the master object in the game.  Handles majority of variables, 
public class Controller : MonoBehaviour {

    public int Cash, AP, Food, MP, Year, Workers, Workspace, Fighters, Fightspace, 
               Scouts, Scoutspace, Mines, Schoolspace, Farm, School, Armory, ScoutSchool,
               HousePod, Housespace, Farmturns, exploreMin, exploreMax, mineturns, Wall, 
               enemyspawnrate, enemymp, tempfighters;

    public GameObject buildmenu, actionmenu, fightscreen, deathscreen,
                      explorebtn, farmbtn, minebtn, makeworkbtn,
                      makescoutbtn, makefightbtn, buildfarmbtn,
                      buildscoutschoolbtn, buildarmorybtn,
                      buildmenubtn, actionmenubtn, nextyearbtn,
                      buildminebtn, buildhousebtn, buildwallbtn,
                      scorescreen, buyscreen, discchanger;
    
    public Font pixel;


    // Use this for initialization
	void Start () {

        pixel.material.mainTexture.filterMode = FilterMode.Point; // hopefully makes text less blurry

        Cash = 2000;
        Workers = 4;
        Food = 10;
        AP = Workers * 2;
        Farm = 1;
        Farmturns = Farm;
        exploreMin = 250;
        exploreMax = 750;
        Mines = 1;
        mineturns = 1;
        HousePod = 2;
        Workspace = 4;
        enemyspawnrate = 10;
    }
	
	// Update is called once per frame
	void Update () {
        /*if (buyscreen.activeSelf) // for closing buying info screen
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            }*/  // 
        pixel.material.mainTexture.filterMode = FilterMode.Point;
	}
    
}
