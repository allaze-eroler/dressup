using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ClothesSelection : MonoBehaviour {

	public Image SelectionImage;
    public List<Sprite> ClothesList = new List<Sprite>();
    private int clothSpot = 0;

    public void Arrow_R()
    {
        if (clothSpot < ClothesList.Count-1)
        {
            clothSpot++;
            SelectionImage.sprite = ClothesList[clothSpot];
        }
    }

    public void Arrow_L()
	{
        if (clothSpot > 0)
        {
            clothSpot--;
            SelectionImage.sprite = ClothesList[clothSpot];
        }
    }

}
