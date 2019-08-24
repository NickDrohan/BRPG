using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPiece : GamePiece
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            moveRight();
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            moveLeft();
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            moveDown();
        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            moveUp();
        }
        if (Input.GetKeyDown(KeyCode.E) || Input.mouseScrollDelta.y > 0)
        {
            rightate();
        }
        if (Input.GetKeyDown(KeyCode.Q) || Input.mouseScrollDelta.y < 0)
        {
            leftate();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            dropPiece();
        }
    }
}
