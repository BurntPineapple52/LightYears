using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

    public int Cash, AP, Food, MP, Year, Workers, Fighters, Scouts, Children,
               Farm, School, Armory, ScoutSchool;

    public bool buyWorker, buyFighter, makeChild, buildFarm, doScavage, doEducate,
                buildMenu, actionMenu, buildArmory, buildScoutSchool;


	// Use this for initialization
	void Start () {
        Cash = 1000;
        
	 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
