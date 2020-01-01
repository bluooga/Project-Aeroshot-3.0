using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ExamineAbility : MonoBehaviour
{
    public GameObject UI;
    float distance;

    public TextMeshProUGUI Object;
    public TextMeshProUGUI Distance;
    public TextMeshProUGUI Health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            TheRoomWhereItHappens();
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            UI.SetActive(false);
        }
    }

    public void TheRoomWhereItHappens()
    {
        RaycastHit hit;

        //if hit check for Stats Script
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit))
        {
            if (hit.transform.GetComponent<Stats>() != null)
            {
                //ShowUI
                UI.SetActive(true);

                //Scan Distance
                Distance.SetText("Distance: " + hit.distance.ToString("F2") + " m");
                //Scan Health
                Health.SetText("Health: " + hit.transform.GetComponent<Stats>().Health.ToString("F1"));
                //Scan Entity
                Object.SetText("Entity: " + hit.transform.GetComponent<Stats>().Entity);
            }
            else
            {
                //set Distcance blank
                Distance.SetText(" ");
                //set Health blank
                Health.SetText(" ");
                //set Entity blank
                Object.SetText(" ");
            }
        }
        else
        {
            UI.SetActive(false);
        }
    }
}
