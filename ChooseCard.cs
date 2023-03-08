using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseCard : MonoBehaviour
{
    [SerializeField] Sprite[] cards;
    bool hasPair = true;
    [SerializeField] bool uniqueOnly;
    int ID = 0;

    public Sprite rndSprite() {
        if (hasPair && uniqueOnly)
        {
            ID++;
        }
        else if (!uniqueOnly && hasPair)
            ID = Random.Range(0, cards.Length);
        hasPair = !hasPair;
        return cards[ID];
    }

    public int rndID() {
        return ID;
    }
}
