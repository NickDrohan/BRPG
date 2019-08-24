using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePiece : MonoBehaviour
{

    private Vector3 rightVector = new Vector3(2.0f, 0.0f, 0.0f);
    private Vector3 leftVector = new Vector3(-2.0f, 0.0f, 0.0f);
    private Vector3 upVector = new Vector3(0.0f, 0.0f, 2.0f);
    private Vector3 downVector = new Vector3(0.0f, 0.0f, -2.0f);
    private Vector3 rightRotationVector = new Vector3(0,0, 90);
    private Vector3 leftRotationVector = new Vector3(0, 0, -90);
    private Transform lastPosition;
    public void moveRight()
    {
        lastPosition = transform;
        this.transform.localPosition = this.transform.localPosition + rightVector;
    }
    public void moveLeft()
    {
        lastPosition = transform;
        this.transform.localPosition = this.transform.localPosition + leftVector;
    }
    public void moveUp()
    {
        lastPosition = transform;
        this.transform.localPosition = this.transform.localPosition + upVector;
    }
    public void moveDown()
    {
        lastPosition = transform;
        this.transform.localPosition = this.transform.localPosition + downVector;
    }
    public void rightate()
    {
        lastPosition = transform;
        transform.Rotate(rightRotationVector);
    }
    public void leftate()
    {
        lastPosition = transform;
        transform.Rotate(leftRotationVector);
    }
    public void goBack()
    {
        transform.SetPositionAndRotation(lastPosition.position, lastPosition.rotation);
    }

    bool canPlace = true;
    public void dropPiece()
    {
        if (canPlace)
        {
            canPlace = false;
            //GameObject newObject = Instantiate(this.gameObject);
            //newObject.transform.SetPositionAndRotation(transform.position, transform.rotation);
            Destroy(GetComponent<PlayerPiece>());
            //Destroy(gameObject);
        }
    }

}
