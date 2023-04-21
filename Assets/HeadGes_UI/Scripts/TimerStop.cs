using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerStop : MonoBehaviour
{
    public bool Stopfragg;
    // Start is called before the first frame update
    void Start()
    {
        Stopfragg = false;
    }
    private void OnEnable()
    {
        Stopfragg = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "VRPlayer") Stopfragg = true;
    }
}
