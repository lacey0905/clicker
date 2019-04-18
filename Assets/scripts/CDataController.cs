using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CDataController : MonoBehaviour
{

    private static CDataController instance;


    public static CDataController GetInstance()
    {
        if(instance == null)
        {
            instance = FindObjectOfType<CDataController>();

            if(instance == null)
            {
                GameObject container = new GameObject("CDataController");
                instance = container.AddComponent<CDataController>();
            }
        }
        return instance;
    }


    [SerializeField]
    private int m_gold = 0;

    [SerializeField]
    private int m_goldPerClick = 0;

    void Awake() {
        // Local 데이터 저장
        // Key : Velue
        m_gold = PlayerPrefs.GetInt("Gold");
        m_goldPerClick = PlayerPrefs.GetInt("GoldPerClick", 1);
    }

    public void SetGold(int newGold)
    {
        m_gold = newGold;
        PlayerPrefs.SetInt("Gold", m_gold);
    }

    public void AddGold(int newGold)
    {
        m_gold += newGold;
        SetGold(m_gold);
    }

    public void SubGold(int newGold)
    {
        m_gold -= newGold;
        SetGold(m_gold);
    }

    public int GetGold()
    {
        return m_gold;
    }

    public int GetGoldPerClick()
    {
        return m_goldPerClick;
    }

    public void SetGoldPerClick(int newGoldPerClick)
    {
        m_goldPerClick = newGoldPerClick;
        PlayerPrefs.SetInt("GoldPerClick", m_goldPerClick);
    }

    public void AddGoldPerClick(int newGoldPerClick)
    {
        m_goldPerClick += newGoldPerClick;
        SetGoldPerClick(m_goldPerClick);
    }

}
