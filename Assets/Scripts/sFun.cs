using UnityEngine;
using System.Collections;

public class sFun : MonoBehaviour {
    public Controller controller; // Assigned in scene, button
    // functions below are same as
    // in game button names

    public CanvasGroup scoreboardgroup, fightscreengroup;



    public void NextYear() // Next Year button
    {
        if (controller.fightscreen.activeSelf == false)
        {
            controller.Year += 1; // go forard a year
            controller.Food -= controller.Workers + controller.Fighters * 2
                               + controller.Scouts * 2;//Remove food per unit
            controller.AP = controller.Workers * 2;
            controller.Farmturns = controller.Farm; // Refreshes how many times you can farm a year 
            // based on how many farms you have.  
            controller.mineturns = controller.Mines;
            controller.enemymp += 1;                // enemy MP levels increase every year       
            FoodCheck(); // Kills suckas if food is below 000 :O
            EnemySpawner();
        }
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

    public void EnemySpawner()
    {
        int year = controller.Year;  // so I don't have to write so much
        int enemymp = controller.enemymp;  // same
        GameObject screen = controller.fightscreen; // yee
        int roll = Random.Range(0, 100); // figure out if something wills spawn
        if (roll <= controller.enemyspawnrate)  // if it does spawn
        {
            screen.SetActive(true);
            scoreboardgroup.blocksRaycasts = false;
            if (year <= 10)
            {
                enemymp += Random.Range(0, 4);
            }
            else if (year > 10 && year <= 20)
            {
                enemymp += Random.Range(4, 12);
            }
            else if (year > 20 && year <= 30)
            {
                enemymp += Random.Range(8, 18);
            }
            else if (year > 40 && year <= 50)
            {
                enemymp += Random.Range(12, 24);
            }
        }
        if (controller.enemyspawnrate < 75)
        {
            controller.enemyspawnrate += 3;
        }
    }

    public void AddWorker()
    {
        if (controller.Workers - 1 >= 0)
        {
            controller.MP += 1;
            controller.AP -= 2;
        }
    }

    public void Fight()
    {
        controller.fightscreen.SetActive(false);
        scoreboardgroup.blocksRaycasts = true;
        if (controller.MP < controller.enemymp)
        {
            controller.deathscreen.SetActive(true);
        }
    }

    public void MakeWorker() // Make worker button
    {
        if (controller.AP - 2 >= 0 && controller.fightscreen.activeSelf == false &&// Making sure you can pay for the goods
            controller.Cash - 250 >= 0 && controller.Workspace - 1 >= 0)
        {
            controller.AP -= 2; // Everything that happens if you can pay.  Below follow same format.
            controller.Cash -= 250;
            controller.Workspace -= 1;
            controller.Workers += 1;
        }

    }

    public void Mine() // Mine Action
    {
        if (controller.AP - 2 >= 0 && controller.mineturns - 1 >= 0 &&
            controller.fightscreen.activeSelf == false)
        {
            controller.Cash += 200;
            controller.AP -= 2;
            controller.mineturns -= 1;
        }

    }

    public void MakeFighter() // make fighter, base increase of 5 MP per unit
    {
        if (controller.AP - 2 >= 0 && controller.Cash - 750 >= 0 &&
            controller.Fightspace - 1 >= 0 && controller.fightscreen.activeSelf == false)
        {
            controller.Cash -= 750;
            controller.AP -= 2;
            controller.Fighters += 1;
            controller.Fightspace -= 1;
            controller.MP += 5;
        }
    }

    public void MakeScout() // make scout button
    {
        if (controller.AP - 2 >= 0 && controller.Cash - 750 >= 0 &&
            controller.Scoutspace - 1 >= 0 && controller.fightscreen.activeSelf == false)
        {
            controller.Cash -= 750;
            controller.AP -= 2;
            controller.Scouts += 1;
            controller.Scoutspace -= 1;
            controller.exploreMin += 250; // Increases exploreMin and Max
            controller.exploreMax += 250;
        }
    }

    public void Farm() // Farm (action) button. If there's enough AP, Make food
    {
        if (controller.AP - 2 >= 0 && controller.Farmturns - 1 >= 0 &&
            controller.fightscreen.activeSelf == false)
        {
            controller.Food += 4;
            controller.AP -= 2;
            controller.Farmturns -= 1;
        }
    }

    public void Explore() // Explore action button.  
    {
        if (controller.AP - 12 >= 0 && controller.fightscreen.activeSelf == false)
        {
            controller.Cash += Random.Range(controller.exploreMin, controller.exploreMax);
            controller.AP -= 10; // ^^^ random range to increase based on num of scouts
        }

    }

    public void buildwall() // Build wall button
    {
        if (controller.AP - 2 >= 0 && controller.Cash - 300 >= 0 &&
            controller.fightscreen.activeSelf == false)
        {
            controller.AP -= 2;
            controller.Cash -= 300;
            controller.Wall += 1;
            controller.MP += 1;
        }
    }

    public void buildmine() // Build mine button  
    {
        if (controller.AP - 5 >= 0 && controller.Cash - 500 >= 0 &&
            controller.fightscreen.activeSelf == false)
        {
            controller.Cash -= 500;
            controller.AP -= 5;
            controller.mineturns += 4;
            controller.Mines += 1;
        }
    }

    public void buildpod() // Build HousePod button  
    {
        if (controller.AP - 4 >= 0 && controller.Cash - 500 >= 0 &&
            controller.fightscreen.activeSelf == false)
        {
            controller.Cash -= 500;
            controller.AP -= 4;
            controller.Workspace += 4;
            controller.HousePod += 1;
        }
    }

    public void buildscoutschool() // Build ScoutSchool button  
    {
        if (controller.AP - 10 >= 0 && controller.Cash - 1000 >= 0 &&
            controller.fightscreen.activeSelf == false)
        {
            controller.Cash -= 1000;
            controller.AP -= 10;
            controller.Scoutspace += 4;
            controller.ScoutSchool += 1;
        }
    }

    public void buildarmory() // Build HousePod button  
    {
        if (controller.AP - 8 >= 0 && controller.Cash - 750 >= 0 &&
            controller.fightscreen.activeSelf == false)
        {
            controller.Cash -= 750;
            controller.AP -= 8;
            controller.Fightspace += 4;
            controller.Armory += 1;
        }
    }

    public void buildfarm() // Build Farm button  
    {
        if (controller.AP - 5 >= 0 && controller.Cash - 500 >= 0 &&
            controller.fightscreen.activeSelf == false)
        {
            controller.Cash -= 500;
            controller.AP -= 5;
            controller.Farm += 1;
        }
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
