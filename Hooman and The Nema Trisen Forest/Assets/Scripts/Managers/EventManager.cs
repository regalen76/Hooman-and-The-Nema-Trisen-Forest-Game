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

    public void SpawnTree()
    {
        var wolfCount = 1;

        for (int i = 0; i < wolfCount; i++)
        {
            var randomPrefab = GetRandomEvent<Event1>(Faction.first);
            var spawnedTree = Instantiate(randomPrefab);
            var randomSpawnTile = GridManager.Instance.GetTreeSpawnTile();

            randomSpawnTile.SetEvent(spawnedTree);
        }
    }

    public void SpawnTree2()
    {
        var chickinCount = 1;

        for (int i = 0; i < chickinCount; i++)
        {
            var randomPrefab = GetRandomEvent<Event2>(Faction.second);
            var spawnedTree = Instantiate(randomPrefab);
            var randomSpawnTile = GridManager.Instance.GetTree2SpawnTile();

            randomSpawnTile.SetEvent(spawnedTree);
        }
    }

    public void SpawnTree3()
    {
        var chickinCount = 1;

        for (int i = 0; i < chickinCount; i++)
        {
            var randomPrefab = GetRandomEvent<Event3>(Faction.third);
            var spawnedTree = Instantiate(randomPrefab);
            var randomSpawnTile = GridManager.Instance.GetTree2SpawnTile();

            randomSpawnTile.SetEvent(spawnedTree);
        }
    }

    public void SpawnTree4()
    {
        var chickinCount = 1;

        for (int i = 0; i < chickinCount; i++)
        {
            var randomPrefab = GetRandomEvent<Event4>(Faction.fourth);
            var spawnedTree = Instantiate(randomPrefab);
            var randomSpawnTile = GridManager.Instance.GetTreeSpawnTile();

            randomSpawnTile.SetEvent(spawnedTree);
        }
    }

    private T GetRandomEvent<T>(Faction faction) where T : BaseEvent
    {
        return (T)events.Where(u => u.Faction == faction).OrderBy(o => Random.value).First().EventPrefab;
    }
}
