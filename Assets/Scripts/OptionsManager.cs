using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OptionsManager : MonoBehaviour
{
    public TextMeshProUGUI daltonismButtonText;

    private int currentOptionIndex = 0;
    private string[] daltonismOptions = { "Desativado", "Protanopia", "Deuteranopia", "Tritanopia" };

    void Start()
    {
        UpdateButtonText();
    }

    public void ToggleDaltonismOption()
    {
        currentOptionIndex = (currentOptionIndex + 1) % daltonismOptions.Length;
        UpdateButtonText();

        switch (currentOptionIndex)
        {
            case 0:
                ApplyNormal();
                break;
            case 1:
                ApplyProtanopia();
                break;
            case 2:
                ApplyDeuteranopia();
                break;
            case 3:
                ApplyTritanopia();
            break;
            default:
            break;
        }
        
        Debug.Log(currentOptionIndex);
    }

    private void UpdateButtonText()
    {
        daltonismButtonText.text = daltonismOptions[currentOptionIndex];
    }
    
    public void ApplyProtanopia()
    {
    }

    public void ApplyDeuteranopia()
    {
    }

    public void ApplyTritanopia()
    {
    }

    public void ApplyNormal()
    {
    }
}