using UnityEngine;

public class ScenePersistency : MonoBehaviour
{
    public static ScenePersistency Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ResetSceneObjects()
    {
        Destroy(gameObject);
    }
}
