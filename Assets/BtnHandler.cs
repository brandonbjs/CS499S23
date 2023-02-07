using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnHandler : MonoBehaviour
{
    public Main main;
    public GameObject ButtonToggleText;

    // Get Main object to do the actual work
    public void ToggleText()
    {
        main.ToggleText();
    }

    // We can deal with this one here.
    public void EnableToggle()
    {
        if (ButtonToggleText.GetComponent<Button>().interactable)
            ButtonToggleText.GetComponent<Button>().interactable = false;
        else
            ButtonToggleText.GetComponent<Button>().interactable = true;
    }
}