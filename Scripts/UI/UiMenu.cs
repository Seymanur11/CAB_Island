using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UiMenu : MonoBehaviour
{
  // Start is called before the first frame update
  public void PlayGame()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }
  public void QuitGame()
  {
    Application.Quit();
  }

  public void EscGame()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
  }



}
