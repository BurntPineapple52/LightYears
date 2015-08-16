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

        CashScore.text = scores.Cash.ToString();
	
	}
}
