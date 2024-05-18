      using System.Collections;
      using System.Collections.Generic;
      using UnityEngine;
      using UnityEngine.Events;



      public class events : MonoBehaviour
      {
      public static event UnityAction OnEvent;

      public Item Counter;
      public int needGoal;

      void Update()
      {

      if (Counter.value > needGoal)


      OnEvent?.Invoke();



      }

      }
