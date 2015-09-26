using UnityEngine;
using System.Collections;

// Controller is the master object in the game.  Handles majority of variables, 
public class Controller : MonoBehaviour {

    public int Cash, AP, Food, MP, Year, Workers, Workspace, Fighters, Fightspace, 
               Scouts, Scoutspace, Children, Childspace, Farm, School, Armory, ScoutSchool;

    public GameObject buildmenu, actionmenu;


    // Use this for initialization
	void Start () {
        Cash = 1000;
        Workers = 4;
        Food = 10;
        AP = Workers * 2;
        
	 
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
