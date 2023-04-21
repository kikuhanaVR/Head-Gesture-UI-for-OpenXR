using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time;
    public Text TimeText;
    public bool Bool;

    // Start is called before the first frame update
    void Start()
    {
        time = 0.0f;
        Bool = false;
    }

    private void OnEnable()
    {
        time = 0.0f;
        Bool = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Startfragg is " + GetComponentInChildren<TimerStart>().Startfragg);
        //Debug.Log("Stopfragg is " + GetComponentInChildren<TimerStop>().Stopfragg);
        if (GetComponentInChildren<TimerStart>().Startfragg) Bool = true;
        if (GetComponentInChildren<TimerStop>().Stopfragg) Bool = false;

        if (Bool == true)
        {
            time += Time.deltaTime;
        }

        int minute = (int)time / 60;
        int second = (int)time % 60;
        float msecf = time * 100 % 100;
        int msec = (int)msecf;
        string minText, secText, msecText;

        if (minute < 10)
            minText = "0" + minute.ToString();//("0"埋め), ToStringでint→stringに変換.
        else
            minText = minute.ToString();

        if (second < 10)
            secText = "0" + second.ToString();//上に同じく.
        else
            secText = second.ToString();

        if (msec < 10)
            msecText = "0" + msec.ToString();//上に同じく.
        else
            msecText = msec.ToString();

        TimeText.text = "[Time] " + minText + ":" + secText + "." + msecText;

        //TimeText.text = time.ToString("F2");
    }
}
