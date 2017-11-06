using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key2 : MonoBehaviour
{

    public bool pickedUp = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            pickedUp = true;
            this.gameObject.SetActive(false);
        }
    }
}
