using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public  static bool win;
    public Text wintText;

    public Text potion1Stat;
    public Text potion2Stat;

    public Text skul1Stat;
    public Text skul2Stat;

    public Text rock1Stat;
    public Text rock2Stat;

    public Text p1HpStat;
    public Text p2HpStat;

    public CardsCollestion cardsCollestion;

    public void Show()
    {
        p1HpStat.text = "HP" + cardsCollestion.p1Hp + "/6";
        p2HpStat.text = "HP" + cardsCollestion.p2Hp + "/6";
        potion1Stat.text = "" + cardsCollestion.p1Potion + "/60";
        potion2Stat.text = "" + cardsCollestion.p2Potion + "/60";
        skul1Stat.text = "" + cardsCollestion.p1Skull + "/30";
        skul2Stat.text = "" + cardsCollestion.p2Skull + "/30";
        rock1Stat.text = "" + cardsCollestion.p1Rock;
        rock2Stat.text = "" + cardsCollestion.p2Rock;

        if (cardsCollestion.p2Hp == 0 || cardsCollestion.p1Potion == 60 || cardsCollestion.p1Skull == 30 || cardsCollestion.p1Rock == 6)
        {
            wintText.text = "PLAYER 1 WINS";
        }
        if (cardsCollestion.p1Hp == 0 || cardsCollestion.p2Potion == 60 || cardsCollestion.p2Skull == 30 || cardsCollestion.p2Rock == 6)
        {
            wintText.text = "PLAYER 2 WINS";
        }
    }
}
