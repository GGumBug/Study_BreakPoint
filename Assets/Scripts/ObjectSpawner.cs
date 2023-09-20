using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    GameObject origin;
    int spawnCount = 10;

    public void SpwanObject()
    {
        Instantiate(origin);
    }

    public void SpwanObjects()
    {
        for (int i = 0; i < spawnCount; i++)
        {
            int idx = i;

            if (i == 6)
                origin = null;

            Instantiate(origin);
        }
    }
}
