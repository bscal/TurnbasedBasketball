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

    public struct Person : IComponentData
    {
        public byte Age;
        public byte Height;
        public short Weight;
        public FixedString32 FirstName;
        public FixedString32 LastName;
    }


    public struct PlayerSeasonAttributes : IComponentData
    {
        public float Fatigue;
        public float Happiness;
        public float Chemistry;
        public float Condition;
    }

    public struct PlayerAttributes : IComponentData
    {
    }

    public struct PlayerStats
    {

    }

    public struct PlayerPersonality : IComponentData
    { }

    public struct PlayerPlaystyle : IComponentData
    {

        public PlayStyle PlayStyle;
        public Position Position;
        public Role Role;

    }

    public struct PlayerAI : IComponentData
    { }


    public enum PlayStyle
    {
        Balanced, Fast, Slow
    }

    public enum Position
    {
        Any, Guard, Foward, Center, Hybrid, Wing, PointGuard
    }

    public enum Role
    {
        Any, TheMan, Star, Starter, SixMan, RolePlayer, BenchWarmer
    }

}

