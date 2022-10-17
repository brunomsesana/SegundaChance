using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SavePlayer(int saveNum)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/save" + saveNum + ".exa";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData();

        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static PlayerData LoadPlayer(int saveNum)
    {
        string path = Application.persistentDataPath + "/save" + saveNum + ".exa";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;

            return data;
        } else
        {
            Debug.LogError("Save file not found in" + path);
            return null;
        }
    }
    public static void DeletePlayer(int saveNum)
    {
        string path = Application.persistentDataPath + "/save" + saveNum + ".exa";
        if (File.Exists(path))
        {
            File.Delete(path);
        }
        else
        {
            Debug.LogError("Save file not found in" + path);
        }
    }
}
