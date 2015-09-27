using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// UIUpdater keeps the UI up to date by grabbing data from Controller
// and throwing it into text fields kept below
public class sUIUpdater : MonoBehaviour {

    // Holds textfields placed in UI.  Assigned in scene.
    public Text CashScore, APScore, FoodScore, MPScore, 
                YearScore, WorkerScore, ScoutScore,
                ChildrenScore, FarmScore, ArmoryScore,
                FighterScore, ScoutSchoolScore, 
                SchoolScore, HousePodScore;

    // Sets Controller as source of the info.  Assigned in scene.
    public Controller scores;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        // Making sure scores/counts update in UI
        CashScore.text = scores.Cash.ToString(); //These are static scoreholders
        APScore.text = scores.AP.ToString();    //they're in background sprite
        FoodScore.text = scores.Food.ToString();
        MPScore.text = scores.MP.ToString();
        YearScore.text = scores.Year.ToString();

        WorkerScore.text = "Workers: " + scores.Workers.ToString(); // These are dynamic scoreholders, 
        ScoutScore.text = "Scouts: " + scores.Scouts.ToString();    // require "Nameofscore: " string 
        ChildrenScore.text = "Children: " + scores.Children.ToString(); // before score to work properly
        FarmScore.text = "Farms: " + scores.Farm.ToString();
        ArmoryScore.text = "Armories: " + scores.Armory.ToString();
        FighterScore.text = "Fighters: " + scores.Fighters.ToString();
        ScoutSchoolScore.text = "Scout Schools: " + scores.ScoutSchool.ToString();
        SchoolScore.text = "Schools: " + scores.School.ToString();
        HousePodScore.text = "House Pod: " + scores.HousePod.ToString();

	
	}
}
