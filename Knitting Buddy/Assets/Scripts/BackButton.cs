using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    [SerializeField]
    GameObject currentPage;
    [SerializeField]
    GameObject desiredPage;
    public void BackButtonFunction()
    {
        desiredPage.SetActive(true);
        currentPage.SetActive(false);
    }
}
