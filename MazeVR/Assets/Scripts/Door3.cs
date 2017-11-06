using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door3 : MonoBehaviour
{
    public Key3 myKey;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (myKey.pickedUp == true)
            {
                //gameObject.SetActive(false);
                var thedoor = GameObject.FindWithTag("SF_Door3");
                thedoor.GetComponent<Animation>().Play("open");

            }
        }
    }
}
