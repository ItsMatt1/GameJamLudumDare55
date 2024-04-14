using System;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : Singleton<LevelManager>
{
    [SerializeField]
    private GameObject[] tilePrefabs;

    private int levelInt = 1;

    public Dictionary<Point, TileScript> Tiles;

    private float TileSize => tilePrefabs[0].GetComponent<SpriteRenderer>().sprite.bounds.size.x;

    // Start is called before the first frame update
    void Start()
    {
        CreateLevel();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void CreateLevel()
    {
        Tiles = new Dictionary<Point, TileScript>();
        
        string[] mapData = ReadLevelText();

        int mapXSize = mapData[0].ToCharArray().Length;
        int mapYSize = mapData.Length;
            
        for (int y = 0; y < mapYSize; y++)
        {
            char[] newTiles = mapData[y].ToCharArray();
            for (int x = 0; x < mapXSize; x++)
            {
                PlaceTile(newTiles[x].ToString(), x, y);
            }
        }
    }

    private void PlaceTile(string tileType, int x, int y)
    {
        int tileIndex = 0;
        switch (tileType)
        {
            case "a":
                tileIndex = 0;
                break;
            case "b":
                tileIndex = 1;
                break;
            case "c":
                tileIndex = 2;
                break;
            case "d":
                tileIndex = 3;
                break;
            case "e":
                tileIndex = 4;
                break;
            case "f":
                tileIndex = 5;
                break;
            case "g":
                tileIndex = 6;
                break;
            case "h":
                tileIndex = 7;
                break;
            case "i":
                tileIndex = 8;
                break;
            case "j":
                tileIndex = 9;
                break;
            case "k":
                tileIndex = 10;
                break;
            case "l":
                tileIndex = 11;
                break;
            case "m":
                tileIndex = 12;
                break;
            case "n":
                tileIndex = 13;
                break;
            case "o":
                tileIndex = 14;
                break;
            case "p":
                tileIndex = 15;
                break;
            case "q":
                tileIndex = 16;
                break;
            case "r":
                tileIndex = 17;
                break;
            case "s":
                tileIndex = 18;
                break;
            case "t":
                tileIndex = 19;
                break;
            case "u":
                tileIndex = 20;
                break;
            case "v":
                tileIndex = 21;
                break;
            case "w":
                tileIndex = 22;
                break;
            case "x":
                tileIndex = 23;
                break;
        }

        TileScript newTile = Instantiate(tilePrefabs[tileIndex]).GetComponent<TileScript>();
        
        newTile.Setup(new Point(x, y), new Vector3(TileSize * x, TileSize * -y, 3));
        
        Tiles.Add(new Point(x, y), newTile);
    }

    private string[] ReadLevelText()
    {
        TextAsset data = Resources.Load("Level" + levelInt) as TextAsset;

        string temporaryData = data.text.Replace(Environment.NewLine, string.Empty);

        return temporaryData.Split('-');
    }
}
