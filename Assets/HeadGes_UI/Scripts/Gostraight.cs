using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gostraight : MonoBehaviour
{

    //プレイヤーを前進させる

    public GameObject Player;
    public float move_speed = 5f;
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
        //Debug.Log("Stay Up!");
        if (other.gameObject.tag == "Cursor")
        {
            Player.transform.position +=
                Vertical.transform.forward * move_speed * Time.deltaTime;
        }
    }
}
