using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager Instance;

    private List<ScriptableEvent> events;

    void Awake()
    {
        Instance = this;

        events = Resources.LoadAll<ScriptableEvent>("Events").ToList();
    }

    public void SpawnWolf()
    {
        var wolfCount = 1;

        for (int i = 0; i < wolfCount; i++)
        {
            var randomPrefab = GetRandomEvent<Event1>(Faction.first);
            var spawnedWolf = Instantiate(randomPrefab);
            var randomSpawnTile = GridManager.Instance.GetWolfSpawnTile();

            randomSpawnTile.SetEvent(spawnedWolf);
        }
    }

    public void SpawnChickin()
    {
        var chickinCount = 1;

        for (int i = 0; i < chickinCount; i++)
        {
            var randomPrefab = GetRandomEvent<Event2>(Faction.second);
            var spawnedChickin = Instantiate(randomPrefab);
            var randomSpawnTile = GridManager.Instance.GetChickinSpawnTile();

            randomSpawnTile.SetEvent(spawnedChickin);
        }
    }

    private T GetRandomEvent<T>(Faction faction) where T : BaseEvent
    {
        return (T)events.Where(u => u.Faction == faction).OrderBy(o => Random.value).First().EventPrefab;
    }
}
