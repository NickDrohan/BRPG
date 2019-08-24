using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boardController : MonoBehaviour
{
    public GameObject newPiece;
    public bool canPlace = true;
    public void addGamePiece(GameObject newObject)
    {
        if (canPlace)
        {
            canPlace = false;
            newPiece = Instantiate(newObject);
            newPiece.transform.SetParent(transform);
            newPiece.transform.localPosition = new Vector3(0.0f, 0.5f, 0.0f);
            newPiece.AddComponent<PlayerPiece>();
            StartCoroutine(repeatUntilPieceIsPlaced());
        }
    }

    IEnumerator repeatUntilPieceIsPlaced()
    {
        while (true)
        {
            if (newPiece.GetComponent<PlayerPiece>() == null)
            {
                canPlace = true;
                break;
            }
            yield return new WaitForSeconds(0.1f);
        }
    }
    
}
