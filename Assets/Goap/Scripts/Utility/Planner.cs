using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public static class Planner
{

    public static List<GoapAction> Plan(GoapAction startAction, GoapAction goalAction, List<GoapAction> allActions)
    {

        List<GoapAction> openList = new List<GoapAction>();
        List<GoapAction> closedList = new List<GoapAction>();

        GoapAction currentAction = null;


        int g = 0;


        openList.Add(startAction);
        while (openList.Count > 0)
        {
            int cheapestPrice = openList.Min(x => x.Price);
            currentAction = openList.First(x => x.Price == cheapestPrice);

            closedList.Add(currentAction);
            openList.Remove(currentAction);

            if (closedList.FirstOrDefault(x => x.IsGoal) != null) break;

            List<GoapAction> nextActions = new List<GoapAction>();
            foreach (var item in currentAction.EffectorList)
            {
                List<GoapAction> comingActions = allActions.Where(x => x.PreconditionList.Contains(item)).ToList();
                foreach (var subItem in comingActions)
                {
                    nextActions.Add(subItem);
                }
            }

            g++;



            foreach (var upcomingAction in nextActions)
            {
                if (closedList.Contains(upcomingAction)) continue;

                if (!openList.Contains(upcomingAction))
                {
                    upcomingAction.G = g;
                    upcomingAction.H = upcomingAction.Price;
                    upcomingAction.F = upcomingAction.G + upcomingAction.H;
                    upcomingAction.Parent = currentAction;
                    openList.Insert(0, upcomingAction);
                }

                else
                {
                    if (g + upcomingAction.H < upcomingAction.F)
                    {
                        upcomingAction.G = g;
                        upcomingAction.F = upcomingAction.G + upcomingAction.H;
                        upcomingAction.Parent = currentAction;
                    }
                }
            }



        }


        while (currentAction != null)
        {
            currentAction = currentAction.Parent;
        }

        return closedList;

    }

    public static string LogPlan(List<GoapAction> actions)
    {
        StringBuilder builder = new StringBuilder();
        foreach (var item in actions)
        {
            builder.Append(item.GetType().Name).Append("|||");
        }

        return builder.ToString();
    }


}
