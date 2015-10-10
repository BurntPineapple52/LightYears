using UnityEngine;
using System.Collections;

public class sFun : MonoBehaviour {
    public Controller controller; // Assigned in scene, button
    // functions below are same as
    // in game button names

    public CanvasGroup scoreboardgroup, fightscreengroup;



    public void NextYear() // Next Year button
    {
            controller.Year += 1; // go forard a year
            controller.Food -= controller.Workers + controller.Fighters * 2
                               + controller.Scouts * 2;//Remove food per unit
            controller.AP = controller.Workers * 2;
            if (controller.AP <= 0)
            {

            }
            controller.Farmturns = controller.Farm; // Refreshes how many times you can farm a year 
            // based on how many farms you have.  
            controller.mineturns = controller.Mines;
            controller.enemymp += 1;// enemy MP levels increase every year       
            FoodCheck(); // Kills suckas if food is below 000 :O
            EnemySpawner();
    }

    public void FoodCheck() // if food drops below 0, rand unit is killed off until
    {                       // >= 0
        if (controller.Food < 0)
        {
            while (controller.Food < 0)
            {
                switch (Random.Range(0, 3)) // picks between 0, 1, and 2
                {
                    case 0:
                        if (controller.Workers - 1 >= 0) // if not enough worker to kill, skip
                        {
                            controller.Workers -= 1;
                            controller.Food += 1;
                        }
                        break;
                    case 1:
                        if (controller.Scouts - 1 >= 0)
                        {
                            controller.Scouts -= 1;
                            controller.Food += 2;
                        }
                        break;
                    case 2:
                        if (controller.Fighters - 1 >= 0)
                        {
                            controller.Fighters -= 1;
                            controller.Food += 2;
                        }
                        break;
                }
            }
            controller.Food = 0; // ensures food is at 0 after the killing stops. <3
        }
    }

    public void BuyScreen(int screenpos)
    {
        GameObject buy = controller.buyscreen;
        buy.SetActive(true);
        scoreboardgroup.blocksRaycasts = false;
        switch(screenpos)
        {
            case 0:
                buy.transform.localPosition = new Vector3(-84.4f, 75.4f, -8900);
                break;
            case 1:
                buy.transform.localPosition = new Vector3(-84.4f, 24.2f, -8900);
                break;
            case 2:
                buy.transform.localPosition = new Vector3(-84.4f, 33.2f, -8900);
                break;
            case 3:
                buy.transform.localPosition = new Vector3(84.2f, 75.4f, -8900);
                break;
            case 4:
                buy.transform.localPosition = new Vector3(84.2f, 24.2f, -8900);
                break;
            case 5:
                buy.transform.localPosition = new Vector3(84.2f, 33.2f, -8900);
                break;
            case 6:
                buy.transform.localPosition = new Vector3(-84.4f, 75.4f, -8900);
                break;
            case 7:
                buy.transform.localPosition = new Vector3(-84.4f, 24.2f, -8900);
                break;
            case 8:
                buy.transform.localPosition = new Vector3(-84.4f, 33.2f, -8900);
                break;
            case 9:
                buy.transform.localPosition = new Vector3(84.4f, 75.4f, -8900);
                break;
            case 10:
                buy.transform.localPosition = new Vector3(84.4f, 24.2f, -8900);
                break;
            case 11:
                buy.transform.localPosition = new Vector3(84.4f, 33.2f, -8900);
                break;
        }
    }

    public void buybuttonswitcher()
    {
        switch(controller.buyscreen.GetComponent<sScreenDiscChanger>().discSelection)
        {
            case 0: // make worker
                if (controller.AP - 2 >= 0 &&// Making sure you can pay for the goods
                    controller.Cash - 250 >= 0 && controller.Workspace - 1 >= 0)
                {
                    controller.AP -= 2; // Everything that happens if you can pay.  Below follow same format.
                    controller.Cash -= 250;
                    controller.Workspace -= 1;
                    controller.Workers += 1;
                }
                break;

            case 1: // make scout
                if (controller.AP - 2 >= 0 && controller.Cash - 750 >= 0 &&
                    controller.Scoutspace - 1 >= 0)
                {
                    controller.Cash -= 750;
                    controller.AP -= 2;
                    controller.Scouts += 1;
                    controller.Scoutspace -= 1;
                    controller.exploreMin += 250; // Increases exploreMin and Max
                    controller.exploreMax += 250;
                }
                break;

            case 2: // make fighter
                if (controller.AP - 2 >= 0 && controller.Cash - 750 >= 0 &&
                    controller.Fightspace - 1 >= 0)
                {
                    controller.Cash -= 750;
                    controller.AP -= 2;
                    controller.Fighters += 1;
                    controller.Fightspace -= 1;
                    controller.MP += 5;
                }
                break;

            case 3: //Explore
                if (controller.AP - 6 >= 0)
                {
                    controller.Cash += Random.Range(controller.exploreMin, controller.exploreMax);
                    controller.AP -= 6; // ^^^ random range to increase based on num of scouts
                }
                break;

            case 4: //Farm
                if (controller.AP - 2 >= 0 && controller.Farmturns - 1 >= 0)
                {
                    controller.Food += 4;
                    controller.AP -= 2;
                    controller.Farmturns -= 1;
                }
                break;

            case 5: //Mine
                if (controller.AP - 2 >= 0 && controller.mineturns - 1 >= 0)
                {
                    controller.Cash += 200;
                    controller.AP -= 2;
                    controller.mineturns -= 1;
                }
                break;
            case 6: //Build Mine
                if (controller.AP - 5 >= 0 && controller.Cash - 500 >= 0)
                {
                    controller.Cash -= 500;
                    controller.AP -= 5;
                    controller.mineturns += 4;
                    controller.Mines += 1;
                }
                break;

            case 7: // Build Scout School
                if (controller.AP - 10 >= 0 && controller.Cash - 1000 >= 0)
                {
                    controller.Cash -= 1000;
                    controller.AP -= 10;
                    controller.Scoutspace += 4;
                    controller.ScoutSchool += 1;
                }
                break;

            case 8: // Build HousePod
                if (controller.AP - 5 >= 0 && controller.Cash - 500 >= 0)
                {
                    controller.Cash -= 500;
                    controller.AP -= 5;
                    controller.Workspace += 4;
                    controller.HousePod += 1;
                }
                break;

            case 9: //Build Factory
                if (controller.AP - 5 >= 0 && controller.Cash - 500 >= 0)
                {
                    controller.Cash -= 500;
                    controller.AP -= 5;
                    controller.Farm += 1;
                }
                break;

            case 10: //Build Armory
                if (controller.AP - 8 >= 0 && controller.Cash - 750 >= 0)
                {
                    controller.Cash -= 750;
                    controller.AP -= 8;
                    controller.Fightspace += 4;
                    controller.Armory += 1;
                }
                break;

            case 11: //Build Wall
                if (controller.AP - 2 >= 0 && controller.Cash - 300 >= 0)
                {
                    controller.AP -= 2;
                    controller.Cash -= 300;
                    controller.Wall += 1;
                    controller.MP += 1;
                }
                break;
        }
    }

