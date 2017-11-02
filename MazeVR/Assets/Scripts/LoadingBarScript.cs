using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingBarScript : MonoBehaviour {

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
            Debug.Log((int)currentAmount);
        }
        else
        {
            Application.LoadLevel("start_menu");
        }
        LoadingBar.GetComponent<Image>().fillAmount = currentAmount / 100;
    }
}
