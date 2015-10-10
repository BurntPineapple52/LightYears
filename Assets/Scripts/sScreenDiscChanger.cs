using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class sScreenDiscChanger : MonoBehaviour {

    public Text title, description, buycost, upgradecost;
    public int discSelection;
    public Button buybutton, upgradebutton;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        switch(discSelection)
        {
            case 0:
                title.text = "WorkerBot";
                description.text = "WorkerBots provide +2 AP every year. " +
                " Workers also use 1 Battery a year and require a HousePod.";
                buycost.text ="BUY:\n" + "-2 AP \n -250 CASH";
                upgradecost.text = "UPGRADE:\n" + "TBD";
                break;
            case 1:
                title.text = "ScoutBot";
                description.text = "ScoutBots Increase how much material you find exploring! " +
                "Scouts use 2 Battery a year and require a Scout School.";
                buycost.text = "BUY:\n" + "-2 AP \n -500 CASH";
                upgradecost.text = "UPGRADE:\n" + "TBD";
                break;
            case 2:
                title.text = "FighterBot";
                description.text = "FighterBots provide +5 MP every year. " +
                "Fighters use 2 Battery a year and require an Armory.";
                buycost.text = "BUY:\n" + "-2 AP \n -500 CASH";
                upgradecost.text = "UPGRADE:\n" + "TBD";
                break;
            case 3:
                title.text = "Explore";
                description.text = "Search the area for profitable materials! " +
                "Buying Scouts increases Cash return. 250-750 CASH base";
                buycost.text = "ACTION:\n" + "-6 AP";
                upgradecost.text = "UPGRADE:\n" + "TBD";
                break;
            case 4:
                title.text = "Make Batteries!";
                description.text = "Charge and Repair Batteries. " + 
                "Produce +4 Batteries at a Battery Factory";
                buycost.text = "ACTION:\n" + "-2 AP";
                upgradecost.text = "UPGRADE:\n" + "TBD";
                break;
            case 5:
                title.text = "Mine";
                description.text = "Mine the earth for valuable resources! " +
                "Each Mine can only be used once a year. +250 CASH";
                buycost.text = "BUY:\n" + "-2 AP";
                upgradecost.text = "UPGRADE:\n" + "TBD";
                break;
            case 6:
                title.text = "Build a Mine";
                description.text = "Extra Mines mean more Mining!. " +
                "Allows for extra Mining each year.";
                buycost.text = "BUY:\n" + "-5 AP \n -500 CASH";
                upgradecost.text = "UPGRADE:\n" + "TBD";
                break;
            case 7:
                title.text = "Scout School";
                description.text = "Allows Scouts to be purchased " +
                "4 Scouts may be commissioned per School";
                buycost.text = "BUY:\n" + "-10 AP \n -1000 CASH";
                upgradecost.text = "UPGRADE:\n" + "TBD";
                break;
            case 8:
                title.text = "HousePod";
                description.text = "Housing for WorkerBots " +
                "4 WorkerBots fit each pod";
                buycost.text = "BUY:\n" + "-5 AP \n -500 CASH";
                upgradecost.text = "UPGRADE:\n" + "TBD";
                break;
            case 9:
                title.text = "Batt. Factory";
                description.text = "Keep your Bots running " +
                "Allows extra Battery production each year.";
                buycost.text = "BUY:\n" + "-5 AP \n -500 CASH";
                upgradecost.text = "UPGRADE:\n" + "TBD";
                break;
            case 10:
                title.text = "Armory";
                description.text = "Allows FighterBots to be purchased " +
                "Each Armory can support 4 Fighters";
                buycost.text = "BUY:\n" + "-8 AP \n -750 CASH";
                upgradecost.text = "UPGRADE:\n" + "TBD";
                break;
            case 11:
                title.text = "Wall";
                description.text = "Electric fences for areas of operation! " +
                "Uses 1 Battery a year and provides +1 MP";
                buycost.text = "BUY:\n" + "-2 AP \n -300 CASH";
                upgradecost.text = "UPGRADE:\n" + "TBD";
                break;

        }
	
	}
}
