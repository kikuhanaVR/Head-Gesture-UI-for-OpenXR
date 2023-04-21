using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissCount : MonoBehaviour
{
    public int Misscount;
    public Text MissText;
    // Start is called before the first frame update
    void Start()
    {
        Misscount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        MissText.text = "[Miss Count] : " + Misscount.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        Misscount += 1;
    }
}
