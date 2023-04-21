using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoints : MonoBehaviour
{
    public bool checkpointfragg;
    // Start is called before the first frame update
    void Start()
    {
        checkpointfragg = false;
    }
    private void OnEnable()
    {
        checkpointfragg = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "VRPlayer") checkpointfragg = true;
    }
}
