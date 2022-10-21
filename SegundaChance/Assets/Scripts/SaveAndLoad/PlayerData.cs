using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[System.Serializable]
public class PlayerData
{
    public int lastEnding;
    public int restarts;

    public PlayerData ()
    {
        lastEnding = Player.lastEnding;
        restarts = Player.restarts;
    }
}