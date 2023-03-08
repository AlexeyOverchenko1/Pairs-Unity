using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountCards : MonoBehaviour
{

    private int currentOpenedAmount = 0;
    private int curID = -1;

    public bool canFlip = true;
    bool haveDifference=  false;
    public void Count(int ID) {
        canFlip = currentOpenedAmount != 2;

        currentOpenedAmount++;
        curID = curID == -1 ? ID : curID;
        haveDifference = curID == ID ? haveDifference : true;
        if (currentOpenedAmount == 2) {
            Invoke("FlipCards",1);
            canFlip = false;
        }
    }
    private void FlipCards() {
        foreach (var item in FindObjectsOfType<Card>())
        {
            if (item.isOpened) {
                item.CloseCard();
                if (!haveDifference)
                    item.Destroing();
                currentOpenedAmount--;
            }
        }
        curID = -1;
        haveDifference = false;
        canFlip = true;
    }
}
