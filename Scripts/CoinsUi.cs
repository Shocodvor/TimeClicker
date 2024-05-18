      using System.Collections;
      using System.Collections.Generic;
      using UnityEngine;
      using TMPro;
      using UnityEngine.UI;

      public class CoinsUi : MonoBehaviour
      {


        [SerializeField]
        private Item Coins;
        [SerializeField]
        private TextMeshProUGUI CoinsCount;

      void Start ()

      {

      Coins.value = PlayerPrefs.GetInt("CoinsCount");


      }
      void Update ()
      {
      CoinsCount.text = Coins.value.ToString();

      }


      }
