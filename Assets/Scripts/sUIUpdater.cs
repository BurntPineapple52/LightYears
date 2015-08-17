using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class sUIUpdater : MonoBehaviour {


    public Text CashScore, APScore, FoodScore, MPScore,
                YearScore, WorkerScore, ScoutScore,
                ChildrenScore, FarmScore, ArmoryScore;
    public Controller scores;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        // Making sure scores/counts update in UI
        CashScore.text = scores.Cash.ToString();
        APScore.text = scores.AP.ToString();
        FoodScore.text = scores.Food.ToString();
        MPScore.text = scores.MP.ToString();
        YearScore.text = scores.Year.ToString();
        WorkerScore.text = "Workers: " + scores.Workers.ToString();
        ScoutScore.text = "Scouts: " + scores.Scouts.ToString();
        ChildrenScore.text = "Children: " + scores.Children.ToString();
        FarmScore.text = "Farms: " + scores.Farm.ToString();
        ArmoryScore.text = "Armory: " + scores.Armory.ToString();


	
	}
}
