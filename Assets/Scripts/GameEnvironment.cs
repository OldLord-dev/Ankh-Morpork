using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public sealed class GameEnvironment
{
    private static GameEnvironment instance;
    private List<GameObject> checkpoints = new List<GameObject>();
    public List<GameObject> Checkpoints { get { return checkpoints; } }
    private List<GameObject> checkpoints2 = new List<GameObject>();
    public List<GameObject> Checkpoints2 { get { return checkpoints2; } }

    public static GameEnvironment Singleton
    {
        get
        {
            if (instance == null)
            {
                instance = new GameEnvironment();
                instance.Checkpoints.AddRange(
                    GameObject.FindGameObjectsWithTag("Checkpoint"));

                instance.checkpoints = instance.checkpoints.OrderBy(waypoint => waypoint.name).ToList();

                instance.Checkpoints2.AddRange(
                    GameObject.FindGameObjectsWithTag("Checkpoint2"));

                instance.checkpoints2 = instance.checkpoints2.OrderBy(waypoint => waypoint.name).ToList();
            }
            return instance;
        }
    }
}
