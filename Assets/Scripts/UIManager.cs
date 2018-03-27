using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

    public GameObject startMenu;

    private GameObject activeMenu;
    private GameObject lastMenu;

    // Use this for initialization
    void Start()
    {
        SwitchTo(startMenu);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void DisableMenus()
    {
        foreach (Transform t in transform)
        {
            t.gameObject.SetActive(false);
        }
    }

    public void SwitchTo(GameObject menu)
    {
        lastMenu = activeMenu;
        activeMenu = menu;
        DisableMenus();
        menu.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
