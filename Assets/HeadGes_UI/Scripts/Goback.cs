using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goback : MonoBehaviour
{

    //プレイヤーを後退させる

    public GameObject Player;
    public float move_speed;
    public GameObject Vertical;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collider)
    {
        //Debug.Log("Enter xxx!");
    }

    void OnTriggerStay(Collider other)
    {
        //Debug.Log("Stay Down!");
        if (other.gameObject.tag == "Cursor")
        {
            Player.transform.position +=
                Vertical.transform.forward * -move_speed * Time.deltaTime;
            //Convert to minus
        }
    }
}
