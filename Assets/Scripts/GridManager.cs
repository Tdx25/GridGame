using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public int numRows = 5;

    public int numColumns = 6;

    public float padding = 0.1f;

    [SerializeField] private GridTile tilePrefab;

    private void Awake()
    {
        InitGrid();
    }

    public void InitGrid()
    {
        for (int y = 0; y <  numRows; y++)
        {
            for (int x = 0; x < numColumns; x++) 
            {
                GridTile tile = Instantiate(tilePrefab, transform);
                Vector2 tilePos = new Vector2(x * (padding * x), y * (padding * y));
                tile.transform.position = tilePos;
                tile.name = $"Tile_(x)_(y)";
            }
        }
    }

}
