using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i<10; i++) {
            GameObject prefab = Resources.Load<GameObject>("enemy_circle_1");
            Instantiate(prefab);
        }
    }
}
