using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Custom_Grid : MonoBehaviour
{
    private int width;
    private int height;
    private int cellSize;
    private Vector3 originalPosition;
    private int[,] gridArray;

    public Custom_Grid(int width, int height, int cellSize, Vector3 originalPosition)
    {
        this.width = width;
        this.height = height;
        this.cellSize = cellSize;
        this.originalPosition = originalPosition;

        gridArray = new int[width, height];

        for (int x = 0; x < gridArray.GetLength(0); x++)
        {
            for (int z = 0; z < gridArray.GetLength(0); z++)
            {
                Debug.DrawLine(GetWorldPosition(x, z), GetWorldPosition(x + 1, z), Color.white, 1000f);
                Debug.DrawLine(GetWorldPosition(x, z), GetWorldPosition(x, z + 1), Color.white, 1000f);
            }
        }
    }

    public int GetCellSize()
    {
        return cellSize;
    }

    public Vector3 GetWorldPosition(int x, int z)
    {
        return new Vector3(x, 0, z) * cellSize + originalPosition;
    }

    public int[] GetXZ(Vector3 worldPosition)
    {
        int x = Mathf.FloorToInt((worldPosition - originalPosition).x / cellSize);
        int z = Mathf.FloorToInt((worldPosition - originalPosition).z / cellSize);

        return new int[] { x, z };
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
