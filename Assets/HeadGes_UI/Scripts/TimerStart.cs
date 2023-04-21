using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerStart : MonoBehaviour
{
    public bool Startfragg;
    // Start is called before the first frame update
    void Start()
    {
        Startfragg = false;
    }
    private void OnEnable()
    {
        Startfragg = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "VRPlayer") Startfragg = true;
    }
}
