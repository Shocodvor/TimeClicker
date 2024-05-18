using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoading : MonoBehaviour
{


public int numberOfScene;

public void SceneL ()
{
     SceneManager.LoadScene(numberOfScene);

}
}
