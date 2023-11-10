using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    public enum CellType
    {
        Hole = -1,
        Blank = 0,
        Apple  = 1,
        Lemon = 2,
        Bread = 3,
        Broccoli = 4,
        Coconut = 5
    }
    public RectTransform rect;
    [SerializeField] private Image _image;
    private CellType _cellType;
    private Point _point;

    public void Initialize(CellType cellType, Point point, Sprite sprite)
    {
        _cellType = cellType;
        _point = point;
        _image.sprite = sprite;
    }
}
