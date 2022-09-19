using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsManager : MonoBehaviour
{
    public bool start;
    public string cutscene;
    [SerializeField] UnityEngine.Playables.PlayableDirector[] playableDirectors;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            if (cutscene == "bus1")
            {
                playableDirectors[0].Play();
            } else if (cutscene == "bus2")
            {
                playableDirectors[1].Play();
            }
            start = false;
        }
    }
}
