using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovablePiece : MonoBehaviour
{
    private GamePiece piece;


    private void Awake()
    {
        piece = GetComponent<GamePiece>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(int newX, int newY)
    {
        piece.X = newX;
        piece.Y = newY;

        piece.transform.localPosition = piece.GridRef.GetWorldPosition(newX, newY);
    }
}
