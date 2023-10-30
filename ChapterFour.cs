using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChapterFour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindPartyMember();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FindPartyMember()
    {
        List<string> PartyMembers = new List<string>()
        {
            "Grim the Barbarian",
            "Merlin the wise",
            "Sterling the knight",
        };
        int listlength = PartyMembers.Count;


        PartyMembers.Add("Cavern the Necromancer");
        PartyMembers.Insert(1, "Tanis the Theif");
        PartyMembers.RemoveAt(0);
        PartyMembers.Insert(0, "Mie Enevoldsen");

        Debug.LogFormat("Party Members: {0}", listlength);

        for(int i = 0; i < listlength; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, PartyMembers[i]);

            if(PartyMembers[i] == "Merlin the wise")
            {
                Debug.Log("Glad you're here Merlin!");
            }
        }
    }

    private int LargestNumber(int a, int b)
    {
        switch (a >= b)
        {
            case true:
                return a;
            case false:
                return b;
        }
    }
}
