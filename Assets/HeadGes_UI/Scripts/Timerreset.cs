using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timerreset : MonoBehaviour
{
    public GameObject Timer;
    public GameObject startpoint;
    public GameObject[] checkpoints;
    public GameObject goalpoint;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        //---------
        startpoint.GetComponent<TimerStart>().enabled = false;
        for (int i = 0; i < checkpoints.Length; i++)
        {
            checkpoints[i].GetComponent<CheckPoints>().enabled = false;
        }
        goalpoint.GetComponent<TimerStop>().enabled = false;

        startpoint.GetComponent<TimerStart>().enabled = true;
        for (int i = 0; i < checkpoints.Length; i++)
        {
            checkpoints[i].GetComponent<CheckPoints>().enabled = true;
        }
        goalpoint.GetComponent<TimerStop>().enabled = true;
        //----------

        Timer.GetComponent<TimeAttack>().enabled = false;
        Timer.GetComponent<TimeAttack>().enabled = true;

        Timer.GetComponent<Timer>().enabled = false;
        Timer.GetComponent<Timer>().enabled = true;
    }
}
