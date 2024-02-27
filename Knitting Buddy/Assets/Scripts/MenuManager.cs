using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [Header("Menus")]
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject projectsMenu;
    [SerializeField] GameObject woolMenu;

    [Header("Projects")]
    [SerializeField] GameObject[] projectPages;
    
    public void GoToProject(int projectIndex)
    {
        projectPages[projectIndex].SetActive(true);
        projectsMenu.SetActive(false);
    }
    public void OpenProjectsMenu()
    {
        mainMenu.SetActive(false);
        projectsMenu.SetActive(true);
    }
    public void OpenWoolMenu()
    {
        mainMenu.SetActive(false);
        woolMenu.SetActive(true);
    }
    public void ExitApplication()
    {
        Application.Quit();
    }
}
