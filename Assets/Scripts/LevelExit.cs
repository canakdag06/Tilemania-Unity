using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelExit : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(LoadNextLevel());
    }

    IEnumerator LoadNextLevel()
    {
        yield return new WaitForSecondsRealtime(loadDelay);
        int nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
        if(nextLevel == SceneManager.sceneCountInBuildSettings)
        {
            nextLevel = 0;
        }
        ScenePersistency.Instance.ResetSceneObjects();
        SceneManager.LoadScene(nextLevel);
    }
}
