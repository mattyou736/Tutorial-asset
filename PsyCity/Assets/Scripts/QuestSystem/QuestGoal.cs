﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestGoal
{
    public GoalType goalType;

    public int requiredAmount;
    public int currentAmount;

    public bool IsReached()
    {
        return (currentAmount >= requiredAmount);
    }

    public void enemyKilled()
    {
        if(goalType == GoalType.Kill)
            currentAmount++;
    }

    public void ItemsGotten()
    {
        if (goalType == GoalType.Gathering)
            currentAmount++;
    }
}

public enum GoalType
{
    Kill,
    Gathering
}
