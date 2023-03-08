using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSpawner : MonoBehaviour
{
    [SerializeField] private GameObject card;
    [SerializeField] private int amount;

     Vector3 currentElementPos;
    [SerializeField] private float offset;
    [SerializeField] int colls;
    int rndpos = 0;

    List<Vector3> possiblePositions = new List<Vector3> {new Vector3(0,0,0)};
    private void Start()
    {
        offset = offset * Camera.main.orthographicSize;
        possiblePositions.Clear();
        currentElementPos = transform.position;
        Vector3 startPos = currentElementPos;
        for (int i = 1; i < amount*2+1; i++)
        {
            possiblePositions.Add(currentElementPos);
            if (i%colls == 0 && i != 0) {
                currentElementPos = new Vector3(startPos.x, currentElementPos.y - offset, startPos.z);
                continue;
            }
            currentElementPos = new Vector3(currentElementPos.x + offset, currentElementPos.y, currentElementPos.z);
        }
        for (int i = 0; i < amount*2; i++)
        {      
            rndpos = Random.Range(0, possiblePositions.Count);
            Instantiate(card, possiblePositions[rndpos], Quaternion.identity, FindObjectOfType<Canvas>().transform);
            possiblePositions.RemoveAt(rndpos);
        }
    }
}
