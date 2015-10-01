using UnityEngine;
using System.Collections;

// Controller is the master object in the game.  Handles majority of variables, 
public class Controller : MonoBehaviour {

    public int Cash, AP, Food, MP, Year, Workers, Workspace, Fighters, Fightspace, 
               Scouts, Scoutspace, Mines, Schoolspace, Farm, School, Armory, ScoutSchool,
               HousePod, Housespace, Farmturns, exploreMin, exploreMax, mineturns;

    public GameObject buildmenu, actionmenu;


    // Use this for initialization
	void Start () {

        Cash = 2000;
        Workers = 4;
        Food = 10;
        AP = Workers * 2;
        Farm = 1;
        Farmturns = Farm;
        exploreMin = 250;
        exploreMax = 750;
        Mines = 1;
        HousePod = 2;
        Workspace = 4;
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
