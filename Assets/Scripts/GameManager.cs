using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{
    public DemonButton ChoosedDemon { get; set; }

    private int mana;

    [SerializeField]
    private Text manaTxt;

    public int Mana
    {
        get
        {
            return mana;
        }
        set
        {
            this.mana = value;
            this.manaTxt.text = "<color=#361515> Mana: " + value.ToString() + "</color>";
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Mana = 80;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChooseDemon(DemonButton demonBtn)
    {
        if (Hover.Instance.SpriteRenderer.enabled && ChoosedDemon == demonBtn)
        {
            Hover.Instance.Deactivate();
        }
        else
        {
            this.ChoosedDemon = demonBtn;
            Hover.Instance.Activate(demonBtn.Sprite);
        }
    }

    public void CastDemon()
    {
        Hover.Instance.Deactivate();
    }
}