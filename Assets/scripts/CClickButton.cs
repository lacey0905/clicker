using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CClickButton : MonoBehaviour
{

    public CDataController dataController;

    public void OnClick()
    {
        int goldPerClick = dataController.GetGoldPerClick();
        dataController.AddGold(goldPerClick);
    }

}
