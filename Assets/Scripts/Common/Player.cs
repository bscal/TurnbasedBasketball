using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Collections;

namespace TurnBasedBasketball
{
    public struct User : IComponentData
    {
    }

    public struct Player : IComponentData
    {
        public byte Age;
        public byte Height;
        public short Weight;
        public FixedString32 FirstName;
        public FixedString32 LastName;
    }

    public struct PlayerAttributes : IComponentData
    {
    }

    public struct PlayerPersonality : IComponentData
    { }

    public struct PlayerPlaystyle : IComponentData
    { }

    public struct PlayerAI : IComponentData
    { }


}

