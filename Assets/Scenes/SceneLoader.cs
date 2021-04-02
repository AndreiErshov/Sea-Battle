using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void SelectScene(int index)
    {
        SceneManager.LoadScene(index, LoadSceneMode.Single);
    }

}
