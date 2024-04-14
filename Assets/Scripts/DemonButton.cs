using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonButton : MonoBehaviour
{
    [SerializeField] private GameObject demonPrefab;
    [SerializeField] private Sprite sprite;
    
    public Sprite Sprite
    {
        get
        {
            return sprite;
        }
    }

    public GameObject DemonPrefab
    {
        get
        {
            return demonPrefab;
        }
    }
}
