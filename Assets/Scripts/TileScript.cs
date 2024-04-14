using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.EventSystems;

public class TileScript : MonoBehaviour
{
    public Point GridPosition { get; private set; }
    
    public bool IsEmpty { get; private set; }

    private Color32 fullColor = new Color32(255, 118, 118, 255);

    private Color32 emptyColor = new Color32(96, 255, 90, 255);

    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Setup(Point gridPos, Vector3 worldPos, Transform parent)
    {
        IsEmpty = true;
        this.GridPosition = gridPos;
        transform.position = worldPos;
        transform.SetParent(parent);

        LevelManager.Instance.Tiles.Add(gridPos, this);
    }

    private void OnMouseOver()
    {
        if (GameManager.Instance.ChoosedDemon != null)
        {
            if (IsEmpty)
            {
                ColorTile(emptyColor);
            }
            if (!IsEmpty)
            {
                ColorTile(fullColor);
            }
            else if (Input.GetMouseButtonDown(0))
            {
                PlaceDemons();
            }
        }
    }

    private void OnMouseExit()
    {
        ColorTile(Color.white);
    }

    private void PlaceDemons()
    {
        GameObject demon = Instantiate(GameManager.Instance.ChoosedDemon.DemonPrefab, transform.position,
            quaternion.identity);
        demon.GetComponent<SpriteRenderer>().sortingOrder = 16 + GridPosition.Y;
        demon.transform.SetParent(transform);
        IsEmpty = false;
        ColorTile(Color.white);
        GameManager.Instance.CastDemon();
    }

    private void ColorTile(Color newColor)
    {
        spriteRenderer.color = newColor;
    }
}