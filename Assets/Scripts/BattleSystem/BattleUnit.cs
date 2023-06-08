using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleUnit : MonoBehaviour
{
    [SerializeField] private CalcoerBase calcoerBase;
    [SerializeField] private int level;
    [SerializeField] private bool isPlayerUnit;

    public Calcoer Calcoer { get; set; }

    public void Setup()
    {
        Calcoer = new Calcoer(calcoerBase, level);
        if (isPlayerUnit)
        {
            Debug.Log("Image.sprite: " + GetComponent<Image>().sprite);
            Debug.Log("Calcoer: " + Calcoer);
            Debug.Log("CalcoerBase: " + Calcoer.CalcoerBase);
            Debug.Log("CalcoerBaseBacksprite: " + Calcoer.CalcoerBase.BackSprite);

            GetComponent<Image>().sprite = Calcoer.CalcoerBase.BackSprite;
        }
        else
            GetComponent<Image>().sprite = Calcoer.CalcoerBase.FrontSprite;
    }
}
