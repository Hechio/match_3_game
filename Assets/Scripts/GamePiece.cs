using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePiece : MonoBehaviour
{

    private int x;
    private int y;

    public int X
    {
        get { return x; }
        set
        {
            if (IsMovable())
            {
                x = value;
            }
        }
    }

    public int Y
    {
        get { return y; }
        set
        {
            if (IsMovable())
            {
                y = value;
            }
        }
    }



    private Grid.PieceType type;

    public Grid.PieceType Type
    {
        get { return type; }
    }

    private Grid grid;

    public Grid GridRef
    {
        get { return grid; }
    }

    private MovablePiece movableComponent;
    public MovablePiece MovableComponet
    {
        get { return movableComponent; }
    }

    private ColorPiece colorComponent;
    public ColorPiece ColorComponet
    {
        get { return colorComponent; }
    }


    private void Awake()
    {
        movableComponent = GetComponent<MovablePiece>();
        colorComponent = GetComponent<ColorPiece>();
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Init(int _x, int _y, Grid _grid, Grid.PieceType _type)
    {
        x = _x;
        y = _y;
        grid = _grid;
        type = _type;

    }

    private void OnMouseDown()
    {
        grid.PressPiece(this);
    }
    private void OnMouseEnter()
    {
        grid.EnterPiece(this);
    }
    private void OnMouseUp()
    {
        grid.ReleasePiece();
    }

    public bool IsMovable()
    {
        return movableComponent != null;
    }

    public bool IsColored()
    {
        return colorComponent != null;
    }
}
