using UnityEngine;

namespace ZombieFPS
{
    /// <summary>
    /// Director that does nothing. Replace it with your own IAIDirector implementation.
    /// </summary>
    public class EmptyDirector : MonoBehaviour, IAIDirector
    {

        [SerializeField] private float _spawnTime;
        public void OnGameStart(DirectorContext context, DirectorActions actions)
        {
            
        }

        public void Tick(DirectorContext context, DirectorActions actions, float deltaTime) {
            _spawnTime += deltaTime;
            if (_spawnTime > 1f)
            {
                SpawnPointInfo enemySpawnPoint =
                    context.EnemySpawnPoints[Random.Range(0, context.EnemySpawnPoints.Count)];
                actions.SpawnEnemy(EnemyType.Common, enemySpawnPoint);
                _spawnTime = 0f;
            }
            
        }
    }
}
