using Unity.Entities;
using Unity.Entities.Serialization;
using UnityEngine;

namespace TurnBasedBasketball
{
    public class GameManager : MonoBehaviour
    {

        public static GameManager Instance;

        // Game fields
        public GameState GameState;
        public GameData GameData;
        public GameSettings GameSettings;

        // World fields
        public Entity WorldEntity;
        public GameWorld CurrentWorld;
        public GameWorldSettings WorldSettings;
        public GameWorldStoryTeller WorldStoryTeller;

        private void Awake()
        {
            Instance = this;
            GameState = new GameState();
            GameData = new GameData();
            GameSettings = new GameSettings();
        }

        private void Start()
        {

            var em = World.DefaultGameObjectInjectionWorld.EntityManager;
            WorldEntity = em.CreateEntity(
                new ComponentType(typeof(GameWorld)),
                new ComponentType(typeof(GameSettings)),
                new ComponentType(typeof(GameWorldStoryTeller))
            );

            
        }

        void Update()
        {

        }
    }

    public struct GameState
    {
        public EState State;
        public bool IsLoading;
        public bool IsPaused;
        public EManagerSimSpeed ManagerSimSpeed;
        public EGameSimSpeed GameSimSpeed;
    }

    public struct GameData
    {
        public int VersionMajor;
    }

    public struct GameSettings
    {

    }

    public enum EState
    {
        Starting,
        Idle,
        ManagerMode,
        InGameMode,
        Exiting
    }

    public enum EManagerSimSpeed
    {
        Normal,
        Fast
    }

    public enum EGameSimSpeed
    {
        Normal,
        Fast,
        VeryFast
    }
}