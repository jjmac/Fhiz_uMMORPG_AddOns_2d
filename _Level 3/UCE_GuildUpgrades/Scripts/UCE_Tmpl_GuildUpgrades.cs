﻿using UnityEngine;

// =======================================================================================
// GUILD UPGRADES CONFIG
// =======================================================================================
[CreateAssetMenu(fileName = "UCE Guild Upgrades", menuName = "UCE Templates/New UCE Guild Upgrades", order = 999)]
public class UCE_Tmpl_GuildUpgrades : ScriptableObject
{
    [Header("[CAPACITY]")]
    public LinearInt guildCapacity = new LinearInt { baseValue = 10 };

    [Header("[REWARDS (1 item per level)]")]
    [Tooltip("The player who is upgrading gains the item")]
    public ScriptableItemAndAmount[] rewardItem;

    [Header("[UPRADING]")]
    public UCE_Cost[] guildUpgradeCost;

    [Header("[MESSAGES]")]
    public string guildUpgradeLabel = "Guild upgraded!";
}

// =======================================================================================