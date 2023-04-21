using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeAttack : MonoBehaviour
{
    GameObject StartObj;
    GameObject GoalObj;
    public GameObject[] points;

    // Start is called before the first frame update
    void Start()
    {
        StartObj = transform.Find("Start").gameObject;
        GoalObj = transform.Find("Goal").gameObject;

        StartObj.GetComponent<MeshRenderer>().enabled = true;
        StartObj.GetComponent<CapsuleCollider>().enabled = true;
        GoalObj.GetComponent<MeshRenderer>().enabled = false;
        GoalObj.GetComponent<CapsuleCollider>().enabled = false;

        for (int i = 0; i < points.Length; i++)
        {
            points[i].GetComponent<MeshRenderer>().enabled = false;
            points[i].GetComponent<CapsuleCollider>().enabled = false;
        }
    }

    private void OnEnable()
    {
        StartObj = transform.Find("Start").gameObject;
        GoalObj = transform.Find("Goal").gameObject;

        StartObj.GetComponent<MeshRenderer>().enabled = true;
        StartObj.GetComponent<CapsuleCollider>().enabled = true;
        GoalObj.GetComponent<MeshRenderer>().enabled = false;
        GoalObj.GetComponent<CapsuleCollider>().enabled = false;

        for (int i = 0; i < points.Length; i++)
        {
            points[i].GetComponent<MeshRenderer>().enabled = false;
            points[i].GetComponent<CapsuleCollider>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponentInChildren<TimerStart>().Startfragg == true)
        {
            StartObj.GetComponent<MeshRenderer>().enabled = false;
            StartObj.GetComponent<CapsuleCollider>().enabled = false;
            points[0].GetComponent<MeshRenderer>().enabled = true;
            points[0].GetComponent<CapsuleCollider>().enabled = true;
        }

        for (int i = 0; i < points.Length - 1; i++)
            if (points[i].GetComponent<CheckPoints>().checkpointfragg)
            {
                points[i].GetComponent<MeshRenderer>().enabled = false;
                points[i].GetComponent<CapsuleCollider>().enabled = false;
                points[i + 1].GetComponent<MeshRenderer>().enabled = true;
                points[i + 1].GetComponent<CapsuleCollider>().enabled = true;
            }

        if (points[points.Length - 1].GetComponent<CheckPoints>().checkpointfragg)
        {
            points[points.Length - 1].GetComponent<MeshRenderer>().enabled = false;
            points[points.Length - 1].GetComponent<CapsuleCollider>().enabled = false;
            GoalObj.GetComponent<MeshRenderer>().enabled = true;
            GoalObj.GetComponent<CapsuleCollider>().enabled = true;
        }
    }
}
