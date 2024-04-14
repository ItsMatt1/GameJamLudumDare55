using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public DemonButton ChoosedDemon { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        
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