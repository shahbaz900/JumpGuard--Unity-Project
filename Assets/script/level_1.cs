using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_1 : MonoBehaviour
{
    [SerializeField]
    private GameObject[] MonsterReference;
    private GameObject spawnedMonster;
    [SerializeField]
    private Transform rightpos;
    private int randomIndex;
    private int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMonsters());
    }

    IEnumerator SpawnMonsters()
    {
        while (true)
        {
            if (counter != 0)
            {
                yield return new WaitForSeconds(Random.Range(1, 5));
                randomIndex = Random.Range(0, MonsterReference.Length);
                spawnedMonster = Instantiate(MonsterReference[randomIndex]);
                spawnedMonster.transform.position = rightpos.position;
                spawnedMonster.GetComponent<enemy_0_script>().speed = -Random.Range(4, 10);
                spawnedMonster.transform.localScale = new Vector3(-1f, 1f, 1f);
            }
            counter++;
        }
    }
}
