﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGSI.Nodes
{
    public class WeaponNode : NodeBase
    {
        public readonly string Name;

        /// <summary>
        /// The skin this weapon currently has.
        /// </summary>
        public readonly string Paintkit;
        public readonly WeaponType Type;
        public readonly int AmmoClip;
        public readonly int AmmoClipMax;
        public readonly int AmmoReserve;
        public readonly WeaponState State;

        internal WeaponNode(string JSON)
            : base(JSON)
        {
            Name = GetString("name");
            Paintkit = GetString("paintkit");
            Type = GetEnum<WeaponType>("type");
            AmmoClip = GetInt32("ammo_clip");
            AmmoClipMax = GetInt32("ammo_clip_max");
            AmmoReserve = GetInt32("ammo_reserve");
            State = GetEnum<WeaponState>("state");
        }
    }

    public enum WeaponType
    {
        Undefined,
        Rifle,
        SniperRifle,
        SubmachineGun,
        Shotgun,
        MachineGun,
        Pistol,
        Knife,
        Grenade,
        C4,
        StackableItem
    }

    public enum WeaponState
    {
        Undefined,
        Active,
        Holstered,
        Reloading
    }
}
