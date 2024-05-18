using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalUi : MonoBehaviour
{

  [SerializeField]
  private events _events;
  [SerializeField]
  private GameObject Ui;



    private void OnEnable()
     {


      events.OnEvent += OnUi;


     }

     private void OnDisable()
     {
          events.OnEvent -= OnUi;
     }

     public void OnUi()
      {

        Ui.SetActive (true);
        OnDisable();


      }




}
