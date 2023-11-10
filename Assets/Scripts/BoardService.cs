using StaticData;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class BoardService : MonoBehaviour
{
    [SerializeField] private RectTransform _boardRect;
    [SerializeField] private Cell _cellPrefab;
    [SerializeField] private Sprite [] _cellSprites;

    private void Start()
    {
        for (int x = 0; x < Config.BoardWidth; x++)
        {
            for (int y = 0; y < Config.BoardHeight; y++)
            {
                Cell cell = InstantiateCell();
                var point = new Point(x, y);
                cell.rect.anchoredPosition = GetBoardPositionFromPoint(point);
                var cellType = GetRandomCellType();
                cell.Initialize(cellType, point, _cellSprites[(int)(cellType -1)]);
            }
        }
    }

    private Cell.CellType GetRandomCellType()
    {
       return (Cell.CellType)(Random.Range(0, _cellSprites.Length) + 1); 
    }

    private Cell InstantiateCell()
    {
        return Instantiate(_cellPrefab, _boardRect);
    }

    private Vector2 GetBoardPositionFromPoint(Point point)
    {
        return new Vector2(
            Config.PieceSize / 2 + Config.PieceSize * point.x,
            Config.PieceSize / 2 - Config.PieceSize * point.y
            );
    }
}
