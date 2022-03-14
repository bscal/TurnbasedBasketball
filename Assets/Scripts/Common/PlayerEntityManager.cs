using Unity.Entities;
using Unity.Mathematics;
using Unity.Rendering;
using Unity.Transforms;
using UnityEngine;

namespace TurnBasedBasketball
{
    public class PlayerEntityManager : MonoBehaviour
    {

        public GameObject PlayerPrefab;

        private EntityManager EntityManager;
        private EntityArchetype PlayerEntityArchetype;
        private Entity PlayerPrefabEntity;

        private void Start()
        {
            EntityManager = World.DefaultGameObjectInjectionWorld.EntityManager;

            PlayerEntityArchetype = EntityManager.CreateArchetype(
                typeof(PlayerSeasonAttributes),
                typeof(PlayerAttributes),
                typeof(PlayerPersonality),
                typeof(PlayerPlaystyle),
                typeof(PlayerAI)
            );

            GameObjectConversionSettings conversion = GameObjectConversionSettings.FromWorld(World.DefaultGameObjectInjectionWorld, null);
            PlayerPrefabEntity = GameObjectConversionUtility.ConvertGameObjectHierarchy(PlayerPrefab, conversion);

            for (int i = 0; i < 10; i++)
            {
                EntityManager.CreateEntity(PlayerEntityArchetype);
            }

            InstantiateBoardPlayer(new float3(0, 1, 0));

        }

        public Entity InstantiateBoardPlayer(float3 position)
        {
            Entity entity = EntityManager.Instantiate(PlayerPrefabEntity);
            EntityManager.SetComponentData(entity, new Translation
            {
                Value = position
            });

            return entity;
        }

        public void SavePlayer(Entity entity)
        {

        }

        public void LoadPlayer()
        {

        }

    }
}
