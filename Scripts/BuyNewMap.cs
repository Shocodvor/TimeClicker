using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyNewMap : MonoBehaviour
{

  [SerializeField]
  private Item CoinsItem;
  [SerializeField]
  private int needCoins;
  [SerializeField]
  private GameObject button;
  [SerializeField]
  private GameObject Lock;
  [SerializeField]
  private string Level;


  void Awake ()
  {

  if (PlayerPrefs.GetString (key: Level) == "Open")

    {

      button.SetActive (true);
      Lock.SetActive (false);

    }

  }


  public void BuiNewMap ()


  {
  if (CoinsItem.value>=needCoins){
      CoinsItem.value -= needCoins;
      button.SetActive (true);
      Lock.SetActive (false);
      PlayerPrefs.SetInt("CoinsCount", CoinsItem.value);
      PlayerPrefs.SetString (Level, "Open");
    }


  }


}
