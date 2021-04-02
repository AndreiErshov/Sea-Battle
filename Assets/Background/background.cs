using UnityEngine;
using UnityEngine.SceneManagement;

public class background : MonoBehaviour
{

    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
        SceneManager.LoadScene(1);
    }

}
