using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CUIManager : MonoBehaviour
{
    public Text goldDisplayer;
    public CDataController dataController;

    void Update() 
    {
        goldDisplayer.text = "GOLD : " + dataController.GetGold();
    }

}
