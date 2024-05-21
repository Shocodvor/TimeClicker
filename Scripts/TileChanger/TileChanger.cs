      using System.Collections;
      using System.Collections.Generic;
      using UnityEngine;
      using UnityEngine.InputSystem;
      using UnityEngine.Tilemaps;

      public class TileChanger : MonoBehaviour
      {
      [SerializeField]
      private Tilemap _TileMap;
      [SerializeField]
      private TileBase _TileBase;
      [SerializeField]
      private GameObject Fx;
      [SerializeField]
      private AudioSource SoundFX;
      [SerializeField]
      private GameObject [] characters;
      [SerializeField]
      private Item Counter;
      [SerializeField]
      private Item needT;
      public List <Vector3> Items  = new List <Vector3> ();

    //переписать. Не работает для тачейыы

      void Update ()

      {

      		if (Input.GetKey(KeyCode.Mouse0) )
      		{

      var mousePos = Camera.main.ScreenToWorldPoint ((Vector3)Mouse.current.position.ReadValue());
      var cellPos = _TileMap.WorldToCell(mousePos);
      var cellPosFull = cellPos;

      foreach (Vector3 emptyCell in Items)
      {

      if (emptyCell ==cellPos )

      needT.Need = emptyCell;

      }

      }

      }

      void LateUpdate ()
      {


        if (Input.GetKey(KeyCode.Mouse0) )
        {

      var randomElement = characters[Random.Range(0, characters.Length)];
      var mousePos = Camera.main.ScreenToWorldPoint ((Vector3)Mouse.current.position.ReadValue());
      var cellPos = _TileMap.WorldToCell(mousePos);

      if (needT.Need !=cellPos)
      {

      _TileMap.SetTile (cellPos,_TileBase);  //рисуем
      var cellPosFull2 = cellPos;
      Items.Add(cellPosFull2);

      Instantiate(randomElement, mousePos, transform.rotation);
      Counter.value ++;
      SoundFX.Play(0);

      }

      }

      }

      }
