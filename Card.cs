using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    [SerializeField] private Sprite background;
    private Sprite icon;
    public bool isOpened;
    public int ID;
    CountCards Counter;

    private void Start()
    {
        Counter = FindObjectOfType<CountCards>().GetComponent<CountCards>();

        icon = FindObjectOfType<ChooseCard>().GetComponent<ChooseCard>().rndSprite();
        ID = FindObjectOfType<ChooseCard>().GetComponent<ChooseCard>().rndID();
        background = GetComponent<Image>().sprite;
    }    

    public void OpenCard() {
        if (!isOpened && Counter.GetComponent<CountCards>().canFlip)
        {
            isOpened = true;
            GetComponent<Image>().sprite = icon;
            Counter.GetComponent<CountCards>().Count(ID);
        }
    }

    public void CloseCard() {
        isOpened = false;
        GetComponent<Image>().sprite = background;
    }
    public void Destroing()
    {
        Destroy(gameObject);
    }
}
