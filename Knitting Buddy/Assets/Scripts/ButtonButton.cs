using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonButton : MonoBehaviour
{
    [SerializeField]
    GameObject currentPage;
    [SerializeField]
    GameObject desiredPage;
    public void ButtonFunction()
    {
        desiredPage.SetActive(true);
        currentPage.SetActive(false);
    }
}
