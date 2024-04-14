using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonButton : Singleton<DemonButton>
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

    [SerializeField]
    private int manaCost;

    public int ManaCost
    {
        get
        {
            return manaCost;
        }
    }
    
}
