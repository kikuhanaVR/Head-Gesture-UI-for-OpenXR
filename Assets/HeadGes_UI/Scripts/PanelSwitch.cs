using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelSwitch : MonoBehaviour
{
    public bool Switchfrag;
    public GameObject vertical;
    public GameObject width;
    public GameObject UINotMark;
    // Start is called before the first frame update
    void Start()
    {
        Switchfrag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Switchfrag) //Switch On
        {
            vertical.SetActive(true);
            width.SetActive(true);
            UINotMark.SetActive(true);
        }
        else //Switch Off
        {
            vertical.SetActive(false);
            width.SetActive(false);
            UINotMark.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Switchfrag)
        {
            Switchfrag = false;
        }
        else
        {
            Switchfrag = true;
        }
    }
}
