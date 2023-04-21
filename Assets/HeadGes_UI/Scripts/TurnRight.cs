using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnRight : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] int RotatePerSec;

    float rotate_speed = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider other)
    {
        //Debug.Log("Stay Right!");
        if (other.gameObject.tag == "Cursor")
        {
            Player.transform.Rotate(0, RotatePerSec * Time.deltaTime * rotate_speed, 0);
        }
    }
}
