using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OptionsManager : MonoBehaviour
{
    public TextMeshProUGUI daltonismButtonText;
    public TextMeshProUGUI velocityButtonText;

    private int currentDaltonismOptionIndex = 0;
    private int currentVelocityOptionIndex = 1;
    private string[] daltonismOptions = { "Desativado", "Protanopia", "Deuteranopia", "Tritanopia" };
    private string[] velocityOptions = { "Lento", "Normal" };

    void Start()
    {
        UpdateDaltonismButtonText();
        UpdateVelocityButtonText();
    }

    public void ToggleDaltonismOption()
    {
        MenuManager.SelectedMenu();
        currentDaltonismOptionIndex = (currentDaltonismOptionIndex + 1) % daltonismOptions.Length;
        UpdateDaltonismButtonText();

        switch (currentDaltonismOptionIndex)
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
        
        Debug.Log(currentDaltonismOptionIndex);
    }
    
    public void ToggleVelocityOption()
    {
        MenuManager.SelectedMenu();
        currentVelocityOptionIndex = (currentVelocityOptionIndex + 1) % velocityOptions.Length;
        UpdateVelocityButtonText();

        switch (currentVelocityOptionIndex)
        {
            case 0:
                ApplyNormalVelocity();
                break;
            case 1:
                ApplySlow();
                break;
            default:
                break;
        }
        
        Debug.Log(currentVelocityOptionIndex);
    }

    private void UpdateDaltonismButtonText()
    {
        daltonismButtonText.text = daltonismOptions[currentDaltonismOptionIndex];
    }
    
    private void UpdateVelocityButtonText()
    {
        velocityButtonText.text = velocityOptions[currentVelocityOptionIndex];
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
    
    public void ApplySlow()
    {
    }
    
    public void ApplyNormalVelocity()
    {
    }
}