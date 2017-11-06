using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2 : MonoBehaviour
{
    public Key2 myKey;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (myKey.pickedUp == true)
            {
                //gameObject.SetActive(false);
                var thedoor = GameObject.FindWithTag("SF_Door2");
                thedoor.GetComponent<Animation>().Play("open");

            }
        }
    }
}
