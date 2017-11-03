using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingBarScript1 : MonoBehaviour {

    public Transform LoadingBar;

    [SerializeField]
    private float currentAmount;
    [SerializeField]
    private float speed;

    private void Update()
    {
        if(currentAmount < 100)
        {
            currentAmount += speed * Time.deltaTime;
          //  Debug.Log((int)currentAmount);
        }
        else
        {
#pragma warning disable CS0618 // Type or member is obsolete
            Application.LoadLevel("Maze1(20x20)");
#pragma warning restore CS0618 // Type or member is obsolete
        }
        LoadingBar.GetComponent<Image>().fillAmount = currentAmount / 100;
    }
}
