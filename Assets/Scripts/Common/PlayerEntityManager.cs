using Unity.Entities;
using UnityEngine;

namespace TurnBasedBasketball
{
    public class PlayerEntityManager : MonoBehaviour
    {

        public EntityManager EntityManager;
        public EntityArchetype PlayerEntityArchetype;

        private void Start()
        {
            EntityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
            PlayerEntityArchetype = EntityManager.CreateArchetype(
                new ComponentType(typeof(Player)),
                new ComponentType(typeof(PlayerAttributes)),
                new ComponentType(typeof(PlayerPersonality)),
                new ComponentType(typeof(PlayerPlaystyle)),
                new ComponentType(typeof(PlayerAI))
            );

            for (int i = 0; i < 10; i++)
            {
                EntityManager.CreateEntity(PlayerEntityArchetype);
            }
            Entity e;
        }

        public void SavePlayer(Entity entity)
        {

        }

        public void LoadPlayer()
        {

        }

    }
}
