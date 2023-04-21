using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTest : MonoBehaviour
{
    public GameObject Responepoint;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "VRPlayer")
            other.transform.position = Responepoint.transform.position;
    }
}
