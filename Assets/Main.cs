using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Main : MonoBehaviour
{
    public Button ButtonToggleText;
    public TextMeshProUGUI TextMain;

    // Start is called before the first frame update
    void Start()
    {
        // disable the toggle button
        ButtonToggleText.GetComponent<Button>().interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    public void ToggleText()
    {
        if (TextMain.text.Equals("Primary Text"))
            TextMain.text = "Secondary Text";
        else
            TextMain.text = "Primary Text";
    }
}

