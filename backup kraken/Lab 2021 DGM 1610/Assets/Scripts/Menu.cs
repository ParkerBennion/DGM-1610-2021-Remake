using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
  public void Play()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    // thank you brakeys for tutorial on how to set up unity menu.
  }
  // changes to next scene by going to the next scene sequentially in the build index order.
}
