using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster_spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] MonsterReference;
    private GameObject spawnedMonster;
    [SerializeField]
    private Transform leftpos,rightpos;
    private int randomIndex,randomSide;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMonsters());
    }
    IEnumerator SpawnMonsters()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 5));
            randomIndex = Random.Range(0, MonsterReference.Length);
            randomSide = Random.Range(0, 2);
            spawnedMonster = Instantiate(MonsterReference[randomIndex]);
            if (randomSide == 0)
            {
                spawnedMonster.transform.position = leftpos.position;
                spawnedMonster.GetComponent<enemy_0_script>().speed = Random.Range(4, 10);

            }
            else
            {
                spawnedMonster.transform.position = rightpos.position;
                spawnedMonster.GetComponent<enemy_0_script>().speed = -Random.Range(4, 10);
                spawnedMonster.transform.localScale = new Vector3(-1f, 1f, 1f);
            }
        }
    }
    
}
