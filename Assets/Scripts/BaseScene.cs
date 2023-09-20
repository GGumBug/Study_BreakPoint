using UnityEditor.SceneManagement;
using UnityEngine;

public class BaseScene : MonoBehaviour
{
    ObjectSpawner objectSpawner;

    private void Start()
    {
        Init();
    }

    void Init()
    {
        objectSpawner.SpwanObject();
        objectSpawner.SpwanObjects();
    }
}
