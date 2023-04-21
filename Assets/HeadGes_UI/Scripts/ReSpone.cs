using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpone : MonoBehaviour
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

    void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = Responepoint.transform.position;
    }
}
