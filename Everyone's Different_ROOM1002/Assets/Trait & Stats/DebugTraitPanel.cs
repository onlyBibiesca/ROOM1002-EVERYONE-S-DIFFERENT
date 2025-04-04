using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class DebugTraitPanel : MonoBehaviour
{
    public GameObject panel;  // Assign the UI Panel in the Inspector
    public Button confirmButton;
    public List<Toggle> traitToggles; // Assign trait toggles in the Inspector

    private string selectedTrait;

    void Start()
    {
        panel.SetActive(true); // Show panel at the start
        confirmButton.onClick.AddListener(ConfirmTraitSelection);
    }

    public void ConfirmTraitSelection()
    {
        foreach (Toggle toggle in traitToggles)
        {
            if (toggle.isOn)
            {
                selectedTrait = toggle.name; // Use the toggle's name as the trait
                PlayerPrefs.SetString("SelectedTrait", selectedTrait);
                Debug.Log(selectedTrait + "Go fuck yourself");
                //tite
                break;
            }
        }

        panel.SetActive(false); // Hide panel after selection
    }
}