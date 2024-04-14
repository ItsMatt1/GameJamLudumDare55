using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OptionsManager : MonoBehaviour
{
    public TextMeshProUGUI daltonismButtonText;
    public Material colorblindMaterial;

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
        if (colorblindMaterial != null)
        {
            colorblindMaterial.shader = Shader.Find("Custom/Colorblind/Protanopia");
        }
    }

    public void ApplyDeuteranopia()
    {
        if (colorblindMaterial != null)
        {
            colorblindMaterial.shader = Shader.Find("Custom/Colorblind/Deuteranopia");
        }
    }

    public void ApplyTritanopia()
    {
        if (colorblindMaterial != null)
        {
            colorblindMaterial.shader = Shader.Find("Custom/Colorblind/Tritanopia");
        }
    }

    public void ApplyNormal()
    {
        if (colorblindMaterial != null)
        {
            colorblindMaterial.shader = Shader.Find("Custom/Colorblind/Tritanopia");
        }
    }
}