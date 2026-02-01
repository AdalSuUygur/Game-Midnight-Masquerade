using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    GameManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }
    public static void PrepareScene()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);

    }
    


    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        GameObject spawnPoint = GameObject.FindGameObjectWithTag("Respawn");

        if (player != null && spawnPoint != null)
        {
             player.transform.position = spawnPoint.transform.position;
        }
        else
        {
            if (player == null) Debug.LogError("Player object not found in the scene! Make sure an object is tagged 'Player'.");
            if (spawnPoint == null) Debug.LogError("SpawnPoint object not found in the scene! Make sure an object is tagged 'Respawn'.");
        }
    }
}
