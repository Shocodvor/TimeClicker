using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToGoal : MonoBehaviour
{


  [SerializeField]
  private events _events;
  [SerializeField]
  private Item Coins;
  [SerializeField]
  private int coiinsCount;




  private void OnEnable()
   {


    events.OnEvent += OnAdsStart;


   }

   private void OnDisable()
   {
        events.OnEvent -= OnAdsStart;
   }




   public void OnAdsStart()
    {

      Coins.value += coiinsCount;
      PlayerPrefs.SetInt("CoinsCount", Coins.value);
      OnDisable();


    }
}
