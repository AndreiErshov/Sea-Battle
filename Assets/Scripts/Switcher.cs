using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Switcher : MonoBehaviour
{
    public void NextPlayer()
    {
        GameGrid array = transform.GetChild(2).gameObject.GetComponent<ShipMakerSystem>().game_grid;
        if(array.grid.ToList().Contains(true))
        {
            if(PlayerPrefs.GetString("FirstPlayer", "") == "")
            {
                PlayerPrefs.SetString("FirstPlayer", JsonUtility.ToJson(array));
                SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
            } else
            {
                PlayerPrefs.SetString("SecondPlayer", JsonUtility.ToJson(array));
                SceneManager.LoadScene (3, LoadSceneMode.Single);
            }
        }
    }
}
