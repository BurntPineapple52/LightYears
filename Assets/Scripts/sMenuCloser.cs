using UnityEngine;
using System.Collections;

public class sMenuCloser : MonoBehaviour
{

    public Controller controller;
    public GameObject bscrn;
    public CanvasGroup scoreboardgroup;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = new RaycastHit2D();
            hit = Physics2D.Raycast(new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, 
                                    Camera.main.ScreenToWorldPoint(Input.mousePosition).y), Vector2.zero, 0f);
            Debug.Log(hit.collider.name);
            if (hit.collider.name != bscrn.name && bscrn.activeSelf)
            {
                Debug.Log(hit.collider.name);
                bscrn.SetActive(false);
                scoreboardgroup.blocksRaycasts = true;
            }
            if (controller.deathscreen.activeSelf)
            {
                Application.LoadLevel(0);
            }
        }
           
    }
}
