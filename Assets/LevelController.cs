using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    private static int _nextLevelIndex = 1;
    private Enemy[] _enemies;

    private void OnEnable()
    {
        _enemies = FindObjectsOfType<Enemy>();
    }

    void Update()
    {
        foreach (Enemy enemy in _enemies)
        {
            if (enemy != null)
            {
                return;
            }

            Debug.Log("You killed all enemies.");

            _nextLevelIndex++;

            if (_nextLevelIndex >= 2)
            {
                SceneManager.LoadScene("Level2");
            }
            else
            {
                string nextLevelName = "lvl" + _nextLevelIndex;
                SceneManager.LoadScene(nextLevelName);
            }
        }
    }
}