    public void EnemySpawner()
    {
        int year = controller.Year;  // so I don't have to write so much
        GameObject screen = controller.fightscreen; // yee
        int roll = Random.Range(0, 100); // figure out if something will spawn
        if (roll <= controller.enemyspawnrate)  // if it does spawn
        {
            screen.SetActive(true);
            scoreboardgroup.blocksRaycasts = false;
            if (year <= 10) // higher the year, higher the strength increase 
            {               // mp increases are perm
                controller.enemymp += Random.Range(0, 4);
            }
            else if (year > 10 && year <= 20)
            {
                controller.enemymp += Random.Range(4, 12);
            }
            else if (year > 20 && year <= 30)
            {
                controller.enemymp += Random.Range(8, 18);
            }
            else if (year > 40 && year <= 50)
            {
                controller.enemymp += Random.Range(12, 24);
            }
        }
        if (controller.enemyspawnrate < 75) // highest spawn rate
        {
            controller.enemyspawnrate += 3;
        }
    }

    public void AddWorker()// add worker button on fight screen
    {
        if (controller.AP - 2 >= 0)
        {
            controller.MP += 1;
            controller.tempfighters += 1;
            controller.AP -= 2;
        }
    }

    public void Fight() // fight button on fight screen
    {
        controller.fightscreen.SetActive(false);
        scoreboardgroup.blocksRaycasts = true;
        if (controller.MP < controller.enemymp)
        {
            controller.deathscreen.SetActive(true);
            scoreboardgroup.blocksRaycasts = false;
        }
        controller.MP -= controller.tempfighters;
        controller.tempfighters = 0;
        controller.enemymp = controller.Year; //Reset back to base after fight
    }

    public void MakeWorker() // Make worker button
    {
        BuyScreen(0);
        controller.discchanger.GetComponent<sScreenDiscChanger>().discSelection = 0;
    }

    public void Mine() // Mine Action
    {

        BuyScreen(5);
        controller.discchanger.GetComponent<sScreenDiscChanger>().discSelection = 5;

    }

    public void MakeFighter() // make fighter, base increase of 5 MP per unit
    {
        BuyScreen(2);
        controller.discchanger.GetComponent<sScreenDiscChanger>().discSelection = 2;
    }

    public void MakeScout() // make scout button
    {
        BuyScreen(1);
        controller.discchanger.GetComponent<sScreenDiscChanger>().discSelection = 1;
    }

    public void Farm() // Farm (action) button. If there's enough AP, Make food
    {
        BuyScreen(4);
        controller.discchanger.GetComponent<sScreenDiscChanger>().discSelection = 4;
    }

    public void Explore() // Explore action button.  
    {
        BuyScreen(3);
        controller.discchanger.GetComponent<sScreenDiscChanger>().discSelection = 3;

    }

    public void buildwall() // Build wall button
    {
        BuyScreen(11);
        controller.discchanger.GetComponent<sScreenDiscChanger>().discSelection =11;
    }

    public void buildmine() // Build mine button  
    {
        BuyScreen(6);
        controller.discchanger.GetComponent<sScreenDiscChanger>().discSelection = 6;
    }

    public void buildpod() // Build HousePod button  
    {
        BuyScreen(8);
        controller.discchanger.GetComponent<sScreenDiscChanger>().discSelection = 8;
    }

    public void buildscoutschool() // Build ScoutSchool button  
    {
        BuyScreen(7);
        controller.discchanger.GetComponent<sScreenDiscChanger>().discSelection = 7;
    }

    public void buildarmory() // Build HousePod button  
    {
        BuyScreen(10);
        controller.discchanger.GetComponent<sScreenDiscChanger>().discSelection = 10;
    }

    public void buildfarm() // Build Farm button  
    {
        BuyScreen(9);
        controller.discchanger.GetComponent<sScreenDiscChanger>().discSelection = 9;
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
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
}
